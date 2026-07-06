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

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH

END;
GO