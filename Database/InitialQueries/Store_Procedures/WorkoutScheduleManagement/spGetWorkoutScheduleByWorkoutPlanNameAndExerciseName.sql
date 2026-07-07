CREATE PROC spGetWorkoutScheduleByWorkoutPlanNameAndExerciseName
    @WorkoutPlanName NVARCHAR(100) = NULL,
    @ExerciseName    NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        ws.WorkoutScheduleId,
        wp.WorkoutName,
        e.ExerciseName,
        ws.WorkoutDay
    FROM tblWorkoutSchedule ws
    INNER JOIN tblExercises e 
        ON ws.ExerciseId = e.ExerciseId
    INNER JOIN tblWorkoutPlans wp 
        ON ws.WorkoutPlanId = wp.WorkoutPlanId
    WHERE ws.WorkoutDay IS NOT NULL
        AND (@WorkoutPlanName IS NULL OR wp.WorkoutName = @WorkoutPlanName)
        AND (@ExerciseName IS NULL OR e.ExerciseName = @ExerciseName)
    ORDER BY 
        wp.WorkoutName, 
        e.ExerciseName;
END
GO