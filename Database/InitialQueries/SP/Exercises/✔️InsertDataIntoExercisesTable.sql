
CREATE PROC spInsertDataIntoExercisesTable
(
    @ExerciseName VARCHAR(100),
    @MuscleType VARCHAR(100)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @ExerciseName = LTRIM(RTRIM(ISNULL(@ExerciseName, '')));
        SET @MuscleType = LTRIM(RTRIM(ISNULL(@MuscleType, '')));

        IF @ExerciseName = ''
        BEGIN
            SELECT 'Exercise Name is Required.' AS Message;
            RETURN;
        END;

        IF @MuscleType = ''
        BEGIN
            SELECT 'Muscle Type is Required.' AS Message;
            RETURN;
        END;

        IF EXISTS
        (
            SELECT 1
            FROM tblExercises
            WHERE ExerciseName = @ExerciseName
        )
        BEGIN
            SELECT 'Exercise Already Exists.' AS Message;
            RETURN;
        END;

        INSERT INTO tblExercises
        (
            ExerciseName,
            MuscleType
        )
        VALUES
        (
            @ExerciseName,
            @MuscleType
        );

        SELECT 'Exercise Inserted Successfully.' AS Message;

    END TRY
    BEGIN CATCH

        SELECT
            ERROR_MESSAGE() AS Message,
            ERROR_LINE() AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;

    END CATCH
END
GO
