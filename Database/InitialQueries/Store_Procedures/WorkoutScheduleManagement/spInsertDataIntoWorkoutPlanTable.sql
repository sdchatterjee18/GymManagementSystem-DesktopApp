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
                'WorkoutName cannot be NULL or empty.' AS ERROR_MESSAGE
            RETURN;
        END

        IF LEN(@WorkoutName) > 100
        BEGIN
            SELECT
                'WorkoutName cannot exceed 100 characters.' AS ERROR_MESSAGE
            RETURN;
        END

        IF @Description IS NULL OR @Description = ''
        BEGIN
            SELECT
                'Description cannot be NULL or empty.' AS ERROR_MESSAGE
            RETURN;
        END


        IF @WorkoutName LIKE '%[^a-zA-Z0-9 ,''&/-]%'
        BEGIN
            SELECT
                'WorkoutName contains invalid characters.' AS ERROR_MESSAGE
            RETURN;
        END

        IF EXISTS (SELECT 1 FROM tblWorkoutPlans WHERE WorkoutName = @WorkoutName)
        BEGIN
            SELECT 
                'A workout plan with this name already exists.' AS ERROR_MESSAGE
            RETURN;
        END

        INSERT INTO tblWorkoutPlans (WorkoutName, Description)
        VALUES (@WorkoutName, @Description);

        SELECT 
            'Record inserted successfuly' AS ERROR_MESSAGE

    END TRY
    BEGIN CATCH
        DECLARE @ErrMsg NVARCHAR(4000) = ERROR_MESSAGE();
        
        SELECT @ErrMsg AS ERROR_MESSAGE
    END CATCH
END