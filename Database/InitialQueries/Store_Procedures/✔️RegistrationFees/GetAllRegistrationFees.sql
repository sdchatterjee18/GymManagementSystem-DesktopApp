CREATE PROCEDURE sp_GetAllRegistrationFees
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        RegistrationFeesId,
        FeeAmount,
        CASE
            WHEN IsActive = 1 THEN 'Active'
            ELSE 'Inactive'
        END IsActive,
        CreatedAt
    FROM tblRegistrationFees
    ORDER BY RegistrationFeesId DESC;
END
GO
