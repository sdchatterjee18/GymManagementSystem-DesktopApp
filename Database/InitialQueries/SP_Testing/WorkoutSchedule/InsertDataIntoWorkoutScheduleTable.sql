CREATE PROC spInsertDataIntoWorkoutScheduleTable
    @WorkoutPlanId INT,
    @ExerciseId    INT,
    @WorkoutDay    VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @WorkoutPlanId = LTRIM(RTRIM(ISNULL(@WorkoutPlanId, '')));
        SET @ExerciseId= LTRIM(RTRIM(ISNULL(@ExerciseId, '')));
        SET @WorkoutDay = LTRIM(RTRIM(ISNULL(@WorkoutDay, '')));

        IF @WorkoutPlanId = ''
        BEGIN
            SELECT 'Workout Plan Id is Required.' AS Message;
            RETURN;
        END;

        IF @ExerciseId = ''
        BEGIN
            SELECT 'Exercise Id is Required.' AS Message;
            RETURN;
        END;

        IF @WorkoutDay = ''
        BEGIN
            SELECT 'Workout Day is Required (e.g., Monday, Tuesday...).' AS Message;
            RETURN;
        END;

        IF EXISTS (
            SELECT 1 FROM tblWorkoutSchedule
            WHERE WorkoutPlanId = @WorkoutPlanId 
            AND ExerciseId = @ExerciseId 
            AND WorkoutDay = @WorkoutDay
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