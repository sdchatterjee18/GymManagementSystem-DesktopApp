

CREATE PROC spInsertDataIntoMembershipSubscriptionTable
(
    @MemberId INT,
    @MembershipPlanId INT,
    @StartDate DATE,
    @ExpiryDate DATE
)
AS
BEGIN
BEGIN TRY

    IF @MemberId IS NULL
    BEGIN
        SELECT 'Member Id is Required.' AS Message
        RETURN
    END

    IF @MembershipPlanId IS NULL
    BEGIN
        SELECT 'Membership Plan Id is Required.' AS Message
        RETURN
    END

    IF @StartDate IS NULL
    BEGIN
        SELECT 'Start Date is Required.' AS Message
        RETURN
    END

    IF @ExpiryDate IS NULL
    BEGIN
        SELECT 'Expiry Date is Required.' AS Message
        RETURN
    END

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMember
        WHERE MemberId = @MemberId
    )
    BEGIN
        SELECT 'Invalid Member Id.' AS Message
        RETURN
    END

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMember
        WHERE MemberId = @MemberId
          AND IsActive = 1
    )
    BEGIN
        SELECT 'Member Is Not Active.' AS Message
        RETURN
    END

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMembershipPlans
        WHERE MembershipPlanId = @MembershipPlanId
    )
    BEGIN
        SELECT 'Invalid Membership Plan Id.' AS Message
        RETURN
    END

 

    IF @StartDate > @ExpiryDate
    BEGIN
        SELECT 'Expiry Date Must Be Greater Than Start Date.' AS Message
        RETURN
    END

    IF @StartDate < CAST(GETDATE() AS DATE)
    BEGIN
        SELECT 'Start Date Cannot Be In The Past.' AS Message
        RETURN
    END



    IF EXISTS
    (
        SELECT 1
        FROM tblMembershipSubscription
        WHERE MemberId = @MemberId
          AND IsActive = 1
          AND ExpiryDate >= CAST(GETDATE() AS DATE)
    )
    BEGIN
        SELECT 'Member Already Has An Active Subscription.' AS Message
        RETURN
    END



    INSERT INTO tblMembershipSubscription
    (
        MemberId,
        MembershipPlanId,
        StartDate,
        ExpiryDate
    )
    VALUES
    (
        @MemberId,
        @MembershipPlanId,
        @StartDate,
        @ExpiryDate
    )

    SELECT 'Membership Subscription Added Successfully.' AS Message

END TRY

BEGIN CATCH

    SELECT
        ERROR_MESSAGE() AS Message,
        ERROR_LINE() AS ErrorLine,
        ERROR_PROCEDURE() AS ProcedureName

END CATCH
END
GO