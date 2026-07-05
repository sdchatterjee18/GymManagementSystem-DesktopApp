CREATE PROC spGetAllExpenses
AS
BEGIN
BEGIN TRY

    SELECT
        E.ExpenseId,
        C.CategoryName,
        C.Category,
        E.ExpenseAmount,
        E.ExpenseDate,
        E.Notes
    FROM tblExpense E
    INNER JOIN tblExpensesCategories C
        ON E.ExpenseCategoryId = C.ExpenseCategoryID
    ORDER BY E.ExpenseDate DESC;

END TRY
BEGIN CATCH
    SELECT ERROR_MESSAGE() AS Message;
END CATCH
END;
GO