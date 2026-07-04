CREATE TABLE tblTrainer
(
	TrainerId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	EmployeeId INT NOT NULL,
	TrainerType VARCHAR(100) NOT NULL,
	Specialization VARCHAR(200),
	JoiningDate DATE DEFAULT(GETDATE()) NOT NULL,
	IsActive Default(1)

	CONSTRAINT FK_tblTrainer_EmployeeIdtblEmployee
	FOREIGN KEY(EmployeeId)
	REFERENCES tblEmployee(EmployeeId) 
);
