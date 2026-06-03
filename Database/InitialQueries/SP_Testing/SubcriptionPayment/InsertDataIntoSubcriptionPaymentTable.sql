CREATE PROCEDURE spInsertDataIntoSubcriptionPaymentTable
    @MemberId INT,
    @MembershipPlanId INT,
    @PaymentMethod VARCHAR(50),
    @Amount DECIMAL(10,2),
    @FeesType VARCHAR(50),
    @TransactionId VARCHAR(100)
AS
BEGIN
BEGIN TRY
    SET NOCOUNT ON;

    SET @PaymentMethod = LTRIM(RTRIM(@PaymentMethod))
    SET @FeesType      = LTRIM(RTRIM(@FeesType))
    SET @TransactionId = LTRIM(RTRIM(@TransactionId))

    IF @MemberId IS NULL
    BEGIN
        SELECT 'MemberId is required and cannot be NULL.' AS Message;
        RETURN;
    END

    IF @MemberId <= 0
    BEGIN
        SELECT 'MemberId must be a positive integer.' AS Message;
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM tblMember WHERE MemberId = @MemberId)
    BEGIN
        SELECT 'MemberId does not exist in the Member table.' AS Message;
        RETURN;
    END

    IF @MembershipPlanId IS NULL
    BEGIN
        SELECT 'MembershipPlanId is required and cannot be NULL.' AS Message;
        RETURN;
    END

    IF @MembershipPlanId <= 0
    BEGIN
        SELECT 'MembershipPlanId must be a positive integer.' AS Message;
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM tblMembershipPlans WHERE MembershipPlanId = @MembershipPlanId)
    BEGIN
        SELECT 'MembershipPlanId does not exist in the MembershipPlan table.' AS Message;
        RETURN;
    END


    IF @PaymentMethod IS NULL OR @PaymentMethod = ''
    BEGIN
        SELECT 'PaymentMethod is required and cannot be NULL or empty.' AS Message;
        RETURN;
    END

    IF LEN(@PaymentMethod) > 50
    BEGIN
        SELECT 'PaymentMethod cannot exceed 50 characters.' AS Message;
        RETURN;
    END

    IF @PaymentMethod NOT IN ('Credit Card', 'Debit Card', 'Cash', 'Bank Transfer', 'Online', 'Cheque')
    BEGIN
        SELECT 'PaymentMethod must be one of: Credit Card, Debit Card, Cash, Bank Transfer, Online, Cheque.' AS Message;
        RETURN;
    END

    IF @Amount IS NULL
    BEGIN
        SELECT 'Amount is required and cannot be NULL.' AS Message;
        RETURN;
    END

    IF @Amount < 0
    BEGIN
        SELECT 'Amount must be greater than or equal to 0.' AS Message;
        RETURN;
    END

    IF @Amount > 99999999.99
    BEGIN
        SELECT 'Amount exceeds the maximum allowed value of 99,999,999.99.' AS Message;
        RETURN;
    END

    IF @FeesType IS NULL OR @FeesType = ''
    BEGIN
        SELECT 'FeesType is required and cannot be NULL or empty.' AS Message;
        RETURN;
    END

    IF LEN(@FeesType) > 50
    BEGIN
        SELECT 'FeesType cannot exceed 50 characters.' AS Message;
        RETURN;
    END

    IF @FeesType NOT IN ('Monthly', 'Quarterly', 'Half-Yearly', 'Yearly')
    BEGIN
        SELECT 'FeesType must be one of: Monthly, Quarterly, Half-Yearly, Yearly.' AS Message;
        RETURN;
    END

    
    IF @TransactionId IS NULL OR @TransactionId = ''
    BEGIN
        SELECT 'TransactionId is required and cannot be NULL or empty.' AS Message;
        RETURN;
    END

    IF LEN(@TransactionId) > 100
    BEGIN
        SELECT 'TransactionId cannot exceed 100 characters.' AS Message;
        RETURN;
    END

    IF EXISTS (SELECT 1 FROM tblSubcriptionPayment WHERE TransactionId = @TransactionId)
    BEGIN
        SELECT 'TransactionId already exists. Duplicate transactions are not allowed.' AS Message;
        RETURN;
    END

    INSERT INTO tblSubcriptionPayment
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

    SELECT  'Payment record inserted successfully.' AS Message
END TRY
BEGIN CATCH
    SELECT
        ERROR_MESSAGE() AS Message,
        ERROR_LINE() AS ErrorLine,
        ERROR_PROCEDURE() AS ProcedureName
END CATCH
END
GO