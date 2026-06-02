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

EXEC spInsertDataIntoEmployeeTable
@FirstName='Amit',
@MiddleName='',
@LastName='Das',
@GenderId=1,
@PhoneNo='9876543220',
@EmailId='amit@gmail.com',
@RoleName='Trainer',
@BankAccountNo='123456789010';

EXEC spInsertDataIntoEmployeeTable
@FirstName='Priya',
@MiddleName='',
@LastName='Sen',
@GenderId=2,
@PhoneNo='9876543221',
@EmailId='priya@gmail.com',
@RoleName='Receptionist',
@BankAccountNo='123456789011';

EXEC spInsertDataIntoEmployeeTable
@FirstName='Rohit',
@MiddleName='Kumar',
@LastName='Roy',
@GenderId=1,
@PhoneNo='9876543222',
@EmailId='rohit@gmail.com',
@RoleName='Manager',
@BankAccountNo='123456789012';

EXEC spInsertDataIntoEmployeeTable
@FirstName='Ananya',
@MiddleName='',
@LastName='Dutta',
@GenderId=2,
@PhoneNo='9876543223',
@EmailId='ananya@gmail.com',
@RoleName='Trainer',
@BankAccountNo='123456789013';

EXEC spInsertDataIntoEmployeeTable
@FirstName='Vikash',
@MiddleName='',
@LastName='Yadav',
@GenderId=1,
@PhoneNo='9876543224',
@EmailId='vikash@gmail.com',
@RoleName='Accountant',
@BankAccountNo='123456789014';

EXEC spInsertDataIntoEmployeeTable
@FirstName='Pooja',
@MiddleName='Rani',
@LastName='Paul',
@GenderId=2,
@PhoneNo='9876543225',
@EmailId='pooja@gmail.com',
@RoleName='Receptionist',
@BankAccountNo='123456789015';

EXEC spInsertDataIntoEmployeeTable
@FirstName='Arjun',
@MiddleName='',
@LastName='Singh',
@GenderId=1,
@PhoneNo='9876543226',
@EmailId='arjun@gmail.com',
@RoleName='Trainer',
@BankAccountNo='123456789016';

SELECT *FROM tblEmployee