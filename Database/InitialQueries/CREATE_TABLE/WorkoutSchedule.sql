-- Creating Table tblWorkoutSchedule
Create Table tblWorkoutSchedule(
	WorkoutScheduleId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	WorkoutPlanId INT References tblWorkoutPlans(WorkoutPlanId) NOT NULL,
	ExerciseId INT References tblExercises(ExerciseId) NOT NULL,
	WorkoutDay VARCHAR(20) NOT NULL
)