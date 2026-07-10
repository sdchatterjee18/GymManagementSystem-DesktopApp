CREATE PROC spGetTotalSalaryPaidByYear
    @PaymentYear INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        SUM(s.Amount) AS TotalSalaryPaid
    FROM tblSalaryPayment sp
    INNER JOIN tblSalary s
        ON s.SalaryId = sp.SalaryId
    WHERE sp.PaymentYear   = @PaymentYear
      AND sp.PaymentStatus = 'Paid'
    GROUP BY sp.PaymentYear;
END;