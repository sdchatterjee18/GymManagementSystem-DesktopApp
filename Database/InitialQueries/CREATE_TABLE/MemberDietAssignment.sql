-- Creating Table tblMemberDietAssignment
Create Table tblMemberDietAssignment(
	DietAssignmentId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	MemberId INT FK_MemberIdtblMemberMemberId Foreign Key(MemberId) References tblMember(MemberId) NOT NULL,
	DietPlanId INT FK_DietPlanIdtblDietPlansDietPlanId Foreign Key(DietPlanId) References tblDietPlans(DietPlanId) NOT NULL,
	AssignDate Date NOT NULL DEFAULT(GETDATE()),
	IsActive BIT NOT NULL DEFAULT(1)
)

-- Add Foregin Key : 
--										FK_MemberIdtblMemberMemberId
-- tblMemberDietAssignment(MemberId) --------------------------------> tblMember(MemberId)

-- Add Foregin Key : 
--										FK_DietPlanIdtblDietPlansDietPlanId
-- tblMemberDietAssignment(DietPlanId) ------------------------------------> tblDietPlans(DietPlanId)