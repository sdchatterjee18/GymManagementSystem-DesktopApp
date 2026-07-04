CREATE PROC spAssignPersonalTrainerToMember
(
    @MemberId INT,
    @TrainerId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CurrentTrainerId INT = NULL,
            @AssignedDate DATE = NULL;

    ------------------------------------------------
    -- Member Exists
    ------------------------------------------------
    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMember
        WHERE MemberId = @MemberId
          AND IsActive = 1
    )
    BEGIN
        RAISERROR('Member does not exist.',16,1);
        RETURN;
    END

    ------------------------------------------------
    -- Trainer Exists (Employee-based validation)
    ------------------------------------------------
    IF NOT EXISTS
    (
        SELECT 1
        FROM tblTrainer T
        INNER JOIN tblEmployee E
            ON T.EmployeeId = E.EmployeeId
        WHERE T.TrainerId = @TrainerId
          AND E.IsActive = 1
    )
    BEGIN
        RAISERROR('Trainer does not exist or inactive.',16,1);
        RETURN;
    END

    ------------------------------------------------
    -- Active Membership Check
    ------------------------------------------------
    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMembershipSubscription MS
        WHERE MS.MemberId = @MemberId
          AND MS.ExpiryDate >= CAST(GETDATE() AS DATE)
    )
    BEGIN
        RAISERROR('Member has no active membership.',16,1);
        RETURN;
    END

    ------------------------------------------------
    -- Current Trainer
    ------------------------------------------------
    SELECT TOP 1
        @CurrentTrainerId = TrainerId,
        @AssignedDate = AssignedDate
    FROM tblMemberTrainerAssignment
    WHERE MemberId = @MemberId
      AND IsActive = 1
    ORDER BY AssignedDate DESC;

    ------------------------------------------------
    -- FIRST TIME ASSIGNMENT
    ------------------------------------------------
    IF @CurrentTrainerId IS NULL
    BEGIN
        INSERT INTO tblMemberTrainerAssignment
        (
            MemberId,
            TrainerId,
            AssignedDate,
            IsActive
        )
        VALUES
        (
            @MemberId,
            @TrainerId,
            CAST(GETDATE() AS DATE),
            1
        );

        SELECT 1 AS Success, 'Trainer assigned successfully.' AS Message;
        RETURN;
    END

    ------------------------------------------------
    -- SAME TRAINER
    ------------------------------------------------
    IF @CurrentTrainerId = @TrainerId
    BEGIN
        SELECT 1 AS Success, 'Already assigned to this trainer.' AS Message;
        RETURN;
    END

    ------------------------------------------------
    -- SAME MONTH RESTRICTION
    ------------------------------------------------
    IF YEAR(@AssignedDate) = YEAR(GETDATE())
       AND MONTH(@AssignedDate) = MONTH(GETDATE())
    BEGIN
        SELECT 0 AS Success, 'Trainer change allowed only from next month.' AS Message;
        RETURN;
    END

    ------------------------------------------------
    -- CHANGE TRAINER
    ------------------------------------------------
    BEGIN TRY
        BEGIN TRANSACTION;

        UPDATE tblMemberTrainerAssignment
        SET IsActive = 0
        WHERE MemberId = @MemberId
          AND IsActive = 1;

        INSERT INTO tblMemberTrainerAssignment
        (
            MemberId,
            TrainerId,
            AssignedDate,
            IsActive
        )
        VALUES
        (
            @MemberId,
            @TrainerId,
            CAST(GETDATE() AS DATE),
            1
        );

        COMMIT TRANSACTION;

        SELECT 1 AS Success, 'Trainer changed successfully.' AS Message;

    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT ERROR_MESSAGE() AS Message;
    END CATCH

END
GO