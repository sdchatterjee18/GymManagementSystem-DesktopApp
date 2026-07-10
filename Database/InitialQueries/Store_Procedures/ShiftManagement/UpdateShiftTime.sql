CREATE PROC spUpdateShiftTime
(
    @ShiftId INT,
    @StartTime TIME,
    @EndTime TIME
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        ------------------------------------------------
        -- Shift Exists
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblShift
            WHERE ShiftId = @ShiftId
        )
        BEGIN
            SELECT 'Shift does not exist.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Time Validation
        ------------------------------------------------
        IF @StartTime >= @EndTime
        BEGIN
            SELECT 'End Time must be greater than Start Time.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Update Shift Time
        ------------------------------------------------
        UPDATE tblShift
        SET
            StartTime = @StartTime,
            EndTime = @EndTime
        WHERE ShiftId = @ShiftId;

        SELECT 'Shift time updated successfully.' AS Message;

    END TRY
    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO