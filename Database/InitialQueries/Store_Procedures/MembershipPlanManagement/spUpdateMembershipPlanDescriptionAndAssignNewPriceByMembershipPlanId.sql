CREATE PROC spUpdateMembershipPlanDescriptionAndAssignNewPriceByMembershipPlanId
(
    @MembershipPlanId INT,
    @Description      VARCHAR(MAX)  = NULL,
    @NewPrice         DECIMAL(10,2) = NULL
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

        IF @Description IS NULL AND @NewPrice IS NULL
        BEGIN
            SELECT 'No values supplied. Provide a Description and/or a NewPrice to update.' AS ERROR_MESSAGE
            RETURN;
        END


        IF @NewPrice IS NOT NULL AND @NewPrice <= 0
        BEGIN
            SELECT 'Price cannot be negative or zero.' AS ERROR_MESSAGE
            RETURN;
        END

        DECLARE @CurrentDescription VARCHAR(MAX);
        DECLARE @CurrentPrice       DECIMAL(10,2);

        SELECT
            @CurrentDescription = Description,
            @CurrentPrice       = Price
        FROM tblMembershipPlans
        WHERE MembershipPlanId = @MembershipPlanId;

        DECLARE @DescriptionChanged BIT = CASE
            WHEN @Description IS NOT NULL AND @Description <> @CurrentDescription THEN 1
            ELSE 0
        END;

        DECLARE @PriceChanged BIT = CASE
            WHEN @NewPrice IS NOT NULL AND @NewPrice <> @CurrentPrice THEN 1
            ELSE 0
        END;

        IF @DescriptionChanged = 0 AND @PriceChanged = 0
        BEGIN
            SELECT 'The supplied value(s) match the current record. No update performed.' AS ERROR_MESSAGE
            RETURN;
        END

        UPDATE tblMembershipPlans
        SET
            Description = CASE WHEN @DescriptionChanged = 1 THEN @Description ELSE Description END,
            Price       = CASE WHEN @PriceChanged = 1 THEN @NewPrice ELSE Price END
        WHERE MembershipPlanId = @MembershipPlanId;

        SELECT
            CASE
                WHEN @DescriptionChanged = 1 AND @PriceChanged = 1 THEN 'Membership Plan Description and Price Updated Successfully.'
                WHEN @DescriptionChanged = 1 THEN 'Membership Plan Description Updated Successfully.'
                WHEN @PriceChanged = 1 THEN 'Membership Plan Price Updated Successfully.'
            END AS Message;

    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
       
        SELECT @ErrorMessage AS ErrorMessage
    END CATCH
END