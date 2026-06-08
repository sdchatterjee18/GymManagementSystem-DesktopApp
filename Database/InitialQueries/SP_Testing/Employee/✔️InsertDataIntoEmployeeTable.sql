CREATE PROC spInsertDataIntoEmployeeTable
(
    @FirstName VARCHAR(150),
    @MiddleName VARCHAR(50) = NULL,
    @LastName VARCHAR(50),
    @GenderId INT,
    @PhoneNo VARCHAR(20),
    @EmailId VARCHAR(150),
    @RoleId INT,
    @BankAccountNo VARCHAR(50)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @FirstName = LTRIM(RTRIM(@FirstName));
        SET @LastName = LTRIM(RTRIM(@LastName));
        SET @PhoneNo = LTRIM(RTRIM(@PhoneNo));
        SET @EmailId = LTRIM(RTRIM(@EmailId));
        SET @BankAccountNo = LTRIM(RTRIM(@BankAccountNo));

        IF @MiddleName IS NOT NULL
            SET @MiddleName = LTRIM(RTRIM(@MiddleName));

        IF @MiddleName = ''
            SET @MiddleName = NULL;

        IF @FirstName IS NULL OR @FirstName = ''
        BEGIN
            SELECT 0 AS StatusCode, 'First Name is Required.' AS Message;
            RETURN;
        END

        IF @LastName IS NULL OR @LastName = ''
        BEGIN
            SELECT 0 AS StatusCode, 'Last Name is Required.' AS Message;
            RETURN;
        END

        IF @GenderId IS NULL
        BEGIN
            SELECT 0 AS StatusCode, 'Gender is Required.' AS Message;
            RETURN;
        END

        IF @PhoneNo IS NULL OR @PhoneNo = ''
        BEGIN
            SELECT 0 AS StatusCode, 'Phone Number is Required.' AS Message;
            RETURN;
        END

        IF @EmailId IS NULL OR @EmailId = ''
        BEGIN
            SELECT 0 AS StatusCode, 'Email Id is Required.' AS Message;
            RETURN;
        END

        IF @RoleId IS NULL
        BEGIN
            SELECT 0 AS StatusCode, 'Role Id is Required.' AS Message;
            RETURN;
        END

        IF @BankAccountNo IS NULL OR @BankAccountNo = ''
        BEGIN
            SELECT 0 AS StatusCode, 'Bank Account Number is Required.' AS Message;
            RETURN;
        END

        IF @FirstName LIKE '%[^A-Za-z]%'
        BEGIN
            SELECT 0 AS StatusCode, 'First Name Must Contain Only Letters.' AS Message;
            RETURN;
        END

        IF @MiddleName IS NOT NULL
           AND @MiddleName LIKE '%[^A-Za-z]%'
        BEGIN
            SELECT 0 AS StatusCode, 'Middle Name Must Contain Only Letters.' AS Message;
            RETURN;
        END

        IF @LastName LIKE '%[^A-Za-z]%'
        BEGIN
            SELECT 0 AS StatusCode, 'Last Name Must Contain Only Letters.' AS Message;
            RETURN;
        END

        IF @PhoneNo LIKE '%[^0-9]%'
        BEGIN
            SELECT 0 AS StatusCode, 'Phone Number Must Contain Only Digits.' AS Message;
            RETURN;
        END

        IF LEN(@PhoneNo) <> 10
        BEGIN
            SELECT 0 AS StatusCode, 'Phone Number Must Be 10 Digits.' AS Message;
            RETURN;
        END

        IF @PhoneNo NOT LIKE '[6-9]%'
        BEGIN
            SELECT 0 AS StatusCode, 'Invalid Indian Mobile Number.' AS Message;
            RETURN;
        END

        IF @EmailId NOT LIKE '%_@_%._%'
           OR @EmailId LIKE '% %'
        BEGIN
            SELECT 0 AS StatusCode, 'Invalid Email Format.' AS Message;
            RETURN;
        END

        IF @EmailId LIKE '%@%@%'
        BEGIN
            SELECT 0 AS StatusCode, 'Email Cannot Contain Multiple @ Symbols.' AS Message;
            RETURN;
        END

        IF @EmailId LIKE '%..%'
        BEGIN
            SELECT 0 AS StatusCode, 'Email Cannot Contain Consecutive Dots.' AS Message;
            RETURN;
        END

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblGender
            WHERE GenderId = @GenderId
        )
        BEGIN
            SELECT 0 AS StatusCode, 'Invalid Gender Id.' AS Message;
            RETURN;
        END

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblEmployeeRoleType
            WHERE RoleId = @RoleId
        )
        BEGIN
            SELECT 0 AS StatusCode, 'Invalid Role Id.' AS Message;
            RETURN;
        END

        IF EXISTS
        (
            SELECT 1
            FROM tblEmployee
            WHERE PhoneNo = @PhoneNo
        )
        BEGIN
            SELECT 0 AS StatusCode, 'Phone Number Already Exists.' AS Message;
            RETURN;
        END

        IF EXISTS
        (
            SELECT 1
            FROM tblEmployee
            WHERE LOWER(EmailId) = LOWER(@EmailId)
        )
        BEGIN
            SELECT 0 AS StatusCode, 'Email Id Already Exists.' AS Message;
            RETURN;
        END

        IF EXISTS
        (
            SELECT 1
            FROM tblEmployee
            WHERE BankAccountNo = @BankAccountNo
        )
        BEGIN
            SELECT 0 AS StatusCode, 'Bank Account Number Already Exists.' AS Message;
            RETURN;
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
            RoleId,
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
            @RoleId,
            @BankAccountNo
        );

        SELECT
            1 AS StatusCode,
            'Employee Inserted Successfully.' AS Message;

    END TRY
    BEGIN CATCH

        SELECT
            0 AS StatusCode,
            ERROR_MESSAGE() AS Message,
            ERROR_LINE() AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;

    END CATCH
END
GO