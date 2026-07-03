CREATE TABLE tblSubscriptionPayment(
	PaymentId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	MemberId INT NOT NULL,
	MembershipPlanId INT NOT NULL,
	PaymentDate Date NOT NULL DEFAULT(GETDATE()),
	PaymentMethod VARCHAR(50) NOT NULL,
	Amount DECIMAL(10,2) CHECK(Amount >= 0) NOT NULL,
	FeesType VARCHAR(50) NOT NULL,

	CONSTRAINT FK_tblSubscriptionPayment_MemberIdtblMember
		FOREIGN KEY (MemberId) 
		REFERENCES tblMember(MemberId),
	CONSTRAINT FK_tblSubscriptionPayment_MembershipPlanIdtblMembershipPlans
		FOREIGN KEY (MembershipPlanId) 
		REFERENCES tblMembershipPlans(MembershipPlanId)

);