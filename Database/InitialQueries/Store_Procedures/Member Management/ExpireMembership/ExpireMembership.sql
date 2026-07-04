CREATE PROC spExpireMembership
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        BEGIN TRANSACTION;

        ---------------------------------------------------------
        -- Deactivate Expired Membership
        ---------------------------------------------------------
        UPDATE tblMembershipSubscription
        SET IsActive = 0
        WHERE IsActive = 1
          AND ExpiryDate < CAST(GETDATE() AS DATE);

        ---------------------------------------------------------
        -- Deactivate Trainer Assignment
        ---------------------------------------------------------
        UPDATE MTA
        SET MTA.IsActive = 0
        FROM tblMemberTrainerAssignment MTA
        INNER JOIN tblMembershipSubscription MS
            ON MTA.MemberId = MS.MemberId
        WHERE MTA.IsActive = 1
          AND MS.IsActive = 0;

        COMMIT TRANSACTION;

        SELECT
            1 AS Success,
            'Expired memberships processed successfully.' AS Message;

    END TRY

    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT
            0 AS Success,
            ERROR_MESSAGE() AS Message,
            ERROR_LINE() AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;

    END CATCH
END
GO