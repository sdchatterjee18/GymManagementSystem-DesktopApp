CREATE PROCEDURE spInsertWorkoutPlanWithExerciseAndSchedule
    @WorkoutName    VARCHAR(100),
    @Description    VARCHAR(MAX) = NULL,

    @ExerciseName   VARCHAR(100),
    @MuscleType     VARCHAR(100),

    @WorkoutDay     VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    SET @WorkoutName = LTRIM(RTRIM(ISNULL(@WorkoutName,'')))
    SET @ExerciseName = LTRIM(RTRIM(ISNULL(@ExerciseName,'')))
    SET @MuscleType = LTRIM(RTRIM(ISNULL(@MuscleType,'')))
    SET @WorkoutDay = LTRIM(RTRIM(ISNULL(@WorkoutDay,'')))

    IF @WorkoutName = ''
    BEGIN
        SELECT 'WorkoutName is required.' AS Message;
        RETURN;
    END

    IF @ExerciseName = ''
    BEGIN
        SELECT 'ExerciseName is required.' AS Message;
        RETURN;
    END

    IF @MuscleType = ''
    BEGIN
        SELECT 'MuscleType is required.' AS Message;
        RETURN;
    END

    IF @WorkoutDay = ''
    BEGIN
        SELECT 'WorkoutDay is required.' AS Message;
        RETURN;
    END

    BEGIN TRY
        BEGIN TRANSACTION;

            INSERT INTO tblWorkoutPlans (WorkoutName, Description)
            VALUES (@WorkoutName, @Description);

            DECLARE @NewWorkoutPlanId INT
            SELECT @NewWorkoutPlanId = WorkoutPlanId
            FROM tblWorkoutPlans
            WHERE WorkoutName=@WorkoutName AND Description=@Description

            DECLARE @NewExerciseId INT

            SELECT @NewExerciseId = ExerciseId
            FROM tblExercises
            WHERE ExerciseName=@ExerciseName AND MuscleType=@MuscleType

            INSERT INTO tblExercises (ExerciseName, MuscleType)
            VALUES (@ExerciseName, @MuscleType);

            INSERT INTO tblWorkoutSchedule (WorkoutPlanId, ExerciseId, WorkoutDay)
            VALUES (@NewWorkoutPlanId, @NewExerciseId, @WorkoutDay);

        COMMIT TRANSACTION;

        SELECT
            'Workout Scheduled successfily.' AS Message
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT
            ERROR_MESSAGE()     AS Message,
            ERROR_LINE()        AS ErrorLine,
            ERROR_PROCEDURE()   AS ProcedureName;

    END CATCH
END;