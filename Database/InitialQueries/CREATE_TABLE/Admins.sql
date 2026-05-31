CREATE TABLE tblAdmins (
    AdminId INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeId INT NOT NULL,
    SuperAdminID INT NOT NULL,
    UserName VARCHAR(100) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    LastLogin DATETIME NULL,
    CONSTRAINT FK_EmployeeIdtblEmployeesEmployeeId
        FOREIGN KEY (EmployeeId)
        REFERENCES tblEmployees(EmployeeId),
    CONSTRAINT FK_SuperAdminIDtblSuperAdminsSuperAdminID
        FOREIGN KEY (SuperAdminID)
        REFERENCES tblSuperAdmins(SuperAdminID)
);
