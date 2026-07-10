CREATE PROCEDURE spDisplayMembersWithoutPersonalTrainer
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT
    M.MemberId,
    CONCAT(M.FirstName, ' ', M.MiddleName, ' ', M.LastName) AS MemberName
    FROM tblMember AS M
    WHERE NOT EXISTS (
    SELECT 1
    FROM tblMemberTrainerAssignment AS MTA
    WHERE MTA.MemberId = M.MemberId
      AND MTA.IsActive = 1
    );

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message
           
    END CATCH
END;
GO