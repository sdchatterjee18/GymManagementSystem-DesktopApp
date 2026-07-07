CREATE PROC spRetrieveExpenseStatementByDateRange
(
    @FromDate DATE,
    @ToDate DATE
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        -------------------------------------------------
        -- From Date Validation
        -------------------------------------------------
        IF @FromDate IS NULL
        BEGIN
            SELECT 'From Date is required.' AS Message;
            RETURN;
        END;

        -------------------------------------------------
        -- To Date Validation
        -------------------------------------------------
        IF @ToDate IS NULL
        BEGIN
            SELECT 'To Date is required.' AS Message;
            RETURN;
        END;

        -------------------------------------------------
        -- Future Date Validation
        -------------------------------------------------
        IF @FromDate > CAST(GETDATE() AS DATE)
        BEGIN
            SELECT 'From Date cannot be greater than today.' AS Message;
            RETURN;
        END;

        IF @ToDate > CAST(GETDATE() AS DATE)
        BEGIN
            SELECT 'To Date cannot be greater than today.' AS Message;
            RETURN;
        END;

        -------------------------------------------------
        -- Date Range Validation
        -------------------------------------------------
        IF @FromDate > @ToDate
        BEGIN
            SELECT 'From Date cannot be greater than To Date.' AS Message;
            RETURN;
        END;

        -------------------------------------------------
        -- Expense Statement
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
        WHERE E.ExpenseDate BETWEEN @FromDate AND @ToDate
        ORDER BY E.ExpenseDate ASC,
                 E.ExpenseId ASC;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO