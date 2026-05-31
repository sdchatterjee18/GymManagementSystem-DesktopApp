CREATE TABLE tblAdmin(
    AdminId INT  PRIMARY KEY IDENTITY(1,1),
    EmployeeId INT NOT NULL,
    SuperAdminID INT NOT NULL,
    UserName VARCHAR(100) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    LastLogin DATETIME  NULL ,
    CONSTRAINT FK_tblAdmin_EmployeeIdtblEmployee 
		FOREIGN KEY (EmployeeId)
		REFERENCES tblEmployee(EmployeeId),
    CONSTRAINT FK_tblAdmin_SuperAdminIDtblSuperAdmin
		FOREIGN KEY (SuperAdminID)
		REFERENCES tblSuperAdmin(SuperAdminID)
);

