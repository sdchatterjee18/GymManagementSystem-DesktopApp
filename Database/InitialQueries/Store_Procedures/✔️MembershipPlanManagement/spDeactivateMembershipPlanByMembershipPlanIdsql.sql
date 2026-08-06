CREATE PROC spDeactivateMembershipPlanByMembershipPlanId
(
    @MembershipPlanId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        
        IF NOT EXISTS (SELECT 1 FROM tblMembershipPlans WHERE MembershipPlanId = @MembershipPlanId)
        BEGIN
            SELECT 'MembershipPlanId not found.' AS Message
            RETURN;
        END

        IF EXISTS (SELECT 1 FROM tblMembershipPlans WHERE MembershipPlanId = @MembershipPlanId AND IsActive = 0)
        BEGIN
            SELECT 'This membership plan is already inactive.' AS Message
            RETURN;
        END

        UPDATE tblMembershipPlans
        SET IsActive = 0
        WHERE MembershipPlanId = @MembershipPlanId;

    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message
    END CATCH
END