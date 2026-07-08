CREATE PROC spUpdateWorkoutScheduleRecord
    @WorkoutScheduleId INT,
    @WorkoutPlanId INT = NULL,
    @ExerciseId INT = NULL,
    @WorkoutDay NVARCHAR(20) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM tblExercises WHERE ExerciseId = @ExerciseId)
    BEGIN
        SELECT 
            'ExerciseId not found in Exercises table.' AS Message
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM tblWorkoutPlans WHERE WorkoutPlanId = @WorkoutPlanId)
    BEGIN
        SELECT 
            'WorkoutPlaneId not found in WorkoutPlans table.' AS Message
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM tblWorkoutSchedule WHERE WorkoutScheduleId = @WorkoutScheduleId)
    BEGIN
        SELECT 
            'WorkoutSchedule record with ScheduleId not found.' AS Message
        RETURN;
    END

    UPDATE tblWorkoutSchedule
    SET
        WorkoutPlanId = ISNULL(@WorkoutPlanId, WorkoutPlanId),
        ExerciseId = ISNULL(@ExerciseId, ExerciseId),
        WorkoutDay = ISNULL(@WorkoutDay, WorkoutDay)
    WHERE WorkoutScheduleId = @WorkoutScheduleId;

    SELECT 
        'Record updated successfuly.' AS Message
END
GO