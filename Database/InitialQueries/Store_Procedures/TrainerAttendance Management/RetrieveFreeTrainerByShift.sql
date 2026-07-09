CREATE PROC spRetrieveFreeTrainerByShift
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        DECLARE @FreeTrainer INT = 0;

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
            S.ShiftName,
            ISNULL(@FreeTrainer, 0) AS TotalFreeTrainer
        FROM tblShift S
        ORDER BY S.StartTime;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END
GO