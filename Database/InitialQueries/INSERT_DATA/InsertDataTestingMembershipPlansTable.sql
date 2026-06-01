EXEC spInsertDataIntoMembershipPlansTable
@MembershipPlanName='Basic Plan',
@PlanType='Monthly',
@DurationInDays=30,
@Price=999,
@Description='Basic monthly gym membership'

EXEC spInsertDataIntoMembershipPlansTable
@MembershipPlanName='Premium Plan',
@PlanType='Quarterly',
@DurationInDays=90,
@Price=2499,
@Description='Premium quarterly membership with trainer support'

EXEC spInsertDataIntoMembershipPlansTable
@MembershipPlanName='Gold Plan',
@PlanType='Yearly',
@DurationInDays=365,
@Price=9999,
@Description='Full year membership with all facilities'

SELECT *FROM tblMembershipPlans