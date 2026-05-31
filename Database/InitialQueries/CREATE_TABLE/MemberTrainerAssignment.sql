-- Creating Table tblMemberTrainerAssignment
Create Table tblMemberTrainerAssignment(
	MemberTrainerAssignmentId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	MemberId INT FK_MemberIdtblMemberMemberId Foreign Key(MemberId) References tblMember(MemberId) NOT NULL,
	TrainerId INT FK_TrainerIdtblTrainerTrainerId Foreign Key(TrainerId) References tblTrainer(TrainerId) NOT NULL,
	AssignedDate DATE NOT NULL DEFAULT(GETDATE()),
	IsActive BIT NOT NULL DEFAULT(1)
)

-- Add Foregin Key : 
--										FK_MemberIdtblMemberMemberId
-- tblMemberTrainerAssignment(MemberId) ------------------------------> tblMember(MemberId)

-- Add Foregin Key : 
--										FK_TrainerIdtblTrainerTrainerId
-- tblMemberTrainerAssignment(TrainerId) --------------------------------> tblTrainer(TrainerId)