CREATE PROC spGetSubscriptionDetailsBetweenStartingDateAndEndingDate
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        IF @StartDate IS NULL OR @EndDate IS NULL
        BEGIN
            SELECT 'Both StartDate and EndDate are required.' AS Message;
            RETURN;
        END

        IF @StartDate > @EndDate
        BEGIN
            SELECT 'StartDate cannot be later than EndDate.' AS Message;
            RETURN;
        END

        SELECT 
            sp.PaymentId,
            sp.MemberId,
            m.FirstName,
            m.LastName,
            sp.MembershipPlanId,
            mp.MembershipPlanName,
            sp.PaymentDate,
            sp.PaymentMethod,
            sp.Amount,
            sp.FeesType
        FROM tblSubscriptionPayment sp
        JOIN tblMembershipPlans mp 
            ON sp.MembershipPlanId = mp.MembershipPlanId
        JOIN tblMember m 
            ON sp.MemberId = m.MemberId
        WHERE 
            sp.PaymentDate BETWEEN @StartDate AND @EndDate;

    END TRY
    BEGIN CATCH
        SELECT 
            ERROR_MESSAGE()   AS Message;
    END CATCH
END