-- Creating Table tblMemberDietAssignment
Create Table tblMemberDietAssignment(
	DietAssignmentId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	MemberId INT NOT NULL,
	DietPlanId INT NOT NULL,
	AssignDate Date NOT NULL DEFAULT(GETDATE()),
	IsActive BIT NOT NULL DEFAULT(1),
	CONSTRAINT FK_MemberIdtblMemberMemberId 
		FOREIGN KEY (MemberId) 
		REFERENCES tblMember(MemberId),
	CONSTRAINT FK_DietPlanIdtblDietPlansDietPlanId 
		FOREIGN KEY (DietPlanId) 
		REFERENCES tblDietPlans(DietPlanId)
);