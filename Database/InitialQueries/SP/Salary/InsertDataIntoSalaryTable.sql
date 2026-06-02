CREATE PROC spInsertDataIntoSalaryTable
(
    @EmployeeId INT,
    @Amount DECIMAL(10,2)
)
AS
BEGIN
BEGIN TRY

    IF @EmployeeId IS NULL
    BEGIN
        SELECT 'Employee Id is Required.' AS Message
        RETURN
    END
    IF @Amount IS NULL
    BEGIN
        SELECT 'Salary Amount is Required.' AS Message
        RETURN
    END
    IF @Amount <= 0
    BEGIN
        SELECT 'Salary Amount Must Be Greater Than Zero.' AS Message
        RETURN
    END
    IF NOT EXISTS
    (
        SELECT 1
        FROM tblEmployee
        WHERE EmployeeId = @EmployeeId
    )
    BEGIN
        SELECT 'Invalid Employee Id.' AS Message
        RETURN
    END
    IF EXISTS
(
    SELECT 1
    FROM tblSalary
    WHERE EmployeeId = @EmployeeId
)
BEGIN
    SELECT 'Salary Record Already Exists For This Employee.' AS Message
    RETURN
END
    INSERT INTO tblSalary
    (
        EmployeeId,
        Amount
    )
    VALUES
    (
        @EmployeeId,
        @Amount
    )
    SELECT 'Salary Inserted Successfully.' AS Message
END TRY
BEGIN CATCH
    SELECT
        ERROR_MESSAGE() AS Message,
        ERROR_LINE() AS ErrorLine,
        ERROR_PROCEDURE() AS ProcedureName
END CATCH
END
GO