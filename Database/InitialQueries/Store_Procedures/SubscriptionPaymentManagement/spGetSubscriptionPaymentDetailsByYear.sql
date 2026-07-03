CREATE PROC spGetSubscriptionPaymentDetailsByYear
    @Year INT
AS
BEGIN
    SET NOCOUNT ON;
    IF @Year IS NOT NULL
        BEGIN
            SELECT 
                s.PaymentId,
                s.MemberId,
                CONCAT(
                    m.FirstName, 
                    CASE WHEN m.MiddleName IS NOT NULL THEN ' ' + m.MiddleName ELSE '' END,
                    ' ', m.LastName
                ) AS MemberName,
                s.PaymentDate,
                s.PaymentMethod,
                s.Amount,
                m.EmailId,
                mp.MembershipPlanName,
                ms.StartDate,
                ms.ExpiryDate,
                s.FeesType
            FROM tblSubscriptionPayment s 
            JOIN tblMember m
                ON s.MemberId = m.MemberId
            JOIN tblMembershipSubscription ms
                ON s.MemberId = ms.MemberId
                AND s.MembershipPlanId = ms.MembershipPlanId
            JOIN tblMembershipPlans mp
                ON s.MembershipPlanId = mp.MembershipPlanId
            WHERE YEAR(s.PaymentDate) = @Year
        END
    ELSE
        BEGIN
            SELECT 'Year is required.' AS Message
        END
END