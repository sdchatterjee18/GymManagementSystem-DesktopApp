CREATE OR ALTER PROC spRetrieveTodayAttendanceCount
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT
            COUNT(MemberId) AS TodayAttendanceCount
        FROM tblMemberAttendance
        WHERE AttendanceDate >= CAST(GETDATE() AS DATE)
          AND AttendanceDate < DATEADD(DAY, 1, CAST(GETDATE() AS DATE));

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH

END;
GO