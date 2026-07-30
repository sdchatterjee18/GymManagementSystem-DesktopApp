CREATE PROC spGetActiveMembershipDetailsByMemberId
(
    @MemberId INT
)
AS
BEGIN

    SELECT
        MS.MemberSubscriptionId,
        
        MP.MembershipPlanName,
        MP.DurationInDays,
        MP.Price,
        MP.Description,

        MS.StartDate,
        MS.ExpiryDate

    FROM tblMembershipSubscription MS

    INNER JOIN tblMembershipPlans MP
        ON MS.MembershipPlanId = MP.MembershipPlanId

    WHERE 
        MS.MemberId = @MemberId
        AND MS.IsActive = 1
        AND MP.IsActive = 1;
END