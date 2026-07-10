CREATE PROC spGetNthHighestSellingSubscription
    @N INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        MembershipPlanName, 
        TotalSubscriptions
    FROM (
        SELECT 
            mp.MembershipPlanName,
            COUNT(ms.MemberSubscriptionId) AS TotalSubscriptions,
            ROW_NUMBER() OVER (ORDER BY COUNT(ms.MemberSubscriptionId) DESC) AS RowNum
        FROM tblMembershipSubscription ms
        JOIN tblMembershipPlans mp 
            ON ms.MembershipPlanId = mp.MembershipPlanId
        WHERE ms.StartDate >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)
          AND ms.StartDate <= EOMONTH(GETDATE())
        GROUP BY mp.MembershipPlanName
    ) AS RankedSales
    WHERE RowNum = @N;
END;