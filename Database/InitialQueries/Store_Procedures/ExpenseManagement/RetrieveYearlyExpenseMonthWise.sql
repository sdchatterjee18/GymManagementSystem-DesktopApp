CREATE PROC spRetrieveYearlyExpenseMonthWise
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
           OR @Year > YEAR(GETDATE())
        BEGIN
            SELECT
                0 AS Success,
                'Invalid Year.' AS Message;
            RETURN;
        END;

        -------------------------------------------------
        -- Retrieve Month Wise Expense
        -------------------------------------------------
        SELECT
            1 AS Success,
            MONTH(ExpenseDate) AS MonthNo,
            DATENAME(MONTH, ExpenseDate) AS MonthName,
            SUM(ExpenseAmount) AS TotalExpense
        FROM tblExpense
        WHERE YEAR(ExpenseDate) = @Year
        GROUP BY
            MONTH(ExpenseDate),
            DATENAME(MONTH, ExpenseDate)
        ORDER BY
            MonthNo;

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