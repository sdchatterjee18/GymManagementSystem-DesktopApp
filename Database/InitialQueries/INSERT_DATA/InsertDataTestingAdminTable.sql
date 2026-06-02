EXEC spInsertDataIntoAdminTable
    @EmployeeId = 1,
    @SuperAdminID = 1,
    @UserName = 'Rahul_Admin1',
    @PasswordHash = 'Rahul@123';

EXEC spInsertDataIntoAdminTable
    @EmployeeId = 2,
    @SuperAdminID = 2,
    @UserName = 'Sourav_Admin1',
    @PasswordHash = 'Sourav@123';

EXEC spInsertDataIntoAdminTable
    @EmployeeId = 3,
    @SuperAdminID = 3,
    @UserName = 'Neha_Admin1',
    @PasswordHash = 'Neha@123';

EXEC spInsertDataIntoAdminTable
    @EmployeeId = 1,
    @SuperAdminID = 2,
    @UserName = 'Rahul_Admin2',
    @PasswordHash = 'Rahul@124';

EXEC spInsertDataIntoAdminTable
    @EmployeeId = 2,
    @SuperAdminID = 3,
    @UserName = 'Sourav_Admin2',
    @PasswordHash = 'Sourav@124';

EXEC spInsertDataIntoAdminTable
    @EmployeeId = 3,
    @SuperAdminID = 1,
    @UserName = 'Neha_Admin2',
    @PasswordHash = 'Neha@124';

EXEC spInsertDataIntoAdminTable
    @EmployeeId = 1,
    @SuperAdminID = 3,
    @UserName = 'Rahul_Admin3',
    @PasswordHash = 'Rahul@125';

EXEC spInsertDataIntoAdminTable
    @EmployeeId = 2,
    @SuperAdminID = 1,
    @UserName = 'Sourav_Admin3',
    @PasswordHash = 'Sourav@125';

EXEC spInsertDataIntoAdminTable
    @EmployeeId = 3,
    @SuperAdminID = 2,
    @UserName = 'Neha_Admin3',
    @PasswordHash = 'Neha@125';
