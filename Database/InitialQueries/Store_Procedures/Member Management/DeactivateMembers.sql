CREATE PROC spDeactivateMembers
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        BEGIN TRANSACTION;

        ---------------------------------------------------------
        -- Deactivate Members
        ---------------------------------------------------------
        UPDATE M
        SET M.IsActive = 0
        FROM tblMember M
        INNER JOIN tblMembershipSubscription MS
            ON M.MemberId = MS.MemberId
        WHERE MS.MemberSubscriptionId =
        (
            SELECT MAX(MemberSubscriptionId)
            FROM tblMembershipSubscription
            WHERE MemberId = M.MemberId
        )
        AND MS.IsActive = 0
        AND DATEADD(MONTH,3,MS.ExpiryDate) < CAST(GETDATE() AS DATE)
        AND M.IsActive = 1;

        ---------------------------------------------------------
        -- Deactivate Member Shifts
        ---------------------------------------------------------
        UPDATE MSH
        SET MSH.IsActive = 0
        FROM tblMemberShift MSH
        INNER JOIN tblMembershipSubscription MS
            ON MSH.MemberId = MS.MemberId
        WHERE MS.MemberSubscriptionId =
        (
            SELECT MAX(MemberSubscriptionId)
            FROM tblMembershipSubscription
            WHERE MemberId = MSH.MemberId
        )
        AND MS.IsActive = 0
        AND DATEADD(MONTH,3,MS.ExpiryDate) < CAST(GETDATE() AS DATE)
        AND MSH.IsActive = 1;

        ---------------------------------------------------------
        -- Release Lockers
        ---------------------------------------------------------
        UPDATE L
        SET LockerStatus = 'Available'
        FROM tblLocker L
        INNER JOIN tblLockerAllocation LA
            ON L.LockerId = LA.LockerId
        INNER JOIN tblMembershipSubscription MS
            ON LA.MemberId = MS.MemberId
        WHERE MS.MemberSubscriptionId =
        (
            SELECT MAX(MemberSubscriptionId)
            FROM tblMembershipSubscription
            WHERE MemberId = LA.MemberId
        )
        AND MS.IsActive = 0
        AND DATEADD(MONTH,3,MS.ExpiryDate) < CAST(GETDATE() AS DATE);

        ---------------------------------------------------------
        -- Remove Locker Allocation
        ---------------------------------------------------------
        DELETE LA
        FROM tblLockerAllocation LA
        INNER JOIN tblMembershipSubscription MS
            ON LA.MemberId = MS.MemberId
        WHERE MS.MemberSubscriptionId =
        (
            SELECT MAX(MemberSubscriptionId)
            FROM tblMembershipSubscription
            WHERE MemberId = LA.MemberId
        )
        AND MS.IsActive = 0
        AND DATEADD(MONTH,3,MS.ExpiryDate) < CAST(GETDATE() AS DATE);

        COMMIT TRANSACTION;

        SELECT 'Inactive members processed successfully.' AS Message;

    END TRY

    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO