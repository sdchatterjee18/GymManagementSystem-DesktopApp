CREATE TABLE tblTrainerShift
(
	TrainerShiftId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
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
