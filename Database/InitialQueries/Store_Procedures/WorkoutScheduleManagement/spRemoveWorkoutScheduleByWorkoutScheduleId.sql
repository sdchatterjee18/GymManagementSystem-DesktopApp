CREATE PROC spRemoveWorkoutScheduleByWorkoutScheduleId
    @WorkoutScheduleId INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM tblWorkoutSchedule WHERE WorkoutScheduleId = @WorkoutScheduleId)
        BEGIN
            SELECT
                'Invalid WorkoutScheduleId: no matching record found.' AS ERROR_MESSAGE
            RETURN;
        END

        IF EXISTS (
            SELECT 1 FROM tblWorkoutSchedule 
            WHERE WorkoutScheduleId = @WorkoutScheduleId AND WorkoutDay IS NULL
        )
        BEGIN
            SELECT 
                'This schedule has already been removed.' AS ERROR_MESSAGE
            RETURN;
        END

        UPDATE tblWorkoutSchedule
        SET WorkoutDay = NULL
        WHERE WorkoutScheduleId = @WorkoutScheduleId;

        SELECT 
            'Record was assigned null as soft delete' AS ERROR_MESSAGE

    END TRY
    BEGIN CATCH
        DECLARE @ErrMsg NVARCHAR(4000) = ERROR_MESSAGE();
        SELECT @ErrMsg AS ERROR_MESSAGE
    END CATCH
END