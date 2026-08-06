CREATE PROCEDURE spRemoveExpenseCategory
(
    @ExpenseCategoryID INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblExpensesCategories
            WHERE ExpenseCategoryID = @ExpenseCategoryID
        )
        BEGIN
            SELECT 'Expense category not found.' AS Message;
            RETURN;
        END

        DELETE FROM tblExpensesCategories
        WHERE ExpenseCategoryID = @ExpenseCategoryID;

        SELECT 'Expense category removed successfully.' AS Message;

    END TRY
    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO