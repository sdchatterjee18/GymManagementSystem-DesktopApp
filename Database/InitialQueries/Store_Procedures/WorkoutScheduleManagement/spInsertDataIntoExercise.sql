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
                'ExerciseName cannot be NULL or empty.' AS ERROR_MESSAGE
            RETURN;
        END

        IF @MuscleType IS NULL OR LTRIM(RTRIM(@MuscleType)) = ''
        BEGIN
            SELECT 
                'MuscleType cannot be NULL or empty.' AS ERROR_MESSAGE
            RETURN;
        END

        IF LEN(@ExerciseName) > 100
        BEGIN
            SELECT
                'ExerciseName cannot exceed 100 characters.' AS ERROR_MESSAGE
            RETURN;
        END

        IF LEN(@MuscleType) > 100
        BEGIN
            SELECT 
                'MuscleType cannot exceed 100 characters.' AS ERROR_MESSAGE
            RETURN;
        END

        IF EXISTS (
            SELECT 1 FROM tblExercises
            WHERE ExerciseName = @ExerciseName
        )
        BEGIN
            SELECT
                'An exercise with this name already exists.' AS ERROR_MESSAGE
            RETURN;
        END

            INSERT INTO tblExercises (ExerciseName, MuscleType)
            VALUES (LTRIM(RTRIM(@ExerciseName)), LTRIM(RTRIM(@MuscleType)));
            
            SELECT 
                'Record inserted successfuly' AS ERROR_MESSAGE
    END TRY
    BEGIN CATCH
        DECLARE @ErrMsg NVARCHAR(4000) = ERROR_MESSAGE();
        
        SELECT @ErrMsg AS ERROR_MESSAGE
    END CATCH
END
GO