CREATE PROC spRetrieveExpenseStatementByMonth
(
    @Month INT,
    @Year INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

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
        -- Monthly Expense Statement
        -------------------------------------------------
        SELECT
            E.ExpenseId,
            EC.CategoryName,
            EC.Category,
            E.ExpenseAmount,
            E.ExpenseDate,
            E.Notes
        FROM tblExpense E
        INNER JOIN tblExpensesCategories EC
            ON E.ExpenseCategoryId = EC.ExpenseCategoryId
        WHERE E.ExpenseDate >= DATEFROMPARTS(@Year, @Month, 1)
          AND E.ExpenseDate < DATEADD(MONTH, 1, DATEFROMPARTS(@Year, @Month, 1))
        ORDER BY
            E.ExpenseDate ASC,
            E.ExpenseId ASC;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO