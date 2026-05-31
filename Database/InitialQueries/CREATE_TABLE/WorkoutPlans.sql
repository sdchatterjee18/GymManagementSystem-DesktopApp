CREATE TABLE tblWorkoutPlans(
       WorkoutPlanId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
       WorkoutName VARCHAR(100) UNIQUE NOT NULL,
       Description VARCHAR(MAX),
)

