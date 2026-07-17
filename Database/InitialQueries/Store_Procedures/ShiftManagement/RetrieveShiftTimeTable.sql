CREATE PROC spRetrieveShiftTimeTable
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT
            ShiftId,
            ShiftName,
            FORMAT(CAST(StartTime AS datetime), 'hh:mm tt') AS StartTime,  
            FORMAT(CAST(EndTime AS datetime), 'hh:mm tt') AS EndTime
        FROM tblShift
        ORDER BY StartTime;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH

END;
GO