CREATE PROC spRetrieveMonthlyTotalExpense
(
    @Month INT,
    @Year INT
)
AS
BEGIN
    SET NOCOUNT ON;

    -------------------------------------------------
    -- Month Validation
    -------------------------------------------------
    IF @Month IS NULL
       OR @Month NOT BETWEEN 1 AND 12
    BEGIN
        SELECT 'Invalid Month.' AS Message;
        RETURN;
    END;

    -------------------------------------------------
    -- Year Validation
    -------------------------------------------------
    IF @Year IS NULL
       OR @Year < 2000
       OR @Year > YEAR(GETDATE())
    BEGIN
        SELECT 'Invalid Year.' AS Message;
        RETURN;
    END;

    -------------------------------------------------
    -- Total Monthly Expense
    -------------------------------------------------
    SELECT
        ISNULL(SUM(ExpenseAmount), 0) AS TotalMonthlyExpense
    FROM tblExpense
    WHERE ExpenseDate >= DATEFROMPARTS(@Year, @Month, 1)
      AND ExpenseDate < DATEADD(MONTH, 1, DATEFROMPARTS(@Year, @Month, 1));
END;
GO