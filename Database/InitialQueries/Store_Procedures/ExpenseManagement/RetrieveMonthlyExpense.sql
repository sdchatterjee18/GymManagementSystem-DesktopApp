CREATE PROC spRetrieveMonthlyExpenses
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
            SELECT
                0 AS Success,
                'Invalid Month.' AS Message;
            RETURN;
        END;

        -------------------------------------------------
        -- Year Validation
        -------------------------------------------------
        IF @Year IS NULL
           OR @Year > YEAR(GETDATE())
        BEGIN
            SELECT
                0 AS Success,
                'Invalid Year.' AS Message;
            RETURN;
        END;

        -------------------------------------------------
        -- Monthly Expense Details
        -------------------------------------------------
        SELECT
            1 AS Success,
            E.ExpenseId,
            C.CategoryName,
            C.Category,
            E.ExpenseAmount,
            E.ExpenseDate,
            E.Notes
        FROM tblExpense E
        INNER JOIN tblExpensesCategories C
            ON E.ExpenseCategoryId = C.ExpenseCategoryID
        WHERE MONTH(E.ExpenseDate) = @Month
          AND YEAR(E.ExpenseDate) = @Year
        ORDER BY E.ExpenseDate DESC, E.ExpenseId DESC;

    END TRY

    BEGIN CATCH

        SELECT
            0 AS Success,
            ERROR_MESSAGE() AS Message,
            ERROR_LINE() AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;

    END CATCH
END;
GO