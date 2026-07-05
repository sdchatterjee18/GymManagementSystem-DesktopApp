CREATE PROC spInsertDataIntoShiftTable
(
    @ShiftName VARCHAR(100),
    @StartTime TIME,
    @EndTime TIME
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @ShiftName = LTRIM(RTRIM(ISNULL(@ShiftName,'')));

        ------------------------------------------------
        -- Shift Name Validation
        ------------------------------------------------
        IF @ShiftName = ''
        BEGIN
            SELECT 'Shift Name is Required.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Time Validation
        ------------------------------------------------
        IF @StartTime IS NULL
        BEGIN
            SELECT 'Start Time is Required.' AS Message;
            RETURN;
        END;

        IF @EndTime IS NULL
        BEGIN
            SELECT 'End Time is Required.' AS Message;
            RETURN;
        END;

        IF @StartTime >= @EndTime
        BEGIN
            SELECT 'End Time must be greater than Start Time.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Duplicate Shift Name
        ------------------------------------------------
        IF EXISTS
        (
            SELECT 1
            FROM tblShift
            WHERE LTRIM(RTRIM(ShiftName)) = @ShiftName
        )
        BEGIN
            SELECT 'Shift Name Already Exists.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Exact Same Timing
        ------------------------------------------------
        IF EXISTS
        (
            SELECT 1
            FROM tblShift
            WHERE StartTime = @StartTime
              AND EndTime = @EndTime
        )
        BEGIN
            SELECT 'A Shift With The Same Timing Already Exists.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Overlapping Shift Check
        ------------------------------------------------
        IF EXISTS
        (
            SELECT 1
            FROM tblShift
            WHERE @StartTime < EndTime
              AND @EndTime > StartTime
        )
        BEGIN
            SELECT 'Shift Timing Overlaps With An Existing Shift.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Insert Shift
        ------------------------------------------------
        INSERT INTO tblShift
        (
            ShiftName,
            StartTime,
            EndTime
        )
        VALUES
        (
            @ShiftName,
            @StartTime,
            @EndTime
        );

        SELECT 'Shift Inserted Successfully.' AS Message;

    END TRY

    BEGIN CATCH

        SELECT
            ERROR_MESSAGE() AS Message,
            ERROR_LINE() AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;

    END CATCH
END
GO