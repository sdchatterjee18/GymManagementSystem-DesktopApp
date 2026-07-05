CREATE PROC spChangeMemberShift
(
    @MemberId INT,
    @NewShiftId INT
)
AS
BEGIN
    SET NOCOUNT ON;

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
            SELECT
                0 AS Success,
                'Member does not exist or is inactive.' AS Message;
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
            SELECT
                0 AS Success,
                'Member has no active membership.' AS Message;
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
            SELECT
                0 AS Success,
                'Invalid Shift.' AS Message;
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
            SELECT
                0 AS Success,
                'Current Active Shift Not Found.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Same Shift Validation
        ------------------------------------------------
        IF @CurrentShiftId = @NewShiftId
        BEGIN
            SELECT
                0 AS Success,
                'Member Is Already Assigned To This Shift.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Shift Capacity
        ------------------------------------------------
        SELECT TOP 1
            @MaxCapacity = MaxCapacity
        FROM tblShiftCapacity;

        IF @MaxCapacity IS NULL
        BEGIN
            SELECT
                0 AS Success,
                'Shift Capacity Is Not Configured.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Count Active Members In New Shift
        ------------------------------------------------
        SELECT
            @CurrentMemberCount = COUNT(*)
        FROM tblMemberShift
        WHERE ShiftId = @NewShiftId
          AND IsActive = 1;

        IF @CurrentMemberCount >= @MaxCapacity
        BEGIN
            SELECT
                0 AS Success,
                'Selected Shift Is Already Full.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Personal Trainer Validation
        ------------------------------------------------
        SELECT TOP 1
            @TrainerId = TrainerId
        FROM tblMemberTrainerAssignment
        WHERE MemberId = @MemberId
          AND IsActive = 1;

        IF @TrainerId IS NOT NULL
        BEGIN
            IF NOT EXISTS
            (
                SELECT 1
                FROM tblTrainerShift
                WHERE TrainerId = @TrainerId
                  AND ShiftId = @NewShiftId
                  AND IsActive = 1
            )
            BEGIN
                SELECT
                    0 AS Success,
                    'Assigned Personal Trainer Is Not Available In The Selected Shift.' AS Message;
                RETURN;
            END;
        END;

        ------------------------------------------------
        -- Start Transaction
        ------------------------------------------------
        BEGIN TRANSACTION;

        ------------------------------------------------
        -- Deactivate Current Shift
        ------------------------------------------------
        UPDATE tblMemberShift
        SET IsActive = 0
        WHERE MemberId = @MemberId
          AND IsActive = 1;

        ------------------------------------------------
        -- Insert New Active Shift
        ------------------------------------------------
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

        ------------------------------------------------
        -- Commit
        ------------------------------------------------
        COMMIT TRANSACTION;

        SELECT
            1 AS Success,
            'Member Shift Changed Successfully.' AS Message,
            @MemberId AS MemberId,
            @CurrentShiftId AS OldShiftId,
            @NewShiftId AS NewShiftId;

    END TRY

    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT
            0 AS Success,
            ERROR_MESSAGE() AS Message,
            ERROR_LINE() AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;

    END CATCH

END;
GO