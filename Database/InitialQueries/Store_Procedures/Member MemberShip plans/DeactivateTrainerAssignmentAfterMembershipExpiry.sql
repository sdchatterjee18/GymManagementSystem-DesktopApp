CREATE PROC spDeactivateTrainerAssignmentAfterMembershipExpiry
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE tblMemberTrainerAssignment
    SET IsActive = 0
    FROM tblMemberTrainerAssignment
    INNER JOIN tblMembershipSubscription
        ON tblMemberTrainerAssignment.MemberId = tblMembershipSubscription.MemberId
    WHERE tblMemberTrainerAssignment.IsActive = 1
      AND tblMembershipSubscription.ExpiryDate < CAST(GETDATE() AS DATE);
END
GO