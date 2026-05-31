CREATE TABLE tblSalaryPayment
(
    PaymentId INT  PRIMARY KEY IDENTITY(1,1) not null,
    SalaryId INT NOT NULL,
    PaymentMode VARCHAR(50) NOT NULL,
    PaymentMonth VARCHAR(10) NOT NULL,
    PaymentYear INT NOT NULL,
    PaymentDate DATETIME NOT NULL
        DEFAULT(GETDATE()),
    PaymentStatus VARCHAR(50) NOT NULL,

    CONSTRAINT FK_tblSalaryPayment_SalaryIdtblSalary
        FOREIGN KEY (SalaryId)
        REFERENCES tblSalary(SalaryId)
);