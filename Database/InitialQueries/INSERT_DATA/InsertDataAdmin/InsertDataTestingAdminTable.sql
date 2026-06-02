EXEC spInsertDataIntoAdminTable
    @EmployeeId = 1,
    @SuperAdminID = 1,
    @UserName = 'Rahul_Admin1',
    @PasswordHash = 'Rahul@123';

EXEC spInsertDataIntoAdminTable
    @EmployeeId = 2,
    @SuperAdminID = 1,
    @UserName = 'Sourav_Admin1',
    @PasswordHash = 'Sourav@123';

EXEC spInsertDataIntoAdminTable
    @EmployeeId = 3,
    @SuperAdminID = 1,
    @UserName = 'Neha_Admin1',
    @PasswordHash = 'Neha@123';

EXEC spInsertDataIntoAdminTable
    @EmployeeId = 4,
    @SuperAdminID = 2,
    @UserName = 'Rahul_Admin2',
    @PasswordHash = 'Rahul@124';

EXEC spInsertDataIntoAdminTable
    @EmployeeId = 4,
    @SuperAdminID = 1,
    @UserName = 'Sourav_Admin2',
    @PasswordHash = 'Sourav@124';
