CREATE PROC spRetrieveShiftTimeTable
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT
            ShiftId,
            ShiftName,
            StartTime,
            EndTime
        FROM tblShift
        ORDER BY StartTime;

    END TRY

    BEGIN CATCH

        SELECT
            ERROR_MESSAGE() AS Message,
            ERROR_LINE() AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;

    END CATCH
END
GO