CREATE PROC spGetAllEmployeeSalaryPaymentDetails
AS
BEGIN
    BEGIN TRY
        SET NOCOUNT ON;

        SELECT 
            e.EmployeeId,
            TRIM(
                e.FirstName + ' ' +
                ISNULL(e.MiddleName + ' ', '') +
                e.LastName
            ) AS FullName,
            ert.Role AS RoleName,
            e.PhoneNo,
            e.EmailId,
            s.Amount AS SalaryAmount,
            sp.PaymentMode,
            sp.PaymentMonth,
            sp.PaymentYear,
            sp.PaymentDate,
            sp.PaymentStatus

        FROM tblEmployee e
        INNER JOIN tblEmployeeRoleType ert
            ON e.RoleId = ert.RoleId
        INNER JOIN tblSalary s
            ON e.EmployeeId = s.EmployeeId
        INNER JOIN tblSalaryPayment sp
            ON s.SalaryId = sp.SalaryId

        ORDER BY e.EmployeeId, sp.PaymentYear, sp.PaymentMonth;

    END TRY
    BEGIN CATCH
        SELECT
            ERROR_MESSAGE() AS Message;
    END CATCH
END;
