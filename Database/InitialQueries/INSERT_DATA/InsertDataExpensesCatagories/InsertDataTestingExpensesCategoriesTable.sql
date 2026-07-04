EXEC spInsertDataIntoExpensesCategoriesTable
@CategoryName='Electricity Bill',
@Category='Utility'

EXEC spInsertDataIntoExpensesCategoriesTable
@CategoryName='Equipment Purchase',
@Category='Equipment'

EXEC spInsertDataIntoExpensesCategoriesTable
@CategoryName='Cleaning Materials',
@Category='Maintenance'

EXEC spInsertDataIntoExpensesCategoriesTable
@CategoryName='Water Bill',
@Category='Utility';

EXEC spInsertDataIntoExpensesCategoriesTable
@CategoryName='Internet Bill',
@Category='Utility';

EXEC spInsertDataIntoExpensesCategoriesTable
@CategoryName='Gym Equipment Repair',
@Category='Maintenance';

EXEC spInsertDataIntoExpensesCategoriesTable
@CategoryName='Air Conditioner Service',
@Category='Maintenance';

EXEC spInsertDataIntoExpensesCategoriesTable
@CategoryName='Trainer Salary',
@Category='Salary';

EXEC spInsertDataIntoExpensesCategoriesTable
@CategoryName='Staff Salary',
@Category='Salary';

EXEC spInsertDataIntoExpensesCategoriesTable
@CategoryName='Office Supplies',
@Category='Office Expense';

EXEC spInsertDataIntoExpensesCategoriesTable
@CategoryName='Marketing Campaign',
@Category='Marketing';

EXEC spInsertDataIntoExpensesCategoriesTable
@CategoryName='Software Subscription',
@Category='Software';

EXEC spInsertDataIntoExpensesCategoriesTable
@CategoryName='Security Service',
@Category='Security';

SELECT *FROM tblExpensesCategories