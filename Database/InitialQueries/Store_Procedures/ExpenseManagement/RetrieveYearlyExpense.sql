CREATE PROC spRetrieveYearlyExpense
(
    @Year INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        -------------------------------------------------
        -- Year Required
        -------------------------------------------------
        IF @Year IS NULL
        BEGIN
            SELECT
                0 AS Success,
                'Year is Required.' AS Message;
            RETURN;
        END;

        -------------------------------------------------
        -- Get First Expense Year
        -------------------------------------------------
        DECLARE @StartYear INT;

        SELECT @StartYear = YEAR(MIN(ExpenseDate))
        FROM tblExpense;

        -------------------------------------------------
        -- If No Expense Exists
        -------------------------------------------------
        IF @StartYear IS NULL
        BEGIN
            SELECT
                0 AS Success,
                'No Expense Records Found.' AS Message;
            RETURN;
        END;

        -------------------------------------------------
        -- Year Validation
        -------------------------------------------------
        IF @Year < @StartYear
           OR @Year > YEAR(GETDATE())
        BEGIN
            SELECT
                0 AS Success,
                CONCAT('Please Enter a Year Between ', @StartYear, ' and ', YEAR(GETDATE()), '.') AS Message;
            RETURN;
        END;

        -------------------------------------------------
        -- Total Yearly Expense
        -------------------------------------------------
        SELECT
            1 AS Success,
            @Year AS [Year],
            ISNULL(SUM(ExpenseAmount), 0) AS TotalYearlyExpense
        FROM tblExpense
        WHERE YEAR(ExpenseDate) = @Year;

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