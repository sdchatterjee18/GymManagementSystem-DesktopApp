CREATE PROC spRetrieveTotalExpenseByDateRange
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
        -- Total Expense
        -------------------------------------------------
        SELECT
            ISNULL(SUM(ExpenseAmount), 0) AS TotalExpense
        FROM tblExpense
        WHERE ExpenseDate BETWEEN @FromDate AND @ToDate;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO