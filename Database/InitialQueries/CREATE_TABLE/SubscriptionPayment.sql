-- Creating table tblSubscriptionPayment
Create Table tblSubscriptionPayment(
	PaymentId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	MemberId INT References tblMember(MemberId) NOT NULL,
	MembershipPlanId INT References tblMembershipPlans(MembershipPlanId) NOT NULL,
	PaymentDate Date NOT NULL DEFAULT(GETDATE()),
	PaymentMethod VARCHAR(50) NOT NULL,
	Amount DECIMAL(10,2) CHECK(Amount >= 0) NOT NULL,
	FeesType VARCHAR(50) Check(TransactionId IN ('Monthly','Quarterly','Half-Yearly','Annually')) NOT NULL,
	TransactionId VARCHAR(100)  NOT NULL UNIQUE
)