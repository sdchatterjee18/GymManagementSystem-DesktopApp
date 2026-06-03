CREATE PROC spInsertDataIntoWorkoutScheduleTable
    @WorkoutPlanId INT,
    @ExerciseId    INT,
    @WorkoutDay    VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @WorkoutDay = LTRIM(RTRIM(ISNULL(@WorkoutDay, '')));

        IF @WorkoutPlanId IS NULL OR @WorkoutPlanId <= 0
        BEGIN
            SELECT 'Workout Plan Id is Required and must be a positive integer.' AS Message;
            RETURN;
        END;

        IF NOT EXISTS (SELECT 1 FROM tblWorkoutPlans WHERE WorkoutPlanId = @WorkoutPlanId)
        BEGIN
            SELECT 'Workout Plan Id does not exist in tblWorkoutPlans.' AS Message;
            RETURN;
        END;

        IF @ExerciseId IS NULL OR @ExerciseId <= 0
        BEGIN
            SELECT 'Exercise Id is Required and must be a positive integer.' AS Message;
            RETURN;
        END;

        IF NOT EXISTS (SELECT 1 FROM tblExercises WHERE ExerciseId = @ExerciseId)
        BEGIN
            SELECT 'Exercise Id does not exist in tblExercises.' AS Message;
            RETURN;
        END;

        IF @WorkoutDay = ''
        BEGIN
            SELECT 'Workout Day is Required (e.g., Monday, Tuesday...).' AS Message;
            RETURN;
        END;

        IF @WorkoutDay NOT IN ('Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday')
        BEGIN
            SELECT 'Workout Day must be one of: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday.' AS Message;
            RETURN;
        END;

        IF EXISTS (
            SELECT 1 FROM tblWorkoutSchedule
            WHERE WorkoutPlanId = @WorkoutPlanId
            AND   ExerciseId    = @ExerciseId
            AND   WorkoutDay    = @WorkoutDay
        )
        BEGIN
            SELECT 'Workout Already Scheduled.' AS Message;
            RETURN;
        END;

        INSERT INTO tblWorkoutSchedule (WorkoutPlanId, ExerciseId, WorkoutDay)
        VALUES (@WorkoutPlanId, @ExerciseId, @WorkoutDay);

        IF @@ROWCOUNT > 0
            SELECT 'Workout Plan Inserted Successfully.' AS Message;
        ELSE
            SELECT 'Insert Failed.' AS Message;

    END TRY
    BEGIN CATCH
        SELECT
            ERROR_MESSAGE()   AS Message,
            ERROR_LINE()      AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;
    END CATCH
END
GO