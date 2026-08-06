CREATE PROC spRetrieveTotalExpenseByYear
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
        -- Total Yearly Expense
        -------------------------------------------------
        SELECT
            ISNULL(SUM(ExpenseAmount), 0) AS TotalExpense
        FROM tblExpense
        WHERE YEAR(ExpenseDate) = @Year;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO