CREATE TABLE tblWorkoutSchedule(
	WorkoutScheduleId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	WorkoutPlanId INT NOT NULL,
	ExerciseId INT NOT NULL,
	WorkoutDay VARCHAR(20) NOT NULL,
	CONSTRAINT FK_WorkoutPlanIdtblWorkoutPlansWorkoutPlanId 
		FOREIGN KEY (WorkoutPlanId) 
		REFERENCES tblWorkoutPlans(WorkoutPlanId),
	CONSTRAINT FK_ExerciseIdtblExercisesExerciseId 
		FOREIGN KEY (ExerciseId) 
		REFERENCES tblExercises(ExerciseId) 
);