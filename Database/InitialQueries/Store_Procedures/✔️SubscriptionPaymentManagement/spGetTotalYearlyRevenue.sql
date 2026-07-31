CREATE PROC spGetTotalYearlyRevenue
    @Year INT
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        IF @Year IS NULL OR @Year < 1900 OR @Year > YEAR(GETDATE())
            BEGIN
                SELECT 
                    'Invalid year. Please provide a valid year (1900 - current year).' AS Message
                RETURN;
            END

        SELECT 
            SUM(sp.Amount) AS YearlyRevenue
        FROM tblSubscriptionPayment sp
        JOIN tblMembershipPlans mp 
            ON sp.MembershipPlanId = mp.MembershipPlanId
        JOIN tblMember m 
            ON sp.MemberId = m.MemberId
        WHERE 
           FORMAT(sp.PaymentDate, 'yyyy') = CAST(@Year AS VARCHAR(4))
    END TRY
    BEGIN CATCH
       SELECT ERROR_MESSAGE() AS Message
    END CATCH
END