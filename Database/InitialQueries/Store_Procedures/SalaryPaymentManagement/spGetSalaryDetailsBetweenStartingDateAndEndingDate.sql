CREATE PROC spGetSalaryDetailsBetweenStartingDateAndEndingDate
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
    e.EmployeeId,
    (e.FirstName 
        + CASE 
            WHEN e.MiddleName IS NULL OR e.MiddleName = '' 
                THEN '' 
            ELSE ' ' + e.MiddleName 
        END
        + ' ' + e.LastName) AS FullName,
    e.PhoneNo,
    e.EmailId,
    e.BankAccountNo,
    r.Role AS RoleName,
    s.SalaryId,
    s.Amount AS SalaryAmount,
    sp.PaymentId,
    sp.PaymentMode,
    sp.PaymentMonth,
    sp.PaymentYear,
    sp.PaymentDate,
    sp.PaymentStatus
        FROM tblSalaryPayment sp
        INNER JOIN tblSalary s
            ON sp.SalaryId = s.SalaryId
        INNER JOIN tblEmployee e
            ON s.EmployeeId = e.EmployeeId
        INNER JOIN tblEmployeeRoleType r
            ON e.RoleId = r.RoleId
        WHERE 
            sp.PaymentDate >= @StartDate
            AND sp.PaymentDate < DATEADD(DAY, 1, @EndDate)
        ORDER BY 
            sp.PaymentDate ASC;

    END TRY
    BEGIN CATCH
        SELECT
            ERROR_MESSAGE()   AS Message;
    END CATCH
END
