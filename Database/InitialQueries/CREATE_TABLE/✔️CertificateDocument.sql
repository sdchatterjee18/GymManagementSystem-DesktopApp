CREATE TABLE tblCertificateDocument
(
	DocumentId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	TrainerId INT NOT NULL,
<<<<<<< HEAD
	Document VARBINARY(MAX),
=======
	Document VARBINARY(MAX) NULL,
>>>>>>> 543b42981862702e2140db0bfc3a991b34a8535a

	CONSTRAINT FK_tblCertificateDocument_TrainerIdtblTrainer
	FOREIGN KEY (TrainerId)
	REFERENCES tblTrainer(TrainerId)
);
