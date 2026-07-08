CREATE PROCEDURE spDisplayMembersWithoutPersonalTrainer
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT
            M.MemberId,
            CONCAT(M.FirstName,' ',M.MiddleName,' ',M.LastName) AS MemberName
            
        FROM tblMember AS M
        LEFT JOIN tblMemberTrainerAssignment AS MTA
            ON M.MemberId = MTA.MemberId
        LEFT JOIN tblTrainer AS T
            ON MTA.TrainerId = T.TrainerId
            AND T.TrainerType = 'Personal'
        WHERE T.TrainerId IS NULL;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message
           
    END CATCH
END;
GO