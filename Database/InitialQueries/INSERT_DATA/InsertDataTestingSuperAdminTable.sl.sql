EXEC spInsertDataIntoSuperAdminTable
@UserName='Admin1',
@PasswordHash='Pass@101',
@Email_Id='admin1@gmail.com',
@PhoneNumber='9876543201'

EXEC spInsertDataIntoSuperAdminTable
@UserName='Admin2',
@PasswordHash='Pass@102',
@Email_Id='admin2@gmail.com',
@PhoneNumber='9876543202'

EXEC spInsertDataIntoSuperAdminTable
@UserName='Admin3',
@PasswordHash='Pass@103',
@Email_Id='admin3@gmail.com',
@PhoneNumber='9876543203'

SELECT *FROM tblSuperAdmin
