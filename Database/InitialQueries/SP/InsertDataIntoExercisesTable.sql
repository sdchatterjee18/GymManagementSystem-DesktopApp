
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




EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Bench Press',
    @MuscleType = 'Chest';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Squat',
    @MuscleType = 'Legs';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Pull Up',
    @MuscleType = 'Back';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Deadlift',
    @MuscleType = 'Back';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Push Up',
    @MuscleType = 'Chest';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Shoulder Press',
    @MuscleType = 'Shoulders';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Bicep Curl',
    @MuscleType = 'Biceps';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Tricep Dip',
    @MuscleType = 'Triceps';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Leg Press',
    @MuscleType = 'Legs';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Lunges',
    @MuscleType = 'Legs';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Lat Pulldown',
    @MuscleType = 'Back';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Seated Row',
    @MuscleType = 'Back';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Chest Fly',
    @MuscleType = 'Chest';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Incline Bench Press',
    @MuscleType = 'Chest';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Decline Bench Press',
    @MuscleType = 'Chest';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Front Raise',
    @MuscleType = 'Shoulders';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Lateral Raise',
    @MuscleType = 'Shoulders';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Reverse Fly',
    @MuscleType = 'Shoulders';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Hammer Curl',
    @MuscleType = 'Biceps';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Preacher Curl',
    @MuscleType = 'Biceps';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Concentration Curl',
    @MuscleType = 'Biceps';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Skull Crusher',
    @MuscleType = 'Triceps';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Cable Pushdown',
    @MuscleType = 'Triceps';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Overhead Tricep Extension',
    @MuscleType = 'Triceps';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Calf Raise',
    @MuscleType = 'Calves';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Leg Curl',
    @MuscleType = 'Hamstrings';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Leg Extension',
    @MuscleType = 'Quadriceps';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Crunches',
    @MuscleType = 'Abs';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Plank',
    @MuscleType = 'Core';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Russian Twist',
    @MuscleType = 'Abs';
GO

EXEC spInsertDataIntoExercisesTable
    @ExerciseName = 'Mountain Climbers',
    @MuscleType = 'Core';
GO