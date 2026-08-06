CREATE PROC spRetrieveCurrentMonthNewMemberCount
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT
            COUNT(MemberId) AS TotalNewMembers
        FROM tblMember
        WHERE
            MONTH(JoiningDate) = MONTH(GETDATE())
            AND YEAR(JoiningDate) = YEAR(GETDATE())
            AND IsActive = 1;

    END TRY
    BEGIN CATCH

        SELECT
            ERROR_MESSAGE() AS ErrorMessage;

    END CATCH
END;
GO