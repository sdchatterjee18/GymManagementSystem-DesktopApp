CREATE PROC spGetSubscriptionHistoryByMemberId
@MemberId INT
AS
BEGIN
	SET NOCOUNT ON;

	IF @MemberId IS NOT NULL
		BEGIN
			SELECT 
				s.TransactionId,
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
				ON  s.MemberId = ms.MemberId
			JOIN tblMembershipPlans mp
				ON s.MembershipPlanId = mp.MembershipPlanId
			WHERE s.MemberId = @MemberId
		END
	ELSE
		BEGIN
			SELECT 'Member Id is required.' AS Message
		END
END
