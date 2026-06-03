CREATE PROCEDURE spInsertDataIntoSubcriptionPaymentTable
    @MemberId INT,
    @MembershipPlanId INT,
    @PaymentMethod VARCHAR(50),
    @TransactionId VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        DECLARE @Amount DECIMAL(10,2);
        DECLARE @FeesType VARCHAR(50);
        DECLARE @DurationInDays INT;

        SET @PaymentMethod = LTRIM(RTRIM(ISNULL(@PaymentMethod,'')));
        SET @TransactionId = LTRIM(RTRIM(ISNULL(@TransactionId,'')));

        SELECT 
            @Amount = Price,
            @DurationInDays = DurationInDays
        FROM dbo.tblMembershipPlans 
        WHERE MembershipPlanId = @MembershipPlanId;

        SET @FeesType = 
            CASE @DurationInDays
                WHEN 30 THEN 'Monthly'
                WHEN 60 THEN 'Bi-monthly'
                WHEN 90 THEN 'Quarterly'
                WHEN 180 THEN 'Half-Yearly'
                WHEN 365 THEN 'Yearly'
                ELSE 'Custom Plan'
            END;

        IF @MemberId IS NULL OR @MemberId <= 0
        BEGIN
            SELECT 'MemberId is required and must be a positive integer.' AS Message;
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM dbo.tblMember WHERE MemberId = @MemberId)
        BEGIN
            SELECT 'MemberId does not exist in the Member table.' AS Message;
            RETURN;
        END


        INSERT INTO dbo.tblSubscriptionPayment
        (
            MemberId,
            MembershipPlanId,
            PaymentDate,
            PaymentMethod,
            Amount,
            FeesType,
            TransactionId
        )
        VALUES
        (
            @MemberId,
            @MembershipPlanId,
            GETDATE(),
            @PaymentMethod,
            @Amount,
            @FeesType,
            @TransactionId
        );

        SELECT 
            'Payment record inserted successfully.' AS Message
    END TRY
    BEGIN CATCH
        SELECT
            ERROR_MESSAGE() AS Message,
            ERROR_LINE() AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;
    END CATCH
END
GO