EXEC spInsertDataIntoExpensesCategoriesTable
@CategoryName='Electricity Bill',
@Category='Utility'

EXEC spInsertDataIntoExpensesCategoriesTable
@CategoryName='Equipment Purchase',
@Category='Equipment'

EXEC spInsertDataIntoExpensesCategoriesTable
@CategoryName='Cleaning Materials',
@Category='Maintenance'

SELECT *FROM tblExpensesCategories