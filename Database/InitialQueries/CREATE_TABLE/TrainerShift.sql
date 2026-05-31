CREATE TABLE tblTrainerShift
(
	TrainerId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	TrainerId INT NOT NULL,
	ShiftId INT NOT NULL,
	IsActive BIT DEFAULT(1) NOT NULL,

	CONSTRAINT FK_tblTrainerShift_TrainerIdtblTrainer
	FOREIGN KEY(TrainerId)
	REFERENCES tblTrainer(TrainerId),
	CONSTRAINT FK_tblTrainerShift_ShiftIdtblShift
	FOREIGN KEY (ShiftId)
	REFERENCES tblShift(ShiftId)
);
