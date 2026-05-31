CREATE TABLE tblSalary
(
    SalaryId INT PRIMARY KEY IDENTITY(1,1) not null,
    EmployeeId INT NOT NULL,
    Amount DECIMAL(10,2) NOT NULL 
        CHECK (Amount >= 0),

    CONSTRAINT FK_tblSalary_EmployeeIdtblEmployee
        FOREIGN KEY (EmployeeId)
        REFERENCES tblEmployee(EmployeeId)
)