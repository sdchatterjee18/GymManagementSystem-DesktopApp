CREATE PROCEDURE spRetrieveMembershipPlans
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        mp.MembershipPlanId,
        mp.MembershipPlanName,
        mpt.PlanType,
        mp.DurationInDays,
        mp.Price,
        mp.Description,
        CASE
            WHEN mp.IsActive = 1 THEN 'Active'
            ELSE 'Inactive'
        END IsActive
    FROM tblMembershipPlans mp
    INNER JOIN tblMembershipPlanType mpt
        ON mp.PlanTypeId = mpt.PlanTypeId;
END;
GO