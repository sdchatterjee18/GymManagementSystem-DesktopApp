CREATE PROC spChangeMemberShift
(
    @MemberId INT,
    @NewShiftId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CurrentShiftId INT,
            @TrainerId INT,
            @MaxCapacity INT,
            @CurrentMemberCount INT;

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
    END

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
    END

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
            'Invalid shift.' AS Message;
        RETURN;
    END

    ------------------------------------------------
    -- Current Shift
    ------------------------------------------------
    SELECT
        @CurrentShiftId = ShiftId
    FROM tblMemberShift
    WHERE MemberId = @MemberId;

    IF @CurrentShiftId IS NULL
    BEGIN
        SELECT
            0 AS Success,
            'Current shift not found.' AS Message;
        RETURN;
    END

    IF @CurrentShiftId = @NewShiftId
    BEGIN
        SELECT
            0 AS Success,
            'Member is already assigned to this shift.' AS Message;
        RETURN;
    END

    ------------------------------------------------
    -- Get Common Shift Capacity
    ------------------------------------------------
    SELECT TOP 1
        @MaxCapacity = MaxCapacity
    FROM tblShiftCapacity;

    IF @MaxCapacity IS NULL
    BEGIN
        SELECT
            0 AS Success,
            'Shift capacity is not configured.' AS Message;
        RETURN;
    END

    ------------------------------------------------
    -- Count Members in New Shift
    ------------------------------------------------
    SELECT
        @CurrentMemberCount = COUNT(*)
    FROM tblMemberShift
    WHERE ShiftId = @NewShiftId;

    IF @CurrentMemberCount >= @MaxCapacity
    BEGIN
        SELECT
            0 AS Success,
            'Selected shift is already full.' AS Message;
        RETURN;
    END

    ------------------------------------------------
    -- Check Personal Trainer
    ------------------------------------------------
    SELECT TOP 1
        @TrainerId = TrainerId
    FROM tblMemberTrainerAssignment
    WHERE MemberId = @MemberId
      AND IsActive = 1;

    ------------------------------------------------
    -- Trainer Availability
    ------------------------------------------------
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
                'Assigned personal trainer is not available in the selected shift.' AS Message;
            RETURN;
        END
    END

    ------------------------------------------------
    -- Update Shift
    ------------------------------------------------
    BEGIN TRY

        UPDATE tblMemberShift
        SET ShiftId = @NewShiftId
        WHERE MemberId = @MemberId;

        SELECT
            1 AS Success,
            'Shift changed successfully.' AS Message,
            @MemberId AS MemberId,
            @CurrentShiftId AS OldShiftId,
            @NewShiftId AS NewShiftId;

    END TRY

    BEGIN CATCH

        SELECT
            0 AS Success,
            ERROR_MESSAGE() AS Message,
            ERROR_LINE() AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;

    END CATCH

END
GO