CREATE TABLE tblWorkoutSchedule(
	WorkoutScheduleId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	WorkoutPlanId INT NOT NULL,
	ExerciseId INT NOT NULL,
	WorkoutDay VARCHAR(20) NOT NULL,

	CONSTRAINT FK_tblWorkoutSchedule_WorkoutPlanIdtblWorkoutPlans 
		FOREIGN KEY (WorkoutPlanId) 
		REFERENCES tblWorkoutPlans(WorkoutPlanId),
	CONSTRAINT FK_tblWorkoutSchedule_ExerciseIdtblExercises 
		FOREIGN KEY (ExerciseId) 
		REFERENCES tblExercises(ExerciseId) 
);