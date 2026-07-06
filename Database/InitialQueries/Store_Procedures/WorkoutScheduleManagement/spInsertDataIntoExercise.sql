CREATE PROC spInsertDataIntoExercise
    @ExerciseName VARCHAR(100),
    @MuscleType VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
   
        IF @ExerciseName IS NULL OR LTRIM(RTRIM(@ExerciseName)) = ''
        BEGIN
            RAISERROR('ExerciseName cannot be NULL or empty.', 16, 1);
            RETURN;
        END

        IF @MuscleType IS NULL OR LTRIM(RTRIM(@MuscleType)) = ''
        BEGIN
            SELECT 
                0 AS STATUS_CODE,
                'MuscleType cannot be NULL or empty.' AS ERROR_MESSAGE
            RETURN;
        END

        IF LEN(@ExerciseName) > 100
        BEGIN
            SELECT
                0 AS STATUS_CODE,
                'ExerciseName cannot exceed 100 characters.' AS ERROR_MESSAGE
            RETURN;
        END

        IF LEN(@MuscleType) > 100
        BEGIN
            SELECT 
                0 AS STATUS_CODE,
                'MuscleType cannot exceed 100 characters.' AS ERROR_MESSAGE
            RETURN;
        END

        IF EXISTS (
            SELECT 1 FROM tblExercises
            WHERE ExerciseName = @ExerciseName
        )
        BEGIN
            SELECT
                0 AS STATUS_CODE,
                'An exercise with this name already exists.' AS ERROR_MESSAGE
            RETURN;
        END

            INSERT INTO tblExercises (ExerciseName, MuscleType)
            VALUES (LTRIM(RTRIM(@ExerciseName)), LTRIM(RTRIM(@MuscleType)));
            
            SELECT 
                1 AS STATUS_CODE,
                'Record inserted successfuly' AS ERROR_MESSAGE
    END TRY
    BEGIN CATCH
        DECLARE @ErrMsg NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrState INT = ERROR_STATE();

        RAISERROR(@ErrMsg, @ErrSeverity, @ErrState);
    END CATCH
END
GO