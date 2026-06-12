CREATE PROC spGetEmployeeSalaryPaymentDetailsByMonth
    @PaymentMonth VARCHAR(20) = NULL
AS
BEGIN
    BEGIN TRY
        SET NOCOUNT ON;

        IF @PaymentMonth IS NULL OR LTRIM(RTRIM(@PaymentMonth)) = ''
        BEGIN
            SELECT 
                0 AS StatusCode, 
                'PaymentMonth is required' AS Message;
            RETURN;
        END

        IF @PaymentMonth NOT IN ( 'January', 'February', 'March',     'April', 'May',     'June',     'July',       'August','September','October', 'November',   'December')
        BEGIN
            SELECT 
                0 AS StatusCode, 
                'Invalid PaymentMonth. Allowed values are: January, February, March, April, May, June, July, August, September, October, November, December' AS Message;
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM tblSalaryPayment WHERE PaymentMonth = @PaymentMonth)
        BEGIN
            SELECT 
                0 AS StatusCode, 
                'No payment records found for ' + @PaymentMonth AS Message;
            RETURN;
        END

        SELECT
            e.EmployeeId,
            TRIM(
                e.FirstName + ' ' +
                ISNULL(e.MiddleName + ' ', '') +
                e.LastName
            ) AS FullName,
            e.RoleName,
            e.PhoneNo,
            e.EmailId,
            s.Amount AS SalaryAmount,
            sp.PaymentMode,
            sp.PaymentMonth,
            sp.PaymentYear,
            sp.PaymentDate,
            sp.PaymentStatus

        FROM tblEmployee e
        INNER JOIN tblSalary s
            ON e.EmployeeId = s.EmployeeId
        INNER JOIN tblSalaryPayment sp
            ON s.SalaryId = sp.SalaryId
        WHERE sp.PaymentMonth = @PaymentMonth
        ORDER BY e.EmployeeId;

    END TRY
    BEGIN CATCH
        SELECT
            ERROR_MESSAGE()   AS Message,
            ERROR_LINE()      AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;
    END CATCH
END;