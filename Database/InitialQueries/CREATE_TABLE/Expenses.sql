CREATE TABLE tblExpense
(
    ExpenseId INT  PRIMARY KEY IDENTITY(1,1) not null,
    ExpenseCategoryId INT NOT NULL,
    ExpenseAmount DECIMAL(10,2) NOT NULL
        CHECK (ExpenseAmount >= 0),
    ExpenseDate DATE NOT NULL,
    Notes VARCHAR(MAX) NULL,
    CONSTRAINT FK_tblExpense_ExpenseCategoryIdtblExpenseCategory
        FOREIGN KEY (ExpenseCategoryId)
        REFERENCES tblExpensesCategories(ExpenseCategoryId)
);

