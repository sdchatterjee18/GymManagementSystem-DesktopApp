-- Creating Table tblMemberTrainerAssignment
Create Table tblMemberTrainerAssignment(
	MemberTrainerAssignmentId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	MemberId INT References tblMember(MemberId) NOT NULL,
	TrainerId INT References tblTrainer(TrainerId) NOT NULL,
	AssignedDate DATE NOT NULL DEFAULT(GETDATE()),
	IsActive BIT NOT NULL DEFAULT(1)
)