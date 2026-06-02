CREATE TABLE tblWorkoutPlans(
       WorkoutPlanId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
       WorkoutName VARCHAR(100) UNIQUE NOT NULL,
       Description VARCHAR(MAX) NULL,
)

