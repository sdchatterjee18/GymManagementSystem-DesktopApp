CREATE PROC spRemoveWorkoutScheduleByWorkoutScheduleId
    @WorkoutScheduleId INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM tblWorkoutSchedule WHERE WorkoutScheduleId = @WorkoutScheduleId)
        BEGIN
            SELECT
                'Invalid WorkoutScheduleId: no matching record found.' AS Message
            RETURN;
        END

        IF EXISTS (
            SELECT 1 FROM tblWorkoutSchedule 
            WHERE WorkoutScheduleId = @WorkoutScheduleId AND WorkoutDay IS NULL
        )
        BEGIN
            SELECT 
                'This schedule has already been removed.' AS Message
            RETURN;
        END

        UPDATE tblWorkoutSchedule
        SET WorkoutDay = NULL
        WHERE WorkoutScheduleId = @WorkoutScheduleId;

        SELECT 
            'Record was assigned null as soft delete' AS Message

    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message
    END CATCH
END