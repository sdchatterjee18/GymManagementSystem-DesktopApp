Create Table tblMemberTrainerAssignment(
	MemberTrainerAssignmentId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	MemberId INT NOT NULL,
	TrainerId INT NOT NULL,
	AssignedDate DATE NOT NULL DEFAULT(GETDATE()),
	IsActive BIT NOT NULL DEFAULT(1),

	CONSTRAINT FK_tblMemberTrainerAssignment_MemberIdtblMember
		FOREIGN KEY (MemberId) 
		REFERENCES tblMember(MemberId),
	CONSTRAINT FK_tblMemberTrainerAssignment_TrainerIdtblTrainer
		FOREIGN KEY (TrainerId) 
		REFERENCES tblTrainer(TrainerId) 
);