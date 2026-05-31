CREATE TABLE tblMembershipSubscription (
    MemberSubscriptionId  INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    MemberId INT NOT NULL,
    MembershipPlanId INT NOT NULL,
    StartDate DATE NOT NULL,
    ExpiryDate DATE NOT NULL,
    IsActive BIT NOT NULL DEFAULT(1),
    CONSTRAINT FK_tblMemberSubscription_MemberIdtblMember
		FOREIGN KEY (MemberId)
		REFERENCES tblMember(MemberId),
    CONSTRAINT FK_tblMemberSubscription_MembershipPlanIdtblMembershipPlan
		FOREIGN KEY (MembershipPlanId)
		REFERENCES tblMembershipPlans(MembershipPlanId)
);