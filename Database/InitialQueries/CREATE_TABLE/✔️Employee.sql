CREATE TABLE tblEmployee
(
    EmployeeId INT PRIMARY KEY NOT NULL IDENTITY(1,1) ,
    FirstName VARCHAR(150) NOT NULL,
    MiddleName VARCHAR(50) NULL,
    LastName VARCHAR(50) NOT NULL,
    GenderId INT NOT NULL,
    PhoneNo VARCHAR(20) UNIQUE NOT NULL,
    EmailId VARCHAR(150) UNIQUE NOT NULL,
    JoiningDate DATE NOT NULL DEFAULT(GETDATE()),
    IsActive BIT NOT NULL DEFAULT(1),
    RoleId INT NOT NULL,
    BankAccountNo VARCHAR(50) UNIQUE NOT NULL,
    CONSTRAINT FK_tblEmployee_GenderIdtblGender
        FOREIGN KEY (GenderId)
        REFERENCES tblGender(GenderId),
   CONSTRAINT FK_tblEmployee_RoleIdtblEmployeeRoleType
       FOREIGN KEY (RoleId)
	   REFERENCES tblEmployeeRoleType(RoleId)
);

