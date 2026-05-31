-- Creating Table tblWorkoutSchedule
Create Table tblWorkoutSchedule(
	WorkoutScheduleId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	WorkoutPlanId INT FK_WorkoutPlanIdtblWorkoutPlansWorkoutPlanId Foreign Key(WorkoutPlanId) References tblWorkoutPlans(WorkoutPlanId) NOT NULL,
	ExerciseId INT FK_ExerciseIdtblExercisesExerciseId Foreign Key(ExerciseId) References tblExercises(ExerciseId) NOT NULL,
	WorkoutDay VARCHAR(20) NOT NULL
)

-- Add Foregin Key : 
--										FK_WorkoutPlanIdtblWorkoutPlansWorkoutPlanId
-- tblWorkoutSchedule(WorkoutPlanId) -------------------------------------------------> tblWorkoutPlans(WorkoutPlanId)

-- Add Foregin Key : 
--									 FK_ExerciseIdtblExercisesExerciseId
-- tblWorkoutSchedule(ExerciseId) -------------------------------------------> tblExercises(ExerciseId)