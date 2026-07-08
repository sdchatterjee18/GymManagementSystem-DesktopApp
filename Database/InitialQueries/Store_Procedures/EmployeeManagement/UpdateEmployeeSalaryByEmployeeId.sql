CREATE PROCEDURE spUpdateEmployeeSalaryByEmployeeId
(
    @EmployeeId INT,
    @Amount DECIMAL(10,2)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblEmployee
            WHERE EmployeeId = @EmployeeId
        )
        BEGIN
            SELECT 'Employee not found.' AS Message;
            RETURN;
        END

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblSalary
            WHERE EmployeeId = @EmployeeId
        )
        BEGIN
            SELECT 'Salary record not found.' AS Message;
            RETURN;
        END

        IF @Amount < 0
        BEGIN
            SELECT 'Salary amount cannot be negative.' AS Message;
            RETURN;
        END

        UPDATE tblSalary
        SET Amount = @Amount
        WHERE EmployeeId = @EmployeeId;

        SELECT 'Salary updated successfully.' AS Message;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO