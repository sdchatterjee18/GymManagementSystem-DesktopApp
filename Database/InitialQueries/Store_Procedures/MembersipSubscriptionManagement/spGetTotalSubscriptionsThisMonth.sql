CREATE PROC spGetTotalSubscriptionsThisMonth
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        COUNT(MemberSubscriptionId) AS TotalSubscriptionsSold
    FROM tblMembershipSubscription
    WHERE StartDate >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)
      AND StartDate <= EOMONTH(GETDATE());
END;