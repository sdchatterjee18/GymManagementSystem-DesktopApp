CREATE PROC spRetrieveMembersWithoutActiveMembership
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT
            M.MemberId,
            M.FirstName,
            M.MiddleName,
            M.LastName,
            M.PhoneNo,
            M.EmailId,
            M.City,
            M.District,
            M.State,
            M.EmergencyContact,
            M.ProfilePhoto,
            M.JoiningDate,
            M.UpdatedAt
        FROM tblMember M
        WHERE M.IsActive = 1
          AND NOT EXISTS
          (
              SELECT 1
              FROM tblMembershipSubscription MS
              WHERE MS.MemberId = M.MemberId
                AND MS.IsActive = 1
          );

    END TRY

    BEGIN CATCH

        SELECT
            0 AS Success,
            ERROR_MESSAGE() AS Message,
            ERROR_LINE() AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;

    END CATCH
END
GO