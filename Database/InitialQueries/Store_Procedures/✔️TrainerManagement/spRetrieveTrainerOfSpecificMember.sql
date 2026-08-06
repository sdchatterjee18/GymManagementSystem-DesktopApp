CREATE PROC spRetrieveTrainerOfSpecificMember 
(
    @MemberId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        ------------------------------------------------
        -- Member Validation
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMember
            WHERE MemberId = @MemberId
        )
        BEGIN
            SELECT 'Invalid Member.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Active Trainer Assigned?
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMemberTrainerAssignment
            WHERE MemberId = @MemberId
              AND IsActive = 1
        )
        BEGIN
            SELECT 'No Active Trainer Assigned To This Member.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Retrieve Trainer Details
        ------------------------------------------------
        SELECT
            CONCAT(E.FirstName ,' ',E.MiddleName,' ',E.LastName) AS TrainerName
        FROM tblMemberTrainerAssignment MTA
        INNER JOIN tblTrainer T
            ON MTA.TrainerId = T.TrainerId
        INNER JOIN tblEmployee E
            ON T.EmployeeId = E.EmployeeId
        INNER JOIN tblMember M
            ON MTA.MemberId = M.MemberId
        WHERE MTA.MemberId = @MemberId
          AND MTA.IsActive = 1;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message

    END CATCH
END;
GO