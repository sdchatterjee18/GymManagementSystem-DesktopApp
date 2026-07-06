CREATE PROC spMarkMemberAttendance
(
    @MemberId INT,
    @ShiftId INT
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
        )
        BEGIN
            SELECT 'Invalid Member.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Member Active Validation
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMember
            WHERE MemberId = @MemberId
              AND IsActive = 1
        )
        BEGIN
            SELECT 'Member Is Not Active.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Shift Validation
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblShift
            WHERE ShiftId = @ShiftId
        )
        BEGIN
            SELECT 'Invalid Shift.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Member Active Shift Validation
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMemberShift
            WHERE MemberId = @MemberId
              AND ShiftId = @ShiftId
              AND IsActive = 1
        )
        BEGIN
            SELECT 'Attendance Allowed Only In Assigned Active Shift.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Duplicate Attendance Check
        ------------------------------------------------
        IF EXISTS
        (
            SELECT 1
            FROM tblMemberAttendance
            WHERE MemberId = @MemberId
              AND ShiftId = @ShiftId
              AND CAST(AttendanceDate AS DATE) = CAST(GETDATE() AS DATE)
        )
        BEGIN
            SELECT 'Attendance Already Marked For Today.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Attendance Insert
        ------------------------------------------------
        INSERT INTO tblMemberAttendance
        (
            MemberId,
            ShiftId
        )
        VALUES
        (
            @MemberId,
            @ShiftId
        );

        SELECT 'Attendance Marked Successfully.' AS Message;

    END TRY

    BEGIN CATCH

        SELECT
            ERROR_MESSAGE() AS Message,
            ERROR_LINE() AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;

    END CATCH

END;
GO