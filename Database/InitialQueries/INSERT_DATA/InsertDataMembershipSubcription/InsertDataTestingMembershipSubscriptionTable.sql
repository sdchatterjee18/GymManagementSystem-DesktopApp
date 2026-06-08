EXEC spInsertDataIntoMembershipSubscriptionTable
@MemberId = 1,
@MembershipPlanId = 1,
@StartDate = '2026-07-01',
@ExpiryDate = '2026-08-01';

EXEC spInsertDataIntoMembershipSubscriptionTable
@MemberId = 2,
@MembershipPlanId = 2,
@StartDate = '2026-07-01',
@ExpiryDate = '2026-08-01';

EXEC spInsertDataIntoMembershipSubscriptionTable
@MemberId = 3,
@MembershipPlanId = 3,
@StartDate = '2026-07-01',
@ExpiryDate = '2026-09-29';

EXEC spInsertDataIntoMembershipSubscriptionTable
@MemberId = 4,
@MembershipPlanId = 4,
@StartDate = '2026-07-01',
@ExpiryDate = '2027-07-01';