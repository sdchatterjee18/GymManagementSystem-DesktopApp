CREATE PROC spInsertDataIntoMembershipSubscriptionTableWhileReneweal
(
    @MemberId INT,
    @MembershipPlanId INT,
    @PaymentMethod VARCHAR(50)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        BEGIN TRANSACTION;

        DECLARE @DurationInDays INT;
        DECLARE @StartDate DATE;
        DECLARE @ExpiryDate DATE;
        DECLARE @LastExpiryDate DATE;
        DECLARE @Amount DECIMAL(10,2);

        -- Check whether member exists and is active
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMember
            WHERE MemberId = @MemberId
              AND IsActive = 1
        )
        BEGIN
            RAISERROR('Member does not exist or is inactive.',16,1);
        END

        -- Check whether membership plan exists and is active
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMembershipPlans
            WHERE MembershipPlanId = @MembershipPlanId
              AND IsActive = 1
        )
        BEGIN
            RAISERROR('Membership plan does not exist or is inactive.',16,1);
        END

        -- Get plan details
        SELECT
            @DurationInDays = DurationInDays,
            @Amount = Amount
        FROM tblMembershipPlans
        WHERE MembershipPlanId = @MembershipPlanId;

        -- Get last expiry date
        SELECT @LastExpiryDate = MAX(ExpiryDate)
        FROM tblMembershipSubscription
        WHERE MemberId = @MemberId;

        -- Decide start date
        IF @LastExpiryDate IS NOT NULL
           AND @LastExpiryDate >= CAST(GETDATE() AS DATE)
        BEGIN
            SET @StartDate = DATEADD(DAY, 1, @LastExpiryDate);
        END
        ELSE
        BEGIN
            SET @StartDate = CAST(GETDATE() AS DATE);
        END

        -- Calculate expiry date
        SET @ExpiryDate = DATEADD(DAY, @DurationInDays - 1, @StartDate);

        -- Insert membership subscription
        INSERT INTO tblMembershipSubscription
        (
            MemberId,
            MembershipPlanId,
            StartDate,
            ExpiryDate,
            IsActive
        )
        VALUES
        (
            @MemberId,
            @MembershipPlanId,
            @StartDate,
            @ExpiryDate,
            1
        );

        -- Insert payment record
        INSERT INTO tblSubscriptionPayment
        (
            MemberId,
            MembershipPlanId,
            PaymentMethod,
            Amount,
            FeesType
        )
        VALUES
        (
            @MemberId,
            @MembershipPlanId,
            @PaymentMethod,
            @Amount,
            'Renewal'
        );

        COMMIT TRANSACTION;

        SELECT 'Membership renewed successfully.' AS Message;

    END TRY

    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;