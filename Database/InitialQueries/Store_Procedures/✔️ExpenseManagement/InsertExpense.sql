CREATE PROC spInsertExpense
(
    @ExpenseCategoryId INT,
    @ExpenseAmount DECIMAL(10,2),
    @ExpenseDate DATE,
    @Notes VARCHAR(MAX)
)
AS
BEGIN
BEGIN TRY

    SET NOCOUNT ON;

    SET @Notes = LTRIM(RTRIM(@Notes));

    IF @ExpenseCategoryId IS NULL
    BEGIN
        SELECT 'Expense Category is Required.' AS Message;
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

    IF @ExpenseAmount IS NULL OR @ExpenseAmount < 0
    BEGIN
        SELECT 'Expense Amount Must Be >= 0.' AS Message;
        RETURN;
    END

    IF @ExpenseDate IS NULL
    BEGIN
        SELECT 'Expense Date is Required.' AS Message;
        RETURN;
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
    );

    SELECT 'Expense Inserted Successfully.' AS Message;

END TRY
BEGIN CATCH
    SELECT ERROR_MESSAGE() AS Message;
END CATCH
END;
GO