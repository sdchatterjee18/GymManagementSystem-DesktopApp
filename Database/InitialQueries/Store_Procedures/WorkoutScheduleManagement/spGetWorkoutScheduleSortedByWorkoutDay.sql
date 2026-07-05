CREATE PROC spGetWorkoutScheduleSortedByWorkoutDay
    @WorkoutDay VARCHAR(20) = NULL  
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @WorkoutDay = LTRIM(RTRIM(@WorkoutDay));
        SET @WorkoutDay = UPPER(LEFT(@WorkoutDay, 1)) + LOWER(SUBSTRING(@WorkoutDay, 2, LEN(@WorkoutDay) - 1));

        SELECT 
            ws.WorkoutScheduleId,
            wp.WorkoutName,
            e.ExerciseName,
            ws.WorkoutDay
        FROM tblWorkoutSchedule ws
        INNER JOIN tblExercises e ON ws.ExerciseId = e.ExerciseId
        INNER JOIN tblWorkoutPlans wp ON ws.WorkoutPlanId = wp.WorkoutPlanId
        WHERE (@WorkoutDay IS NULL OR ws.WorkoutDay = @WorkoutDay)
        ORDER BY ws.WorkoutDay, ws.WorkoutScheduleId;

    END TRY
    BEGIN CATCH
        DECLARE @ErrMsg NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@ErrMsg, 16, 1);
    END CATCH
END