CREATE PROC spDisplayAllRecordsOfExercisesTable
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        ExerciseId,
        ExerciseName,
        MuscleType
    FROM tblExercises
END
GO