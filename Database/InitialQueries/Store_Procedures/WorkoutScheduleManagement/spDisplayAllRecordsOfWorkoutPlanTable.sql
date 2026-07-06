CREATE PROC spDisplayAllRecordsOfWorkoutPlanTable
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        WorkoutPlanId,
        WorkoutName,
        Description
    FROM tblWorkoutPlans
END
GO
