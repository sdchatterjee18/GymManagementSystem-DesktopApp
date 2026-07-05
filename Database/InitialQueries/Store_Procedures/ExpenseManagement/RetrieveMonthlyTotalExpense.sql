CREATE OR ALTER PROC spRetrieveMonthlyTotalExpense
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
        -- Total Monthly Expense
        -------------------------------------------------
        SELECT
            1 AS Success,
            @Month AS [Month],
            @Year AS [Year],
            ISNULL(SUM(ExpenseAmount), 0) AS TotalMonthlyExpense
        FROM tblExpense
        WHERE MONTH(ExpenseDate) = @Month
          AND YEAR(ExpenseDate) = @Year;

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