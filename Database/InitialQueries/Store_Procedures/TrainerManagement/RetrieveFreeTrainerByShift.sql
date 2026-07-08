CREATE PROC spRetrieveFreeTrainerByShift
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        DECLARE @FreeTrainer INT;

        SELECT
            @FreeTrainer = COUNT(*)
        FROM tblTrainer T
        WHERE T.IsActive = 1
          AND NOT EXISTS
          (
              SELECT 1
              FROM tblMemberTrainerAssignment MTA
              WHERE MTA.TrainerId = T.TrainerId
                AND MTA.IsActive = 1
          );

        SELECT
            ShiftName,
            @FreeTrainer AS TotalFreeTrainer
        FROM tblShift
        ORDER BY StartTime;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END
GO