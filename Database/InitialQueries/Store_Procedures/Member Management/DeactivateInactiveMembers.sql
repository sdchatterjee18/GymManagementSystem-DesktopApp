CREATE PROC spDeactivateInactiveMembers
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        BEGIN TRANSACTION;

        ---------------------------------------------------------
        -- Inactivate Member
        ---------------------------------------------------------
        UPDATE M
        SET M.IsActive = 0
        FROM tblMember M
        INNER JOIN tblMembershipSubscription MS
            ON M.MemberId = MS.MemberId
        WHERE M.IsActive = 1
          AND MS.IsActive = 0
          AND DATEADD(MONTH,3,MS.ExpiryDate) < CAST(GETDATE() AS DATE);

        ---------------------------------------------------------
        -- Inactivate Member Shift
        ---------------------------------------------------------
        UPDATE MSH
        SET MSH.IsActive = 0
        FROM tblMemberShift MSH
        INNER JOIN tblMembershipSubscription MS
            ON MSH.MemberId = MS.MemberId
        WHERE MS.IsActive = 0
          AND DATEADD(MONTH,3,MS.ExpiryDate) < CAST(GETDATE() AS DATE);

        ---------------------------------------------------------
        -- Release Locker
        ---------------------------------------------------------
        UPDATE L
        SET LockerStatus = 'Available'
        FROM tblLocker L
        INNER JOIN tblLockerAllocation LA
            ON L.LockerId = LA.LockerId
        INNER JOIN tblMembershipSubscription MS
            ON LA.MemberId = MS.MemberId
        WHERE MS.IsActive = 0
          AND DATEADD(MONTH,3,MS.ExpiryDate) < CAST(GETDATE() AS DATE);

        COMMIT TRANSACTION;

        SELECT
            1 AS Success,
            'Inactive members processed successfully.' AS Message;

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