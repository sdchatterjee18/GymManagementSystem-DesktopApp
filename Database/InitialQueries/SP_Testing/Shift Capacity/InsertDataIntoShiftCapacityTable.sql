CREATE PROCEDURE spInsertDataIntoShiftCapacityTable
(
    @MaxCapacity INT
)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO tblShiftCapacity (MaxCapacity)
    VALUES (@MaxCapacity);
END;