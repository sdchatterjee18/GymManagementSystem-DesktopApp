CREATE PROC spCountMembershipPlanAssignmentsByMonth
(
    @MembershipPlanId INT,
    @Month INT,
    @Year INT
)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT COUNT(*) AS TotalAssignments
    FROM tblMembershipSubscription
    WHERE MembershipPlanId = @MembershipPlanId
      AND MONTH(StartDate) = @Month
      AND YEAR(StartDate) = @Year;
END;