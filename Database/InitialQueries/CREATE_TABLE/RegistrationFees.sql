
CREATE TABLE tblRegistrationFees(
       RegistrationFeesId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
       FeeAmount DECIMAL(10,2) CHECK(FeeAmount >= 0) NOT NULL,
       IsActive BIT DEFAULT(1) NOT NULL,
       CreatedAt DATETIME 	DEFAULT(GETDATE()) NOT NULL
)
