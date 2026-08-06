CREATE PROC spChangeMemberShift
(
    @MemberId INT,
    @NewShiftId INT
)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE
        @CurrentShiftId INT,
        @TrainerId INT,
        @MaxCapacity INT,
        @CurrentMemberCount INT;

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
              AND ExpiryDate >= CAST(GETDATE() AS DATE)
              AND IsActive = 1
        )
        BEGIN
            SELECT 'Member has no active membership.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Shift Validation
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblShift
            WHERE ShiftId = @NewShiftId
        )
        BEGIN
            SELECT 'Invalid Shift.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Get Current Active Shift
        ------------------------------------------------
        SELECT
            @CurrentShiftId = ShiftId
        FROM tblMemberShift
        WHERE MemberId = @MemberId
          AND IsActive = 1;

        IF @CurrentShiftId IS NULL
        BEGIN
            SELECT 'Current active shift not found.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Same Shift Validation
        ------------------------------------------------
        IF @CurrentShiftId = @NewShiftId
        BEGIN
            SELECT 'Member is already assigned to this shift.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Get Shift Capacity
        ------------------------------------------------
        SELECT TOP (1)
            @MaxCapacity = MaxCapacity
        FROM tblShiftCapacity;

        IF @MaxCapacity IS NULL
        BEGIN
            SELECT 'Shift capacity is not configured.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Check Current Member Count
        ------------------------------------------------
        SELECT
            @CurrentMemberCount = COUNT(*)
        FROM tblMemberShift
        WHERE ShiftId = @NewShiftId
          AND IsActive = 1;

        IF @CurrentMemberCount >= @MaxCapacity
        BEGIN
            SELECT 'Selected shift is already full.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Get Active Personal Trainer
        ------------------------------------------------
        SELECT TOP (1)
            @TrainerId = TrainerId
        FROM tblMemberTrainerAssignment
        WHERE MemberId = @MemberId
          AND IsActive = 1;

        ------------------------------------------------
        -- Change Shift
        ------------------------------------------------
        BEGIN TRANSACTION;

        -- Deactivate Current Shift
        UPDATE tblMemberShift
        SET IsActive = 0
        WHERE MemberId = @MemberId
          AND IsActive = 1;

        -- Assign New Shift
        INSERT INTO tblMemberShift
        (
            MemberId,
            ShiftId,
            IsActive
        )
        VALUES
        (
            @MemberId,
            @NewShiftId,
            1
        );

        -- Deactivate Personal Trainer Assignment
        IF @TrainerId IS NOT NULL
        BEGIN
            UPDATE tblMemberTrainerAssignment
            SET IsActive = 0
            WHERE MemberId = @MemberId
              AND TrainerId = @TrainerId
              AND IsActive = 1;
	    	  ------------------------------------------------
			-- Activate Trainer Current Shift
			------------------------------------------------
				UPDATE tblTrainerShift
				SET IsActive = 1
				WHERE TrainerId = @TrainerId
				  AND ShiftId = @CurrentShiftId
				  AND IsActive = 0;
        END;

        COMMIT TRANSACTION;

        SELECT 'Member shift changed successfully.' AS Message;

    END TRY

    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO