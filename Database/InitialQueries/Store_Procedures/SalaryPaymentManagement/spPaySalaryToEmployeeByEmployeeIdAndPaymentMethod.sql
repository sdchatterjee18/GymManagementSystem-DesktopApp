CREATE OR ALTER PROC spPaySalaryToEmployeeByEmployeeIdAndPaymentMethod
    @EmployeeId INT = NULL,
    @PaymentMode VARCHAR(50) = NULL
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

        IF @PaymentMode IS NULL OR LTRIM(RTRIM(@PaymentMode)) = ''
        BEGIN
            SELECT 
                0 AS StatusCode, 
                'PaymentMode is required' AS Message;
            RETURN;
        END

        IF @PaymentMode NOT IN ('Cash', 'Bank Transfer', 'UPI','Cheque')
        BEGIN
            SELECT 
                0 AS StatusCode, 
                'Invalid PaymentMode. Allowed values are: Cash, Net Banking, UPI' AS Message;
            RETURN;
        END

        DECLARE @CurrentDate DATETIME = GETDATE();
        DECLARE @Month VARCHAR(20) = DATENAME(MONTH, @CurrentDate);
        DECLARE @Year INT = DATEPART(YEAR,  @CurrentDate);
        DECLARE @PaymentStatus VARCHAR(12) = 'Paid';
        DECLARE @SalaryId INT = (SELECT SalaryId FROM tblSalary WHERE EmployeeId = @EmployeeId);

        IF @SalaryId IS NULL
        BEGIN
            SELECT -1 AS StatusCode, 'No salary record found for this employee' AS Message;
            RETURN;
        END

        IF EXISTS (
            SELECT 1 FROM tblSalaryPayment
            WHERE SalaryId = @SalaryId
              AND PaymentMonth = @Month
              AND PaymentYear = @Year
              AND PaymentStatus = @PaymentStatus
        )
        BEGIN
            SELECT 
                -1 AS StatusCode, 
                'Salary already paid for this month' AS Message;
            RETURN;
        END

        INSERT INTO tblSalaryPayment
        (
            SalaryId, 
            PaymentMode, 
            PaymentMonth, 
            PaymentYear,
            PaymentDate,
            PaymentStatus
        )
        VALUES
        (
            @SalaryId, 
            @PaymentMode, 
            @Month, 
            @Year, 
            @CurrentDate, 
            @PaymentStatus
        );

        SELECT 
            1 AS StatusCode, 
            'Payment recorded successfully' AS Message;

    END TRY
    BEGIN CATCH
        SELECT
            ERROR_MESSAGE()   AS Message,
            ERROR_LINE()      AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;
    END CATCH
END;