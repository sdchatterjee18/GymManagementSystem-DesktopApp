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
                0 AS STATUS_CODE,
                'WorkoutName cannot be NULL or empty.' AS ERROR_MESSAGE
            RETURN;
        END

        IF LEN(@WorkoutName) > 100
        BEGIN
            SELECT
                0 AS STATUS_CODE,
                'WorkoutName cannot exceed 100 characters.' AS ERROR_MESSAGE
            RETURN;
        END

        IF @Description IS NULL OR @Description = ''
        BEGIN
            SELECT
                0 AS STATUS_CODE,
                'Description cannot be NULL or empty.' AS ERROR_MESSAGE
            RETURN;
        END


        IF @WorkoutName LIKE '%[^a-zA-Z0-9 ,''&/-]%'
        BEGIN
            SELECT
                0 AS STATUS_CODE,
                'WorkoutName contains invalid characters.' AS ERROR_MESSAGE
            RETURN;
        END

        IF EXISTS (SELECT 1 FROM tblWorkoutPlans WHERE WorkoutName = @WorkoutName)
        BEGIN
            SELECT 
                0 AS STATUS_CODE,
                'A workout plan with this name already exists.' AS ERROR_MESSAGE
            RETURN;
        END

        INSERT INTO tblWorkoutPlans (WorkoutName, Description)
        VALUES (@WorkoutName, @Description);

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