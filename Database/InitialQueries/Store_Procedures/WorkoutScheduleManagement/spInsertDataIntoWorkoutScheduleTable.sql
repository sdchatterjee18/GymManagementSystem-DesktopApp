CREATE PROC spInsertDataIntoWorkoutScheduleTable
    @WorkoutPlanId INT,
    @ExerciseId    INT,
    @WorkoutDay    VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        
        IF @WorkoutPlanId IS NULL OR @ExerciseId IS NULL OR LTRIM(RTRIM(ISNULL(@WorkoutDay, ''))) = ''
        BEGIN
            SELECT 
                0 AS STATUS_CODE,
                'WorkoutPlanId, ExerciseId and WorkoutDay are required.'
            RETURN;
        END

        SET @WorkoutDay = LTRIM(RTRIM(@WorkoutDay));
        SET @WorkoutDay = UPPER(LEFT(@WorkoutDay, 1)) + LOWER(SUBSTRING(@WorkoutDay, 2, LEN(@WorkoutDay) - 1));

        IF @WorkoutDay NOT IN ('Monday','Tuesday','Wednesday','Thursday','Friday','Saturday','Sunday')
        BEGIN
            SELECT
                0 AS STATUS_CODE,
                'WorkoutDay must be a valid day name (Monday-Sunday).' AS ERROR_MESSAGE
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM tblWorkoutPlans WHERE WorkoutPlanId = @WorkoutPlanId)
        BEGIN
            SELECT
                0 AS STATUS_CODE,
                'Invalid WorkoutPlanId: no matching WorkoutPlan found.' AS ERROR_MESSAGE
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM tblExercises WHERE ExerciseId = @ExerciseId)
        BEGIN
            SELECT
                0 AS STATUS_CODE,
                'Invalid ExerciseId: no matching Exercise found.' AS ERROR_MESSAGE
            RETURN;
        END

        IF EXISTS (
            SELECT 1 FROM tblWorkoutSchedule
            WHERE WorkoutPlanId = @WorkoutPlanId
              AND ExerciseId = @ExerciseId
              AND WorkoutDay = @WorkoutDay
        )
        BEGIN
            SELECT
                0 AS STATUS_CODE,
                'This exercise is already scheduled for this day in the selected workout plan.' AS ERROR_MESSAGE
            RETURN;
        END

        INSERT INTO tblWorkoutSchedule (WorkoutPlanId, ExerciseId, WorkoutDay)
        VALUES (@WorkoutPlanId, @ExerciseId, @WorkoutDay);

        SELECT 
            1 AS STATUS_CODE,
            'Record inserted successfuly' AS ERROR_MESSAGE

    END TRY
    BEGIN CATCH
        DECLARE @ErrMsg NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@ErrMsg, 16, 1);
    END CATCH
END