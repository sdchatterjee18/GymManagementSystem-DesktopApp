

CREATE PROC spInsertDataIntoWorkoutPlansTable
(
    @WorkoutName VARCHAR(100),
    @Description VARCHAR(MAX)
)
AS
BEGIN

    SET NOCOUNT ON;

    BEGIN TRY

        SET @WorkoutName = LTRIM(RTRIM(ISNULL(@WorkoutName, '')));
        SET @Description = LTRIM(RTRIM(ISNULL(@Description, '')));

        IF @WorkoutName = ''
        BEGIN
            SELECT 'Workout Name is Required.' AS Message;
            RETURN;
        END;

        IF EXISTS
        (
            SELECT 1
            FROM tblWorkoutPlans
            WHERE WorkoutName = @WorkoutName
        )
        BEGIN
            SELECT 'Workout Plan Already Exists.' AS Message;
            RETURN;
        END;

        INSERT INTO tblWorkoutPlans
        (
            WorkoutName,
            Description
        )
        VALUES
        (
            @WorkoutName,
            @Description
        );

        SELECT 'Workout Plan Inserted Successfully.' AS Message;

    END TRY
    BEGIN CATCH

        SELECT
            ERROR_MESSAGE() AS Message,
            ERROR_LINE() AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;

    END CATCH

END
GO
