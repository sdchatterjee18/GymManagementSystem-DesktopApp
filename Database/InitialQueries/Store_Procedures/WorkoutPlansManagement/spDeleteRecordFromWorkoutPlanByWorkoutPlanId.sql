CREATE PROC spDeleteRecordFromWorkoutPlanByWorkoutPlanId
    @WorkoutPlanId INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF @WorkoutPlanId IS NULL
        BEGIN
            SELECT
                0 AS STATUS_CODE,
                'WorkoutPlanId cannot be NULL.' AS ERROR_MESSAGE
            RETURN;
        END

        IF NOT EXISTS (
            SELECT 1 FROM tblWorkoutPlans
            WHERE WorkoutPlanId = @WorkoutPlanId
        )
        BEGIN
            SELECT
                0 AS STATUS_CODE,
                'No workout plan found with the specified Id.' AS ERROR_MESSAGE
            RETURN;
        END

            DELETE FROM tblWorkoutPlans
            WHERE WorkoutPlanId = @WorkoutPlanId;

        SELECT 
            1 AS STATUS_CODE,
            'Record Inserted successfuly' AS ERROR_MESSAGE

    END TRY
    BEGIN CATCH
        DECLARE @ErrMsg NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrState INT = ERROR_STATE();

        RAISERROR(@ErrMsg, @ErrSeverity, @ErrState);
    END CATCH
END
GO