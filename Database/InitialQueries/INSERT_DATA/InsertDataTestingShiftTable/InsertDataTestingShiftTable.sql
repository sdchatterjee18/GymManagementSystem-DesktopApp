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