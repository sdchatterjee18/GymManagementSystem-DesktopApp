-- Creating Table tblMemberDietAssignment
Create Table tblMemberDietAssignment(
	DietAssignmentId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	MemberId INT References tblMember(MemberId) NOT NULL,
	DietPlanId INT References tblDietPlans(DietPlanId) NOT NULL,
	AssignDate Date NOT NULL DEFAULT(GETDATE()),
	IsActive BIT NOT NULL DEFAULT(1)
)