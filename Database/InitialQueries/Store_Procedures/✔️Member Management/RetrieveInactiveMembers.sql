CREATE PROC spRetrieveInactiveMembers
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT
            MemberId,
            FirstName,
            MiddleName,
            LastName,
            PhoneNo,
            EmailId,
            City,
            District,
            State,
            EmergencyContact,
            ProfilePhoto,
            JoiningDate,
            UpdatedAt
        FROM tblMember
        WHERE IsActive = 0;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO