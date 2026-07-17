CREATE PROC spUpdateExpense
(
    @ExpenseId INT,
    @ExpenseCategoryId INT,
    @ExpenseAmount DECIMAL(10,2),
    @ExpenseDate DATE,
    @Notes VARCHAR(MAX)
)
AS
BEGIN
BEGIN TRY

    SET NOCOUNT ON;

    IF @ExpenseId IS NULL
    BEGIN
        SELECT 'Expense Id is Required.' AS Message;
        RETURN;
    END

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblExpense
        WHERE ExpenseId = @ExpenseId
    )
    BEGIN
        SELECT 'Invalid Expense Id.' AS Message;
        RETURN;
    END

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblExpensesCategories
        WHERE ExpenseCategoryID = @ExpenseCategoryId
    )
    BEGIN
        SELECT 'Invalid Expense Category.' AS Message;
        RETURN;
    END

    IF @ExpenseAmount < 0
    BEGIN
        SELECT 'Expense Amount Must Be >= 0.' AS Message;
        RETURN;
    END

    UPDATE tblExpense
    SET
        ExpenseCategoryId = @ExpenseCategoryId,
        ExpenseAmount = @ExpenseAmount,
        ExpenseDate = @ExpenseDate,
        Notes = @Notes
    WHERE ExpenseId = @ExpenseId;

    SELECT 'Expense Updated Successfully.' AS Message;

END TRY
BEGIN CATCH
    SELECT ERROR_MESSAGE() AS Message;
END CATCH
END;
GO