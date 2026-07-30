CREATE PROC spGetPersonalTrainerShiftStatus 
(
    @TrainerId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        -- Validation
        IF @TrainerId IS NULL OR @TrainerId <= 0
        BEGIN
            SELECT 'Valid TrainerId is required.' AS Message;
            RETURN;
        END;

        -- Check Trainer Exists
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblTrainer
            WHERE TrainerId = @TrainerId
        )
        BEGIN
            SELECT 'Trainer does not exist.' AS Message;
            RETURN;
        END;

        -- Check Trainer is Personal Trainer
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblTrainer
            WHERE TrainerId = @TrainerId
                  AND TrainerType = 'Personal'
        )
        BEGIN
            SELECT 'Specified trainer is not a Personal Trainer.' AS Message;
            RETURN;
        END;

        -- Show Trainer Shift Status
        SELECT
            T.TrainerId,
			E.FirstName,
            E.MiddleName,
            E.LastName,
            E.PhoneNo,
            S.ShiftName,
            S.StartTime,
            S.EndTime,
            TS.IsActive
        FROM tblTrainer T
		INNER JOIN tblEmployee E
                ON T.EmployeeId = E.EmployeeId
        INNER JOIN tblTrainerShift TS
            ON T.TrainerId = TS.TrainerId
        INNER JOIN tblShift S
            ON TS.ShiftId = S.ShiftId
        WHERE T.TrainerId = @TrainerId
              AND T.TrainerType = 'Personal'
        ORDER BY S.StartTime;

    END TRY

    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message
    END CATCH
END;
GO