CREATE TABLE tblAdmin(
    AdminId INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeId INT NOT NULL,
    SuperAdminID INT NOT NULL,
    UserName VARCHAR(100) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    LastLogin DATETIME NULL,
    CONSTRAINT FK_EmployeeIdtblEmployeeEmployeeId
        FOREIGN KEY (EmployeeId)
        REFERENCES tblEmployee(EmployeeId),
    CONSTRAINT FK_SuperAdminIDtblSuperAdminSuperAdminID
        FOREIGN KEY (SuperAdminID)
        REFERENCES tblSuperAdmin(SuperAdminID)
);

