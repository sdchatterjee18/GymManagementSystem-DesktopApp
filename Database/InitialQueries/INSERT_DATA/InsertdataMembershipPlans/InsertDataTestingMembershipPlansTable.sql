EXEC spInsertDataIntoMembershipPlansTable
@MembershipPlanName = 'Basic Monthly Plan',
@PlanTypeId = 1,
@DurationInDays = 30,
@Price = 999.00,
@Description = 'Basic monthly gym membership';

EXEC spInsertDataIntoMembershipPlansTable
@MembershipPlanName = 'Premium Monthly Plan',
@PlanTypeId = 1,
@DurationInDays = 30,
@Price = 1499.00,
@Description = 'Monthly membership with trainer support';

EXEC spInsertDataIntoMembershipPlansTable
@MembershipPlanName = 'Standard Quarterly Plan',
@PlanTypeId = 2,
@DurationInDays = 90,
@Price = 2499.00,
@Description = 'Quarterly gym membership';

EXEC spInsertDataIntoMembershipPlansTable
@MembershipPlanName = 'Premium Quarterly Plan',
@PlanTypeId = 2,
@DurationInDays = 90,
@Price = 3499.00,
@Description = 'Quarterly membership with personal trainer';

EXEC spInsertDataIntoMembershipPlansTable
@MembershipPlanName = 'Basic Half Yearly Plan',
@PlanTypeId = 3,
@DurationInDays = 180,
@Price = 4999.00,
@Description = 'Half yearly gym membership';

EXEC spInsertDataIntoMembershipPlansTable
@MembershipPlanName = 'Premium Half Yearly Plan',
@PlanTypeId = 3,
@DurationInDays = 180,
@Price = 6999.00,
@Description = 'Half yearly membership with extra facilities';

EXEC spInsertDataIntoMembershipPlansTable
@MembershipPlanName = 'Basic Yearly Plan',
@PlanTypeId = 4,
@DurationInDays = 365,
@Price = 8999.00,
@Description = 'Full year gym membership';

EXEC spInsertDataIntoMembershipPlansTable
@MembershipPlanName = 'Gold Yearly Plan',
@PlanTypeId = 4,
@DurationInDays = 365,
@Price = 11999.00,
@Description = 'Yearly membership with all facilities';

EXEC spInsertDataIntoMembershipPlansTable
@MembershipPlanName = 'Student Monthly Plan',
@PlanTypeId = 1,
@DurationInDays = 30,
@Price = 799.00,
@Description = 'Discounted monthly plan for students';

EXEC spInsertDataIntoMembershipPlansTable
@MembershipPlanName = 'Corporate Yearly Plan',
@PlanTypeId = 4,
@DurationInDays = 365,
@Price = 14999.00,
@Description = 'Corporate membership package';

SELECT *FROM tblMembershipPlans