CREATE PROC spInsertDataIntoExercise
    @ExerciseName VARCHAR(100),
    @MuscleType VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
   
        IF @ExerciseName IS NULL OR LTRIM(RTRIM(@ExerciseName)) = ''
        BEGIN
            SELECT 
                'ExerciseName cannot be NULL or empty.' AS Message
            RETURN;
        END

        IF @MuscleType IS NULL OR LTRIM(RTRIM(@MuscleType)) = ''
        BEGIN
            SELECT 
                'MuscleType cannot be NULL or empty.' AS Message
            RETURN;
        END

        IF LEN(@ExerciseName) > 100
        BEGIN
            SELECT
                'ExerciseName cannot exceed 100 characters.' AS Message
            RETURN;
        END

        IF LEN(@MuscleType) > 100
        BEGIN
            SELECT 
                'MuscleType cannot exceed 100 characters.' AS Message
            RETURN;
        END

        IF EXISTS (
            SELECT 1 FROM tblExercises
            WHERE ExerciseName = @ExerciseName
        )
        BEGIN
            SELECT
                'An exercise with this name already exists.' AS Message
            RETURN;
        END

            INSERT INTO tblExercises (ExerciseName, MuscleType)
            VALUES (LTRIM(RTRIM(@ExerciseName)), LTRIM(RTRIM(@MuscleType)));
            
            SELECT 
                'Record inserted successfuly' AS Message
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message
    END CATCH
END
GO