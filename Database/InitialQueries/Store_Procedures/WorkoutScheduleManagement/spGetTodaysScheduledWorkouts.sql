CREATE PROCEDURE spGetTodaysScheduledWorkouts
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        DECLARE @DayName VARCHAR(20) = DATENAME(WEEKDAY, CAST(GETDATE() AS DATE));

        SELECT 
            ws.WorkoutScheduleId,
            wp.WorkoutName,
            e.ExerciseName,
            ws.WorkoutDay
        FROM tblWorkoutSchedule ws
        INNER JOIN tblExercises e ON ws.ExerciseId = e.ExerciseId
        INNER JOIN tblWorkoutPlans wp ON ws.WorkoutPlanId = wp.WorkoutPlanId
        WHERE ws.WorkoutDay = @DayName
          AND ws.WorkoutDay IS NOT NULL
        ORDER BY wp.WorkoutName, e.ExerciseName;

    END TRY
    BEGIN CATCH
        DECLARE @ErrMsg NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@ErrMsg, 16, 1);
    END CATCH
END