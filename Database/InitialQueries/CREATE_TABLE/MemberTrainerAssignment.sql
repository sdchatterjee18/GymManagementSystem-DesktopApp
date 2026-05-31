Create Table tblMemberTrainerAssignment(
	MemberTrainerAssignmentId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	MemberId INT NOT NULL,
	TrainerId INT NOT NULL,
	AssignedDate DATE NOT NULL DEFAULT(GETDATE()),
	IsActive BIT NOT NULL DEFAULT(1),
	CONSTRAINT FK_MemberIdtblMemberMemberId 
		FOREIGN KEY (MemberId) 
		REFERENCES tblMember(MemberId),
	CONSTRAINT FK_TrainerIdtblTrainerTrainerId 
		FOREIGN KEY (TrainerId) 
		REFERENCES tblTrainer(TrainerId) 
);