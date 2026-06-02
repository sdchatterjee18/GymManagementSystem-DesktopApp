CREATE TABLE tblCertificateDocument
(
	DocumentId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	TrainerId INT NOT NULL,
	Document VARBINARY(MAX) NOT NULL,

	CONSTRAINT FK_tblCertificateDocument_TrainerIdtblTrainer
	FOREIGN KEY (TrainerId)
	REFERENCES tblTrainer(TrainerId)
);
