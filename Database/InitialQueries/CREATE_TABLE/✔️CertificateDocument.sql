CREATE TABLE tblCertificateDocument
(
	DocumentId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	TrainerId INT NOT NULL,
	Document VARBINARY(MAX),

	CONSTRAINT FK_tblCertificateDocument_TrainerIdtblTrainer
	FOREIGN KEY (TrainerId)
	REFERENCES tblTrainer(TrainerId)
);
