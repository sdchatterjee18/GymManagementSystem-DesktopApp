CREATE PROC spUpdateMembershipPlanDescriptionByMembershipPlanId
(
    @MembershipPlanId INT,
    @Description      VARCHAR(MAX)
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

        IF EXISTS (
            SELECT 1 FROM tblMembershipPlans 
            WHERE MembershipPlanId = @MembershipPlanId 
              AND Description = @Description
        )
        BEGIN
            SELECT 'The new description is the same as the current description. No update performed.' AS ERROR_MESSAGE
            RETURN;
        END

        UPDATE tblMembershipPlans
        SET Description = @Description
        WHERE MembershipPlanId = @MembershipPlanId;

        SELECT 'Membership Plan Description Updated Successfully.' AS Message;

    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END