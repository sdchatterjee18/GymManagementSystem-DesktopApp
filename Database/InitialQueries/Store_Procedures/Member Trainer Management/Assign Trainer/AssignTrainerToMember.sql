CREATE PROC spAssignTrainerToMember
(
    @MemberId INT,
    @TrainerId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CurrentTrainerId INT = NULL,
            @AssignedDate DATE = NULL;

    -- Member Exists
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

    -- Trainer Exists
    IF NOT EXISTS
    (
        SELECT 1
        FROM tblTrainer
        WHERE TrainerId = @TrainerId
          AND IsActive = 1
    )
    BEGIN
        RAISERROR('Trainer does not exist.',16,1);
        RETURN;
    END

    -- Active Membership Exists
    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMembershipSubscription
        INNER JOIN tblMembershipPlans
            ON tblMembershipSubscription.MembershipPlanId =
               tblMembershipPlans.MembershipPlanId
        WHERE tblMembershipSubscription.MemberId = @MemberId
          AND tblMembershipSubscription.IsActive = 1
          AND tblMembershipPlans.IsActive = 1
          AND tblMembershipSubscription.ExpiryDate >= CAST(GETDATE() AS DATE)
    )
    BEGIN
        RAISERROR('Member has no active membership.',16,1);
        RETURN;
    END

    -- Current Active Trainer
    SELECT TOP 1
        @CurrentTrainerId = TrainerId,
        @AssignedDate = AssignedDate
    FROM tblMemberTrainerAssignment
    WHERE MemberId = @MemberId
      AND IsActive = 1
    ORDER BY AssignedDate DESC;

    -- First Time Assignment
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

        SELECT
            1 AS Success,
            'Trainer assigned successfully.' AS Message;

        RETURN;
    END

    -- Same Trainer
    IF @CurrentTrainerId = @TrainerId
    BEGIN
        SELECT
            1 AS Success,
            'Member continues with current trainer.' AS Message;

        RETURN;
    END

    -- Same Month Change Not Allowed
    IF YEAR(@AssignedDate) = YEAR(GETDATE())
       AND MONTH(@AssignedDate) = MONTH(GETDATE())
    BEGIN
        SELECT
            0 AS Success,
            'Trainer change is allowed only from next month.' AS Message;

        RETURN;
    END

    BEGIN TRY

        BEGIN TRANSACTION;

        -- Deactivate Old Assignment
        UPDATE tblMemberTrainerAssignment
        SET IsActive = 0
        WHERE MemberId = @MemberId
          AND IsActive = 1;

        -- Insert New Assignment
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

        SELECT
            1 AS Success,
            'Trainer changed successfully.' AS Message;

    END TRY
    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        THROW;

    END CATCH

END
GO