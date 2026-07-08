CREATE PROC spInsertDataIntoWorkoutPlanTable
    @WorkoutName VARCHAR(100),
    @Description VARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
      
        SET @WorkoutName = LTRIM(RTRIM(@WorkoutName));
        SET @Description = ISNULL(LTRIM(RTRIM(@Description)), '');

        IF @WorkoutName IS NULL OR @WorkoutName = ''
        BEGIN
            SELECT
                'WorkoutName cannot be NULL or empty.' AS Message
            RETURN;
        END

        IF LEN(@WorkoutName) > 100
        BEGIN
            SELECT
                'WorkoutName cannot exceed 100 characters.' AS Message
            RETURN;
        END

        IF @Description IS NULL OR @Description = ''
        BEGIN
            SELECT
                'Description cannot be NULL or empty.' AS Message
            RETURN;
        END


        IF @WorkoutName LIKE '%[^a-zA-Z0-9 ,''&/-]%'
        BEGIN
            SELECT
                'WorkoutName contains invalid characters.' AS Message
            RETURN;
        END

        IF EXISTS (SELECT 1 FROM tblWorkoutPlans WHERE WorkoutName = @WorkoutName)
        BEGIN
            SELECT 
                'A workout plan with this name already exists.' AS Message
            RETURN;
        END

        INSERT INTO tblWorkoutPlans (WorkoutName, Description)
        VALUES (@WorkoutName, @Description);

        SELECT 
            'Record inserted successfuly' AS Message

    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message
    END CATCH
END