CREATE PROC spRemoveWorkoutScheduleByWorkoutScheduleId
    @WorkoutScheduleId INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM tblWorkoutSchedule WHERE WorkoutScheduleId = @WorkoutScheduleId)
        BEGIN
            SELECT
                0 AS STATUS_CODE,
                'Invalid WorkoutScheduleId: no matching record found.' AS ERROR_MESSAGE
            RETURN;
        END

        IF EXISTS (
            SELECT 1 FROM tblWorkoutSchedule 
            WHERE WorkoutScheduleId = @WorkoutScheduleId AND WorkoutDay IS NULL
        )
        BEGIN
            SELECT 
                0 AS STATUS_CODE,
                'This schedule has already been removed.' AS ERROR_MESSAGE
            RETURN;
        END

        UPDATE tblWorkoutSchedule
        SET WorkoutDay = NULL
        WHERE WorkoutScheduleId = @WorkoutScheduleId;

        SELECT 
            1 AS STATUS_CODE,
            'Record was assigned null as soft delete' AS MESSAGE

    END TRY
    BEGIN CATCH
        DECLARE @ErrMsg NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@ErrMsg, 16, 1);
    END CATCH
END