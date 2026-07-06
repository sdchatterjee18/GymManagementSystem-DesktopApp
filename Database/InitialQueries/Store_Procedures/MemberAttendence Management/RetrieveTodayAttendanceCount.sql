CREATE PROC spRetrieveTodayAttendanceCount
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        COUNT(MemberId) AS TodayAttendanceCount
    FROM tblMemberAttendance
    WHERE AttendanceDate >= CAST(GETDATE() AS DATE)
      AND AttendanceDate < DATEADD(DAY, 1, CAST(GETDATE() AS DATE));
END;
GO