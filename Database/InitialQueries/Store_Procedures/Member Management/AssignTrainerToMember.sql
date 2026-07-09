CREATE PROC spAssignPersonalTrainerToMember
(
    @MemberId INT,
    @TrainerId INT
)
AS
BEGIN
    SET NOCOUNT ON;

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
            SELECT 'Member does not exist or is inactive.' AS Message;
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
              AND IsActive = 1
              AND ExpiryDate >= CAST(GETDATE() AS DATE)
        )
        BEGIN
            SELECT 'Member has no active membership.' AS Message;
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
            SELECT 'Trainer does not exist or is inactive.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Personal Trainer Already Assigned Validation
        ------------------------------------------------
        IF EXISTS
        (
            SELECT 1
            FROM tblMemberTrainerAssignment
            WHERE MemberId = @MemberId
              AND IsActive = 1
        )
        BEGIN
            SELECT 'Personal trainer is already assigned to this member.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Assign Personal Trainer
        ------------------------------------------------
        BEGIN TRANSACTION;

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

        SELECT 'Personal trainer assigned successfully.' AS Message;

    END TRY

    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH

END;
GO