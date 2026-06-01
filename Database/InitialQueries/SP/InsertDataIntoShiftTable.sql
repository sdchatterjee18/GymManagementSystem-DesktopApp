
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

        SET @ShiftName = LTRIM(RTRIM(ISNULL(@ShiftName, '')));

        IF @ShiftName = ''
        BEGIN
            SELECT 'Shift Name is Required.' AS Message;
            RETURN;
        END;

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

        IF @EndTime <= @StartTime
        BEGIN
            SELECT 'End Time must be greater than Start Time.' AS Message;
            RETURN;
        END;

        IF EXISTS
        (
            SELECT 1
            FROM tblShift
            WHERE ShiftName = @ShiftName
        )
        BEGIN
            SELECT 'Shift Already Exists.' AS Message;
            RETURN;
        END;

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

select * from tblShift

CREATE TABLE tblShift(
ShiftId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
ShiftName VARCHAR(100) UNIQUE NOT NULL,
StartTime TIME NOT NULL,
EndTime TIME NOT NULL
)


EXEC spInsertDataIntoShiftTable
    @ShiftName = 'Morning Shift',
    @StartTime = '06:00:00',
    @EndTime = '10:00:00';
GO

EXEC spInsertDataIntoShiftTable
    @ShiftName = 'Afternoon Shift',
    @StartTime = '13:00:00',
    @EndTime = '17:00:00';
GO

EXEC spInsertDataIntoShiftTable
    @ShiftName = 'Evening Shift',
    @StartTime = '18:00:00',
    @EndTime = '23:00:00';
GO