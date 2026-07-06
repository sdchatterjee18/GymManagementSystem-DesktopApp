CREATE OR ALTER PROC spRetrieveYearlyTotalExpense
(
    @Year INT
)
AS
BEGIN
    SET NOCOUNT ON;

    IF @Year IS NULL
    BEGIN
        SELECT 'Year is Required.' AS Message;
        RETURN;
    END;

    SELECT
        ISNULL(SUM(ExpenseAmount), 0) AS TotalYearlyExpense
    FROM tblExpense
    WHERE YEAR(ExpenseDate) = @Year;
END;
GO