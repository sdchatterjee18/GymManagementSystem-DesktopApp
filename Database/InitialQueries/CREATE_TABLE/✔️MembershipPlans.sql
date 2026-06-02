CREATE TABLE tblMembershipPlans
(
    MembershipPlanId INT PRIMARY KEY IDENTITY(1,1),
    MembershipPlanName VARCHAR(100) NOT NULL,
    PlanType VARCHAR(50) NOT NULL,
    DurationInDays INT NOT NULL
        CHECK (DurationInDays > 0),
    Price DECIMAL(10,2) NOT NULL
        CHECK (Price >= 0),
    Description VARCHAR(MAX) NULL,
    IsActive BIT NOT NULL DEFAULT(1)
);