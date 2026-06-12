
CREATE PROC spInsertDataIntoMembershipSubscriptionTableWhileReneweal
( 
    @MemberId INT,
    @MembershipPlanId INT
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

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMember
            WHERE MemberId = @MemberId
            AND IsActive = 1
        )
        BEGIN
            RAISERROR('', 16, 1);
            SELECT 'Member does not exist or is inactive.' AS Message
            RETURN
        END

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMembershipPlans
            WHERE MembershipPlanId = @MembershipPlanId
            AND IsActive = 1
        )
        BEGIN
            SELECT 'Membership plan does not exist or is inactive.' AS Message
            RETURN
        END

        SELECT @DurationInDays = DurationInDays
        FROM tblMembershipPlans
        WHERE MembershipPlanId = @MembershipPlanId;

        SELECT @LastExpiryDate = MAX(ExpiryDate)
        FROM tblMembershipSubscription
        WHERE MemberId = @MemberId;

        IF @LastExpiryDate IS NOT NULL AND @LastExpiryDate >= CAST(GETDATE() AS DATE)
        BEGIN
            SET @StartDate = DATEADD(DAY, 1, @LastExpiryDate);
        END
        ELSE
        BEGIN
            SET @StartDate = CAST(GETDATE() AS DATE);
        END

        SET @ExpiryDate = DATEADD(DAY, @DurationInDays - 1, @StartDate);

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

        COMMIT TRANSACTION;

        SELECT 'Membership subscription created successfully.' AS Message

    END TRY

    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT ERROR_MESSAGE() AS Message
    END CATCH
END