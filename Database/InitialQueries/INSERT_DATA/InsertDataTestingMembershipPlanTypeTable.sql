EXEC spInsertDataIntoMembershipPlanTypeTable @PlanType = 'Monthly';

EXEC spInsertDataIntoMembershipPlanTypeTable @PlanType = 'Quarterly';

EXEC spInsertDataIntoMembershipPlanTypeTable @PlanType = 'Half-Yearly';

EXEC spInsertDataIntoMembershipPlanTypeTable @PlanType = 'Yearly';

SELECT *FROM tblMembershipPlanType