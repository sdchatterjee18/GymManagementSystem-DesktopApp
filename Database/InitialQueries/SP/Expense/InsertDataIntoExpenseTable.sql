CREATE PROC spInsertDataIntoExpenseTable
(
    @ExpenseCategoryId INT,
    @ExpenseAmount DECIMAL(10,2),
    @ExpenseDate DATE,
    @Notes VARCHAR(MAX) = NULL
)
AS
BEGIN
BEGIN TRY

    IF @Notes IS NOT NULL
        SET @Notes = LTRIM(RTRIM(@Notes))
    IF @Notes = ''
        SET @Notes = NULL
    IF @ExpenseCategoryId IS NULL
    BEGIN
        SELECT 'Expense Category Id is Required.' AS Message
        RETURN
    END
    IF @ExpenseAmount IS NULL
    BEGIN
        SELECT 'Expense Amount is Required.' AS Message
        RETURN
    END
    IF @ExpenseDate IS NULL
    BEGIN
        SELECT 'Expense Date is Required.' AS Message
        RETURN
    END
    IF @ExpenseAmount <= 0
    BEGIN
        SELECT 'Expense Amount Must Be Greater Than Zero.' AS Message
        RETURN
    END
    IF NOT EXISTS
    (
        SELECT 1
        FROM tblExpensesCategories
        WHERE ExpenseCategoryId = @ExpenseCategoryId
    )
    BEGIN
        SELECT 'Invalid Expense Category Id.' AS Message
        RETURN
    END
    IF @ExpenseDate > CAST(GETDATE() AS DATE)
    BEGIN
        SELECT 'Expense Date Cannot Be In The Future.' AS Message
        RETURN
    END
    INSERT INTO tblExpense
    (
        ExpenseCategoryId,
        ExpenseAmount,
        ExpenseDate,
        Notes
    )
    VALUES
    (
        @ExpenseCategoryId,
        @ExpenseAmount,
        @ExpenseDate,
        @Notes
    )
    SELECT 'Expense Added Successfully.' AS Message
END TRY
BEGIN CATCH

    SELECT
        ERROR_MESSAGE() AS Message,
        ERROR_LINE() AS ErrorLine,
        ERROR_PROCEDURE() AS ProcedureName

END CATCH
END
GO