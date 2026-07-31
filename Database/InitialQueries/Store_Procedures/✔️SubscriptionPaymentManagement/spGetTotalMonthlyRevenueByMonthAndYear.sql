CREATE PROC spGetTotalMonthlyRevenueByMonthAndYear
    @MonthName VARCHAR(20),
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

    SET @MonthName = LOWER(@MonthName)
    IF @MonthName IS NULL OR @MonthName NOT IN ('january','february','march','april','may','june','july','august','september','october','november','december')
    BEGIN
       SELECT 
        'Invalid month name. Please provide a valid full month name (e.g., January, February).' AS Message
       RETURN; 
    END

    SELECT 
        SUM(sp.Amount) AS TotalRevenueThisMonth
    FROM tblSubscriptionPayment sp
    JOIN tblMembershipPlans mp 
        ON sp.MembershipPlanId = mp.MembershipPlanId
    JOIN tblMember m 
        ON sp.MemberId = m.MemberId
    WHERE 
        LOWER(FORMAT(sp.PaymentDate, 'MMMM')) = @MonthName AND FORMAT(sp.PaymentDate, 'yyyy') = CAST(@Year AS VARCHAR(4))
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message
    END CATCH
END