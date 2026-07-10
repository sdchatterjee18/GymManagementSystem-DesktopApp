CREATE PROC spGetTotalSalaryAmountPaidBetweenStaringDateAndEndingDate
    @StartDate DATE,
    @EndDate   DATE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        IF @StartDate IS NULL OR @EndDate IS NULL
        BEGIN
            SELECT 'Both StartDate and EndDate are required.' AS Message
            RETURN;
        END
        
        IF @StartDate > @EndDate
        BEGIN
            SELECT 'StartDate cannot be later than EndDate.' AS Message;
            RETURN;
        END

        SELECT
            SUM(s.Amount)       AS GrandTotalAmountPaid
        FROM tblSalaryPayment sp
        INNER JOIN tblSalary s
            ON sp.SalaryId = s.SalaryId
        WHERE 
            sp.PaymentDate >= @StartDate
            AND sp.PaymentDate < DATEADD(DAY, 1, @EndDate)
            AND sp.PaymentStatus = 'Paid';

    END TRY
    BEGIN CATCH
        SELECT 
            ERROR_MESSAGE() AS Message
    END CATCH
END