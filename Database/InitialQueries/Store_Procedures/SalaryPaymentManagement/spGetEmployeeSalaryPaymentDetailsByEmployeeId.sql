CREATE PROC spGetEmployeeSalaryPaymentDetailsByEmployeeId
    @EmployeeId INT = NULL
AS
BEGIN
    BEGIN TRY
        SET NOCOUNT ON;

        IF @EmployeeId IS NULL
        BEGIN
            SELECT 
                0 AS StatusCode, 
                'EmployeeId is required' AS Message;
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM tblEmployee WHERE EmployeeId = @EmployeeId)
        BEGIN
            SELECT 
                0 AS StatusCode, 
                'EmployeeId does not exist' AS Message;
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
        WHERE e.EmployeeId = @EmployeeId
        ORDER BY sp.PaymentYear, sp.PaymentMonth;

    END TRY
    BEGIN CATCH
        SELECT
            ERROR_MESSAGE()   AS Message,
            ERROR_LINE()      AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;
    END CATCH
END;