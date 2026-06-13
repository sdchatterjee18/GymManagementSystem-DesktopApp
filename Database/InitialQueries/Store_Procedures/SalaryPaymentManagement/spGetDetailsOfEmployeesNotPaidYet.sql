CREATE PROC spGetDetailsOfEmployeesNotPaidYet
AS
BEGIN
    BEGIN TRY
        SET NOCOUNT ON;

        DECLARE @CurrentMonth VARCHAR(20) = DATENAME(MONTH, GETDATE());
        DECLARE @CurrentYear  INT = DATEPART(YEAR,  GETDATE());
        
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
            s.SalaryId,
            s.Amount AS SalaryAmount,
            @CurrentMonth AS CurrentMonth,
            @CurrentYear AS CurrentYear,
            'Not Paid' AS PaymentStatus
        FROM tblEmployee e
        INNER JOIN tblSalary s
            ON e.EmployeeId = s.EmployeeId
        WHERE e.IsActive = 1
          AND NOT EXISTS (
                SELECT 1 
                FROM tblSalaryPayment sp
                WHERE sp.SalaryId = s.SalaryId
                  AND sp.PaymentMonth = @CurrentMonth
                  AND sp.PaymentYear = @CurrentYear
                  AND sp.PaymentStatus = 'Paid'
          )
        ORDER BY e.EmployeeId
    
    END TRY
    BEGIN CATCH
        SELECT
            ERROR_MESSAGE()   AS Message,
            ERROR_LINE()      AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;
    END CATCH
END;