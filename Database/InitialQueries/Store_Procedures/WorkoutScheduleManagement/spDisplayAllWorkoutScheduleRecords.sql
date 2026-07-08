CREATE PROC spDisplayAllWorkoutScheduleRecords
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        ws.WorkoutScheduleId,
        wp.WorkoutPlanId,
        wp.WorkoutName,
        e.ExerciseId,
        e.ExerciseName,
        ws.WorkoutDay
    FROM tblWorkoutSchedule ws
    INNER JOIN tblExercises e 
        ON ws.ExerciseId = e.ExerciseId
    INNER JOIN tblWorkoutPlans wp 
        ON ws.WorkoutPlanId = wp.WorkoutPlanId
    ORDER BY 
        wp.WorkoutName, 
        e.ExerciseName;
END
GO