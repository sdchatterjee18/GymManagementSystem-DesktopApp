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
                'WorkoutPlanId, ExerciseId and WorkoutDay are required.' AS Message
            RETURN;
        END

        SET @WorkoutDay = LTRIM(RTRIM(@WorkoutDay));
        SET @WorkoutDay = UPPER(LEFT(@WorkoutDay, 1)) + LOWER(SUBSTRING(@WorkoutDay, 2, LEN(@WorkoutDay) - 1));

        IF @WorkoutDay NOT IN ('Monday','Tuesday','Wednesday','Thursday','Friday','Saturday','Sunday')
        BEGIN
            SELECT
                'WorkoutDay must be a valid day name (Monday-Sunday).' AS Message
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM tblWorkoutPlans WHERE WorkoutPlanId = @WorkoutPlanId)
        BEGIN
            SELECT
                'Invalid WorkoutPlanId: no matching WorkoutPlan found.' AS Message
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM tblExercises WHERE ExerciseId = @ExerciseId)
        BEGIN
            SELECT
                'Invalid ExerciseId: no matching Exercise found.' AS Message
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
                'This exercise is already scheduled for this day in the selected workout plan.' AS Message
            RETURN;
        END

        INSERT INTO tblWorkoutSchedule (WorkoutPlanId, ExerciseId, WorkoutDay)
        VALUES (@WorkoutPlanId, @ExerciseId, @WorkoutDay);

        SELECT
            'Record inserted successfuly' AS Message

    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message
    END CATCH
END