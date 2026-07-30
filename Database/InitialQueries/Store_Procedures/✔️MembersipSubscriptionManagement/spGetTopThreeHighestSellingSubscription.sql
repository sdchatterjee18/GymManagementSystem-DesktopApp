CREATE PROC spGetTopThreeHighestSellingSubscription
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TOP (3)
        mp.MembershipPlanName,
        COUNT(ms.MemberSubscriptionId) AS TotalSubscriptions
    FROM tblMembershipSubscription ms
    INNER JOIN tblMembershipPlans mp
        ON ms.MembershipPlanId = mp.MembershipPlanId
    WHERE ms.StartDate >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)
      AND ms.StartDate < DATEADD(DAY, 1, EOMONTH(GETDATE()))
    GROUP BY mp.MembershipPlanName
    ORDER BY COUNT(ms.MemberSubscriptionId) DESC;
END;