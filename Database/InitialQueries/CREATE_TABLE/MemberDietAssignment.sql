Create Table tblMemberDietAssignment(
	DietAssignmentId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	MemberId INT NOT NULL,
	DietPlanId INT NOT NULL,
	AssignDate Date NOT NULL DEFAULT(GETDATE()),
	IsActive BIT NOT NULL DEFAULT(1),
	CONSTRAINT FK_tblMemberDietAssignment_MemberIdtblMember
		FOREIGN KEY (MemberId) 
		REFERENCES tblMember(MemberId),
	CONSTRAINT FK_tblMemberDietAssignment_DietPlanIdtblDietPlans
		FOREIGN KEY (DietPlanId) 
		REFERENCES tblDietPlans(DietPlanId)
);