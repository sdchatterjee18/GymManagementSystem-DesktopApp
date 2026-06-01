EXEC spInsertDataIntoEmployeeTable
@FirstName='Rahul',
@MiddleName='Kumar',
@LastName='Sharma',
@GenderId=1,
@PhoneNo='9876543210',
@EmailId='rahul@gmail.com',
@RoleName='Trainer',
@BankAccountNo='123456789001'

EXEC spInsertDataIntoEmployeeTable
@FirstName='Sourav',
@MiddleName='',
@LastName='Ghosh',
@GenderId=1,
@PhoneNo='9876543213',
@EmailId='sourav@gmail.com',
@RoleName='Accountant',
@BankAccountNo='123456789004'

EXEC spInsertDataIntoEmployeeTable
@FirstName='Neha',
@MiddleName='',
@LastName='Paul',
@GenderId=2,
@PhoneNo='9876543216',
@EmailId='neha@gmail.com',
@RoleName='Manager',
@BankAccountNo='123456789007'

SELECT *FROM tblEmployee