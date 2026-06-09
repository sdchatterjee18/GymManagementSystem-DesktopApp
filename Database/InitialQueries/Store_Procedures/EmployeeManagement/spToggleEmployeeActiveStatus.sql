CREATE PROC spToggleEmployeeActiveStatus 
(
    @EmployeeId INT
)
AS
BEGIN

    UPDATE tblEmployee
    SET IsActive =
        CASE
            WHEN IsActive = 1 THEN 0
            ELSE 1
        END
    WHERE EmployeeId = @EmployeeId;

    SELECT 'Employee Status Updated Successfully.' AS Message;
END