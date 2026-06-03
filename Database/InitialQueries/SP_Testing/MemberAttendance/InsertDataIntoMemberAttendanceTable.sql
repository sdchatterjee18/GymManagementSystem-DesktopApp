CREATE PROC spInsertDataIntoMemberAttendanceTable
(
    @MemberId INT,
    @ShiftId INT
)
AS
BEGIN
BEGIN TRY


    IF @MemberId IS NULL
    BEGIN
        SELECT 'Member Id is Required.' AS Message
        RETURN
    END

    IF @ShiftId IS NULL
    BEGIN
        SELECT 'Shift Id is Required.' AS Message
        RETURN
    END

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMember
        WHERE MemberId = @MemberId
    )
    BEGIN
        SELECT 'Invalid Member Id.' AS Message
        RETURN
    END


    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMember
        WHERE MemberId = @MemberId
          AND IsActive = 1
    )
    BEGIN
        SELECT 'Member Is Not Active.' AS Message
        RETURN
    END

  

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblShift
        WHERE ShiftId = @ShiftId
    )
    BEGIN
        SELECT 'Invalid Shift Id.' AS Message
        RETURN
    END



    IF EXISTS
    (
        SELECT 1
        FROM tblMemberAttendance
        WHERE MemberId = @MemberId
          AND ShiftId = @ShiftId
          AND CAST(AttendanceDate AS DATE) = CAST(GETDATE() AS DATE)
    )
    BEGIN
        SELECT 'Attendance Already Marked For Today.' AS Message
        RETURN
    END


    INSERT INTO tblMemberAttendance
    (
        MemberId,
        ShiftId
    )
    VALUES
    (
        @MemberId,
        @ShiftId
    )

    SELECT 'Attendance Marked Successfully.' AS Message

END TRY

BEGIN CATCH

    SELECT
        ERROR_MESSAGE() AS Message,
        ERROR_LINE() AS ErrorLine,
        ERROR_PROCEDURE() AS ProcedureName

END CATCH
END
GO