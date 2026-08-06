CREATE PROC spRetrieveShiftWiseTotalAttendance
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT
            S.ShiftName,
            ISNULL(COUNT(MA.AttendanceId), 0) AS TotalAttendance
        FROM tblShift S
        LEFT JOIN tblMemberAttendance MA
            ON S.ShiftId = MA.ShiftId
           AND CAST(MA.AttendanceDate AS DATE) = CAST(GETDATE() AS DATE)
        GROUP BY
            S.ShiftName,
            S.StartTime
        ORDER BY
            S.StartTime;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END
GO