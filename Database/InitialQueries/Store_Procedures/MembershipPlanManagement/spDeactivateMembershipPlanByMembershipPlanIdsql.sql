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
            SELECT 'MembershipPlanId not found.' AS ERROR_MESSAGE
            RETURN;
        END

        IF EXISTS (SELECT 1 FROM tblMembershipPlans WHERE MembershipPlanId = @MembershipPlanId AND IsActive = 0)
        BEGIN
            SELECT 'This membership plan is already inactive.' AS ERROR_MESSAGE
            RETURN;
        END

        UPDATE tblMembershipPlans
        SET IsActive = 0
        WHERE MembershipPlanId = @MembershipPlanId;

    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END