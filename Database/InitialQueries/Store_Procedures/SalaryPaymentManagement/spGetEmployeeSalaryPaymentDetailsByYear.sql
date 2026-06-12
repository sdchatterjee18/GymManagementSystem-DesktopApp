CREATE PROC spGetEmployeeSalaryPaymentDetailsByYear
    @PaymentYear INT = NULL
AS
BEGIN
    BEGIN TRY
        SET NOCOUNT ON;

        IF @PaymentYear IS NULL
        BEGIN
            SELECT 0 AS StatusCode, 'PaymentYear is required' AS Message;
            RETURN;
        END
        
        IF @PaymentYear < 2000 OR @PaymentYear > DATEPART(YEAR, GETDATE())
        BEGIN
            SELECT 
                0 AS StatusCode, 
                'Invalid PaymentYear. Year must be between 2000 and ' + 
                CAST(DATEPART(YEAR, GETDATE()) AS VARCHAR) AS Message;
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM tblSalaryPayment WHERE PaymentYear = @PaymentYear)
        BEGIN
            SELECT 
                0 AS StatusCode, 
                'No payment records found for year ' + 
                CAST(@PaymentYear AS VARCHAR) AS Message;
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
        WHERE sp.PaymentYear = @PaymentYear
        ORDER BY e.EmployeeId, sp.PaymentMonth;

    END TRY
    BEGIN CATCH
        SELECT
            ERROR_MESSAGE()   AS Message,
            ERROR_LINE()      AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;
    END CATCH
END;