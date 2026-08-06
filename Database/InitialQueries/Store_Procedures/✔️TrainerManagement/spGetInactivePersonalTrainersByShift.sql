CREATE PROC spGetInactivePersonalTrainersByShift
(
    @ShiftId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        -- Validation
        IF @ShiftId IS NULL OR @ShiftId <= 0
        BEGIN
            SELECT 'Valid ShiftId is required.' AS Message;
            RETURN;
        END

        -- Check Shift Exists
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblShift
            WHERE ShiftId = @ShiftId
        )
        BEGIN
            SELECT 'Shift does not exist.' AS Message;
            RETURN;
        END

        -- Fetch Personal Trainers whose TrainerShift IsActive = 0
        SELECT
           
            T.TrainerId,
           
            CONCAT(E.FirstName,' ',E.MiddleName,' ',E.LastName) AS TrainerName,
            E.PhoneNo,
            
            T.Specialization,
           
 
            TS.IsActive AS TrainerShiftStatus
        FROM tblTrainerShift TS
        INNER JOIN tblTrainer T
            ON TS.TrainerId = T.TrainerId
        INNER JOIN tblEmployee E
            ON T.EmployeeId = E.EmployeeId
        INNER JOIN tblShift S
            ON TS.ShiftId = S.ShiftId
        WHERE TS.ShiftId = @ShiftId
              AND TS.IsActive = 0
              AND T.TrainerType = 'Personal'
        ORDER BY E.FirstName, E.LastName;

    END TRY
    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message
    END CATCH
END
GO