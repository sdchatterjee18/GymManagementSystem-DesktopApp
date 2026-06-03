CREATE PROC spInsertDataIntoSalaryPaymentTable
(
    @SalaryId INT,
    @PaymentMode VARCHAR(50),
    @PaymentMonth VARCHAR(10),
    @PaymentYear INT,
    @PaymentStatus VARCHAR(50)
)
AS
BEGIN
BEGIN TRY

    SET @PaymentMode = LTRIM(RTRIM(@PaymentMode))
    SET @PaymentMonth = LTRIM(RTRIM(@PaymentMonth))
    SET @PaymentStatus = LTRIM(RTRIM(@PaymentStatus))
    IF @SalaryId IS NULL OR @SalaryId=''
    BEGIN
        SELECT 'Salary Id is Required.' AS Message
        RETURN
    END
    IF @PaymentMode IS NULL OR @PaymentMode = ''
    BEGIN
        SELECT 'Payment Mode is Required.' AS Message
        RETURN
    END
    IF @PaymentMonth IS NULL OR @PaymentMonth = ''
    BEGIN
        SELECT 'Payment Month is Required.' AS Message
        RETURN
    END
    IF @PaymentYear IS NULL OR @PaymentYear=''
    BEGIN
        SELECT 'Payment Year is Required.' AS Message
        RETURN
    END
    IF @PaymentStatus IS NULL OR @PaymentStatus = ''
    BEGIN
        SELECT 'Payment Status is Required.' AS Message
        RETURN
    END
    IF NOT EXISTS
    (
        SELECT 1
        FROM tblSalary
        WHERE SalaryId = @SalaryId
    )
    BEGIN
        SELECT 'Invalid Salary Id.' AS Message
        RETURN
    END
    IF @PaymentYear < 2000
       OR @PaymentYear > YEAR(GETDATE()) + 1
    BEGIN
        SELECT 'Invalid Payment Year.' AS Message
        RETURN
    END
    IF @PaymentMonth NOT IN
    (
        'January','February','March','April',
        'May','June','July','August',
        'September','October','November','December'
    )
    BEGIN
        SELECT 'Invalid Payment Month.' AS Message
        RETURN
    END
    IF EXISTS
    (
        SELECT 1
        FROM tblSalaryPayment
        WHERE SalaryId = @SalaryId
          AND PaymentMonth = @PaymentMonth
          AND PaymentYear = @PaymentYear
    )
    BEGIN
        SELECT 'Salary Already Paid For This Month And Year.' AS Message
        RETURN
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
        @PaymentMonth,
        @PaymentYear,
        GETDATE(),
        @PaymentStatus
    )

    SELECT 'Salary Payment Recorded Successfully.' AS Message

END TRY
BEGIN CATCH

    SELECT
        ERROR_MESSAGE() AS Message,
        ERROR_LINE() AS ErrorLine,
        ERROR_PROCEDURE() AS ProcedureName

END CATCH
END
GO