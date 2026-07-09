CREATE PROC spChangePersonalTrainer
(
    @MemberId INT,
    @NewTrainerId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE
        @ShiftId INT,
        @OldTrainerId INT;

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
        -- New Trainer Validation
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblTrainer T
            INNER JOIN tblEmployee E
                ON T.EmployeeId = E.EmployeeId
            WHERE T.TrainerId = @NewTrainerId
              AND E.IsActive = 1
        )
        BEGIN
            SELECT 'New trainer does not exist or is inactive.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Member Active Shift
        ------------------------------------------------
        SELECT @ShiftId = ShiftId
        FROM tblMemberShift
        WHERE MemberId = @MemberId
          AND IsActive = 1;

        IF @ShiftId IS NULL
        BEGIN
            SELECT 'Member has no active shift.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Current Active Trainer
        ------------------------------------------------
        SELECT @OldTrainerId = TrainerId
        FROM tblMemberTrainerAssignment
        WHERE MemberId = @MemberId
          AND IsActive = 1;

        IF @OldTrainerId IS NULL
        BEGIN
            SELECT 'No personal trainer is assigned to this member.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Same Trainer Validation
        ------------------------------------------------
        IF @OldTrainerId = @NewTrainerId
        BEGIN
            SELECT 'This trainer is already assigned to the member.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- New Trainer Availability Validation
        ------------------------------------------------
        IF EXISTS
        (
            SELECT 1
            FROM tblTrainerShift
            WHERE TrainerId = @NewTrainerId
              AND ShiftId = @ShiftId
              AND IsActive = 0
        )
        BEGIN
            SELECT 'New trainer is not available in this shift.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Change Trainer
        ------------------------------------------------
        BEGIN TRANSACTION;

        -- Old Assignment Inactive
        UPDATE tblMemberTrainerAssignment
        SET IsActive = 0
        WHERE MemberId = @MemberId
          AND TrainerId = @OldTrainerId
          AND IsActive = 1;

        -- Old Trainer Available Again
        UPDATE tblTrainerShift
        SET IsActive = 1
        WHERE TrainerId = @OldTrainerId
          AND ShiftId = @ShiftId;

        -- New Assignment
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
            @NewTrainerId,
            CAST(GETDATE() AS DATE),
            1
        );

        -- New Trainer Unavailable
        UPDATE tblTrainerShift
        SET IsActive = 0
        WHERE TrainerId = @NewTrainerId
          AND ShiftId = @ShiftId;

        COMMIT TRANSACTION;

        SELECT 'Personal trainer changed successfully.' AS Message;

    END TRY

    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO