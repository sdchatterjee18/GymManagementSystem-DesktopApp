CREATE PROC spGetTotalSalaryByMonthYear
    @PaymentMonth VARCHAR(10) = NULL,
    @PaymentYear  INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        sp.PaymentMonth,
        sp.PaymentYear,
        COUNT(sp.PaymentId)      AS TotalPayments,
        SUM(s.Amount)         AS TotalSalaryPaid
    FROM tblSalaryPayment sp
    INNER JOIN tblSalary s
        ON s.SalaryId = sp.SalaryId
    WHERE sp.PaymentMonth = @PaymentMonth
      AND sp.PaymentYear  = @PaymentYear
      AND sp.PaymentStatus = 'Paid'
    GROUP BY sp.PaymentMonth, sp.PaymentYear;
END;