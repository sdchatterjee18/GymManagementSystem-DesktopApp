CREATE PROC spInsertDataIntoExpensesCategoriesTable
(
    @CategoryName VARCHAR(100),
    @Category VARCHAR(100)
)
AS
BEGIN
BEGIN TRY
    SET @CategoryName = LTRIM(RTRIM(@CategoryName))
    SET @Category = LTRIM(RTRIM(@Category))
    IF @CategoryName IS NULL OR @CategoryName = ''
    BEGIN
        SELECT 'Category Name is Required.' AS Message
        RETURN
    END
    IF @Category IS NULL OR @Category = ''
    BEGIN
        SELECT 'Category is Required.' AS Message
        RETURN
    END
    IF EXISTS
    (
        SELECT 1
        FROM tblExpensesCategories
        WHERE CategoryName = @CategoryName
    )
    BEGIN
        SELECT 'Category Name Already Exists.' AS Message
        RETURN
    END
    INSERT INTO tblExpensesCategories
    (
        CategoryName,
        Category
    )
    VALUES
    (
        @CategoryName,
        @Category
    )
    SELECT 'Expense Category Inserted Successfully.' AS Message
END TRY
BEGIN CATCH
    SELECT
        ERROR_MESSAGE() AS Message,
        ERROR_LINE() AS ErrorLine,
        ERROR_PROCEDURE() AS ProcedureName
END CATCH
END
GO