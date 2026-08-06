CREATE PROC spGetMembershipSubscriptionsByMembershipPlanIdForASpecificMonth
(
    @MembershipPlanId INT,
    @Month INT,
    @Year INT
)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMembershipPlans
        WHERE MembershipPlanId = @MembershipPlanId
    )
    BEGIN
        SELECT 'Membership plan does not exist.' AS Message;
        RETURN;
    END

    SELECT
        MS.MemberSubscriptionId,
        M.MemberId,
        M.FirstName,
        M.LastName,
        MP.MembershipPlanName,
        MS.StartDate,
        MS.ExpiryDate,
        MS.IsActive
    FROM tblMembershipSubscription AS MS
    INNER JOIN tblMember AS M
        ON MS.MemberId = M.MemberId
    INNER JOIN tblMembershipPlans AS MP
        ON MS.MembershipPlanId = MP.MembershipPlanId
    WHERE MS.MembershipPlanId = @MembershipPlanId
      AND MONTH(MS.StartDate) = @Month
      AND YEAR(MS.StartDate) = @Year
    ORDER BY MS.StartDate DESC;
END;
