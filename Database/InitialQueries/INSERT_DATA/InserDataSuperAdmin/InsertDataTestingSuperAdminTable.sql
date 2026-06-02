EXEC spInsertDataIntoSuperAdminTable
    @UserName = 'admin1',
    @PasswordHash = 'Admin@123',
    @EmailId = 'admin1@gmail.com',
    @PhoneNumber = '9876543210';

SELECT *FROM tblSuperAdmin
