EXEC spInsertDataIntoMembershipPlan
    @MembershipPlanName = 'Gold Annual Plan',
    @PlanTypeId = 4,
    @DurationInDays = 365,
    @Price = 999.99,
    @Description = 'Full access annual membership'


select * from tblMembershipPlans
select * from tblMembershipPlanType

EXEC spDeactivateMembershipPlanByMembershipPlanId @MembershipPlanId = 5;

EXEC spUpdateMembershipPlanPriceByMembershipPlanIdAssignNewPrice
    @MembershipPlanId = 1,
    @NewPrice = 00.00;

EXEC spUpdateMembershipPlanDescriptionByMembershipPlanId
    @MembershipPlanId = 5,
    @Description = 'Updated benefits for the yearly premium plan.';