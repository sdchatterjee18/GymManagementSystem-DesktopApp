CREATE PROC spCountMembershipPlanAssignmentsForASpecificMonth
(
    @MembershipPlanId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT COUNT(*) AS TotalAssignments
    FROM tblMembershipSubscription
    WHERE MembershipPlanId = @MembershipPlanId;
END;