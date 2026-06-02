CREATE PROC spInsertDataIntoEmployeeTable
(
    @FirstName VARCHAR(150),
    @MiddleName VARCHAR(50) = NULL,
    @LastName VARCHAR(50),
    @GenderId INT,
    @PhoneNo VARCHAR(20),
    @EmailId VARCHAR(150),
    @RoleName VARCHAR(100),
    @BankAccountNo VARCHAR(50)
)
AS
BEGIN
BEGIN TRY
    SET @FirstName = LTRIM(RTRIM(@FirstName))
    SET @LastName = LTRIM(RTRIM(@LastName))
    SET @PhoneNo = LTRIM(RTRIM(@PhoneNo))
    SET @EmailId = LTRIM(RTRIM(@EmailId))
    SET @RoleName = LTRIM(RTRIM(@RoleName))
    SET @BankAccountNo = LTRIM(RTRIM(@BankAccountNo))

    IF @MiddleName IS NOT NULL
        SET @MiddleName = LTRIM(RTRIM(@MiddleName))

    IF @MiddleName = ''
        SET @MiddleName = NULL
    IF @FirstName IS NULL OR @FirstName = ''
    BEGIN
        SELECT 'First Name is Required.' AS Message
        RETURN
    END
    IF @LastName IS NULL OR @LastName = ''
    BEGIN
        SELECT 'Last Name is Required.' AS Message
        RETURN
    END
    IF @GenderId IS NULL
    BEGIN
        SELECT 'Gender is Required.' AS Message
        RETURN
    END
    IF @PhoneNo IS NULL OR @PhoneNo = ''
    BEGIN
        SELECT 'Phone Number is Required.' AS Message
        RETURN
    END
    IF @EmailId IS NULL OR @EmailId = ''
    BEGIN
        SELECT 'Email Id is Required.' AS Message
        RETURN
    END
    IF @RoleName IS NULL OR @RoleName = ''
    BEGIN
        SELECT 'Role Name is Required.' AS Message
        RETURN
    END
    IF @BankAccountNo IS NULL OR @BankAccountNo = ''
    BEGIN
        SELECT 'Bank Account Number is Required.' AS Message
        RETURN
    END
    IF @FirstName LIKE '%[^A-Za-z]%'
    BEGIN
        SELECT 'First Name Must Contain Only Letters.' AS Message
        RETURN
    END

    IF @MiddleName IS NOT NULL
       AND @MiddleName LIKE '%[^A-Za-z]%'
    BEGIN
        SELECT 'Middle Name Must Contain Only Letters.' AS Message
        RETURN
    END
    IF @LastName LIKE '%[^A-Za-z]%'
    BEGIN
        SELECT 'Last Name Must Contain Only Letters.' AS Message
        RETURN
    END
    IF @PhoneNo LIKE '%[^0-9]%'
    BEGIN
        SELECT 'Phone Number Must Contain Only Digits.' AS Message
        RETURN
    END
    IF LEN(@PhoneNo) <> 10
    BEGIN
        SELECT 'Phone Number Must Be 10 Digits.' AS Message
        RETURN
    END
    IF @PhoneNo NOT LIKE '[6-9]%'
    BEGIN
        SELECT 'Invalid Indian Mobile Number.' AS Message
        RETURN
    END
    IF @EmailId NOT LIKE '%_@_%._%'
       OR @EmailId LIKE '% %'
    BEGIN
        SELECT 'Invalid Email Format.' AS Message
        RETURN
    END
    IF @EmailId LIKE '%@%@%'
    BEGIN
        SELECT 'Email Cannot Contain Multiple @ Symbols.' AS Message
        RETURN
    END
    IF @EmailId LIKE '%..%'
    BEGIN
        SELECT 'Email Cannot Contain Consecutive Dots.' AS Message
        RETURN
    END
    IF NOT EXISTS
    (
        SELECT 1
        FROM tblGender
        WHERE GenderId = @GenderId
    )
    BEGIN
        SELECT 'Invalid Gender Id.' AS Message
        RETURN
    END
    IF EXISTS
    (
        SELECT 1
        FROM tblEmployee
        WHERE PhoneNo = @PhoneNo
    )
    BEGIN
        SELECT 'Phone Number Already Exists.' AS Message
        RETURN
    END
    IF EXISTS
    (
        SELECT 1
        FROM tblEmployee
        WHERE LOWER(EmailId) = LOWER(@EmailId)
    )
    BEGIN
        SELECT 'Email Id Already Exists.' AS Message
        RETURN
    END
    IF EXISTS
    (
        SELECT 1
        FROM tblEmployee
        WHERE BankAccountNo = @BankAccountNo
    )
    BEGIN
        SELECT 'Bank Account Number Already Exists.' AS Message
        RETURN
    END
    INSERT INTO tblEmployee
    (
        FirstName,
        MiddleName,
        LastName,
        GenderId,
        PhoneNo,
        EmailId,
        JoiningDate,
        IsActive,
        RoleName,
        BankAccountNo
    )
    VALUES
    (
        @FirstName,
        @MiddleName,
        @LastName,
        @GenderId,
        @PhoneNo,
        @EmailId,
        GETDATE(),
        1,
        @RoleName,
        @BankAccountNo
    )
    SELECT 'Employee Inserted Successfully.' AS Message
END TRY
BEGIN CATCH
    SELECT
        ERROR_MESSAGE() AS Message,
        ERROR_LINE() AS ErrorLine,
        ERROR_PROCEDURE() AS ProcedureName
END CATCH
END
GO