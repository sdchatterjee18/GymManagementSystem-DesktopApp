CREATE PROC spGetSubscriptionPaymentDetailsByMonth
@Month VARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	SET @Month = LTRIM(RTRIM(ISNULL(@Month,'')))
	IF @Month <> '' AND @Month IN ('January', 'February', 'March', 'April', 'May', 'June','July', 'August', 'September', 'October', 'November', 'December')
		BEGIN
			SELECT 
				s.TransactionId,
				s.MemberId,
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
				ON  s.MemberId = ms.MemberId
				AND s.MembershipPlanId = ms.MembershipPlanId
			JOIN tblMembershipPlans mp
				ON s.MembershipPlanId = mp.MembershipPlanId
			WHERE FORMAT(s.PaymentDate, 'MMMM') = @Month
		END
	ELSE
		BEGIN
			SELECT 'Month is required and it needs to be a proper month name.' AS Message
		END
END