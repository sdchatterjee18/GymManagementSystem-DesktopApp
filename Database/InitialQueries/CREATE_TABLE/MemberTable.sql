
-- CREATE tblMemberTable 
CREATE TABLE tblMember (
    MemberId INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    MiddleName VARCHAR(50) NULL,
    LastName VARCHAR(50) NOT NULL,
    Gender VARCHAR(20) NOT NULL
        CHECK (Gender IN ('Male', 'Female', 'Other')),
    DOB DATE NOT NULL,
    PhoneNo VARCHAR(20) NOT NULL UNIQUE,
    Email_Id VARCHAR(150) NULL UNIQUE,
    Address VARCHAR(300) NOT NULL,
    City VARCHAR(100) NOT NULL,
    District VARCHAR(100) NOT NULL,
    State VARCHAR(100) NOT NULL,
    EmergencyContact VARCHAR(20) NULL,
    ProfilePhoto VARBINARY(MAX) NULL,
    JoiningDate DATETIME NOT NULL
        DEFAULT(GETDATE()),
    IsActive BIT NOT NULL
        DEFAULT(1),
    UpdatedAt DATETIME NULL
);
