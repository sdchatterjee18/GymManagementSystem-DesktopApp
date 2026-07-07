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

    BEGIN TRY

        ------------------------------------------------
        -- Member Validation
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMember
            WHERE MemberId = @MemberId
              AND IsActive = 1
        )
        BEGIN
            SELECT 'Member does not exist.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Trainer Validation
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
            SELECT 'Trainer does not exist or inactive.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Active Membership Validation
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMembershipSubscription
            WHERE MemberId = @MemberId
              AND ExpiryDate >= CAST(GETDATE() AS DATE)
        )
        BEGIN
            SELECT 'Member has no active membership.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Current Active Trainer
        ------------------------------------------------
        SELECT TOP (1)
            @CurrentTrainerId = TrainerId,
            @AssignedDate = AssignedDate
        FROM tblMemberTrainerAssignment
        WHERE MemberId = @MemberId
          AND IsActive = 1
        ORDER BY AssignedDate DESC;

        ------------------------------------------------
        -- First Time Assignment
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

            SELECT 'Trainer assigned successfully.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Already Assigned
        ------------------------------------------------
        IF @CurrentTrainerId = @TrainerId
        BEGIN
            SELECT 'Member is already assigned to this trainer.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Trainer Change Restriction
        ------------------------------------------------
        IF YEAR(@AssignedDate) = YEAR(GETDATE())
           AND MONTH(@AssignedDate) = MONTH(GETDATE())
        BEGIN
            SELECT 'Trainer can be changed only from next month.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Change Trainer
        ------------------------------------------------
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

        SELECT 'Trainer changed successfully.' AS Message;

    END TRY

    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO