CREATE PROCEDURE spAddExpenseCategory
(
    @CategoryName VARCHAR(100),
    @Category VARCHAR(100)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @CategoryName = LTRIM(RTRIM(@CategoryName));
        SET @Category = LTRIM(RTRIM(@Category));

        IF @CategoryName = ''
        BEGIN
            SELECT 'Category name is required.' AS Message;
            RETURN;
        END

        IF @Category = ''
        BEGIN
            SELECT 'Category is required.' AS Message;
            RETURN;
        END

        IF EXISTS
        (
            SELECT 1
            FROM tblExpensesCategories
            WHERE CategoryName = @CategoryName
        )
        BEGIN
            SELECT 'Category name already exists.' AS Message;
            RETURN;
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
        );

        SELECT 'Expense category added successfully.' AS Message;

    END TRY
    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO