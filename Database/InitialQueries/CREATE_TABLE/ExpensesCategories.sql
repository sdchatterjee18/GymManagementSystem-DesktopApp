CREATE TABLE tblExpensesCategories
(
    ExpenseCategoryID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    CategoryName VARCHAR(100) UNIQUE NOT NULL,
    Category VARCHAR(100) NOT NULL
);