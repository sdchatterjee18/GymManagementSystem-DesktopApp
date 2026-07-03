CREATE PROC spUpdateMembershipPlanPriceByMembershipPlanIdAssignNewPrice
(
    @MembershipPlanId INT,
    @NewPrice         DECIMAL(10,2)
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

        IF @NewPrice IS NULL OR @NewPrice <= 0
        BEGIN
            SELECT 'Price cannot be negative or zero.' AS ERROR_MESSAGE
            RETURN;
        END

        IF EXISTS (SELECT 1 FROM tblMembershipPlans WHERE MembershipPlanId = @MembershipPlanId AND Price = @NewPrice)
        BEGIN
            SELECT 'The new price is the same as the current price. No update performed.' AS ERROR_MESSAGE
            RETURN;
        END

        UPDATE tblMembershipPlans
        SET Price = @NewPrice
        WHERE MembershipPlanId = @MembershipPlanId;

    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END