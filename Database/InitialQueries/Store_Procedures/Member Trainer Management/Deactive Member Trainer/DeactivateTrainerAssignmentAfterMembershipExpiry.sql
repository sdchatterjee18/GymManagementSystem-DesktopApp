CREATE PROC spDeactivateTrainerAssignmentAfterMembershipExpiry
(
    @MemberId INT
)
AS
BEGIN
    SET NOCOUNT ON;
    -- Member exists check
    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMember
        WHERE MemberId = @MemberId
    )
    BEGIN
        RAISERROR('Member does not exist.',16,1);
        RETURN;
    END

    UPDATE tblMemberTrainerAssignment
    SET IsActive = 0
    WHERE MemberId = @MemberId
      AND IsActive = 1
      AND NOT EXISTS
      (
          SELECT 1
          FROM tblMembershipSubscription
          INNER JOIN tblMembershipPlans
              ON tblMembershipSubscription.MembershipPlanId = tblMembershipPlans.MembershipPlanId
          WHERE tblMembershipSubscription.MemberId = @MemberId
            AND tblMembershipSubscription.IsActive = 1
            AND tblMembershipPlans.IsActive = 1
            AND tblMembershipSubscription.ExpiryDate >= CAST(GETDATE() AS DATE)
      );
END
GO