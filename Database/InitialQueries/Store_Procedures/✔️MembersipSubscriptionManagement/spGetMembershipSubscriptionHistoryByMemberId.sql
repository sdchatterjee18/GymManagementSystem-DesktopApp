CREATE PROC spGetMembershipSubscriptionHistoryByMemberId
(
    @MemberId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMember
        WHERE MemberId = @MemberId
    )
    BEGIN
        SELECT 'Member does not exist.' AS Message;
        RETURN;
    END

    SELECT
        MS.MemberSubscriptionId,
        MP.MembershipPlanName,
        MS.StartDate,
        MS.ExpiryDate,
        MS.IsActive
    FROM tblMembershipSubscription AS MS
    INNER JOIN tblMembershipPlans AS MP
        ON MS.MembershipPlanId = MP.MembershipPlanId
    WHERE MS.MemberId = @MemberId
    ORDER BY MS.StartDate DESC;
END;
