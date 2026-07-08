CREATE PROC spRetrieveShiftOfSpecificPersonalTrainer 
(
    @TrainerId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        ------------------------------------------------
        -- Trainer Validation
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblTrainer
            WHERE TrainerId = @TrainerId
        )
        BEGIN
            SELECT 'Invalid Trainer.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Active Shift Validation
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblTrainerShift
            WHERE TrainerId = @TrainerId
              AND IsActive = 1
        )
        BEGIN
            SELECT 'No Active Shift Assigned To This Trainer.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Retrieve Active Shift
        ------------------------------------------------
        SELECT
            T.TrainerId,
            CONCAT(E.FirstName,' ',
                   ISNULL(E.MiddleName + ' ',''),
                   E.LastName) AS TrainerName,
            T.TrainerType,
            S.ShiftId,
            S.ShiftName,
            S.StartTime,
            S.EndTime
        FROM tblTrainer T
        INNER JOIN tblEmployee E
            ON T.EmployeeId = E.EmployeeId
        INNER JOIN tblTrainerShift TS
            ON T.TrainerId = TS.TrainerId
        INNER JOIN tblShift S
            ON TS.ShiftId = S.ShiftId
        WHERE T.TrainerId = @TrainerId
          AND TS.IsActive = 1;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message

    END CATCH
END;
GO