CREATE PROC spRetrieveExpenseStatementByYear
(
    @Year INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

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
        -- Yearly Expense Statement
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
        WHERE YEAR(E.ExpenseDate) = @Year
        ORDER BY
            E.ExpenseDate ASC,
            E.ExpenseId ASC;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO