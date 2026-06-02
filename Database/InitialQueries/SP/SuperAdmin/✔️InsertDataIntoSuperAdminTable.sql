CREATE PROC spInsertDataIntoSuperAdminTable
(
    @UserName VARCHAR(100),
    @PasswordHash VARCHAR(255),
    @EmailId VARCHAR(150),
    @PhoneNumber VARCHAR(20)
)
AS
BEGIN
BEGIN TRY
    SET @UserName = LTRIM(RTRIM(@UserName));
    SET @PasswordHash = LTRIM(RTRIM(@PasswordHash));
    SET @EmailId = LTRIM(RTRIM(@EmailId));
    SET @PhoneNumber = LTRIM(RTRIM(@PhoneNumber));
    IF @UserName IS NULL OR @UserName = ''
    BEGIN
        SELECT 'User Name is Required.' AS Message;
        RETURN;
    END
    IF @PasswordHash IS NULL OR @PasswordHash = ''
    BEGIN
        SELECT 'Password is Required.' AS Message;
        RETURN;
    END
    IF @EmailId IS NULL OR @EmailId = ''
    BEGIN
        SELECT 'Email is Required.' AS Message;
        RETURN;
    END
    IF @PhoneNumber IS NULL OR @PhoneNumber = ''
    BEGIN
        SELECT 'Phone Number is Required.' AS Message;
        RETURN;
    END
    IF LEN(@UserName) < 3 OR LEN(@UserName) > 100
    BEGIN
        SELECT 'User Name Must Be Between 3 And 100 Characters.' AS Message;
        RETURN;
    END
    IF @UserName LIKE '%[^A-Za-z0-9_]%'
    BEGIN
        SELECT 'User Name Can Contain Only Letters, Numbers And Underscore.' AS Message;
        RETURN;
    END
    IF LEN(@PasswordHash) < 8
    BEGIN
        SELECT 'Password Must Be At Least 8 Characters Long.' AS Message;
        RETURN;
    END
    IF @PasswordHash NOT LIKE '%[A-Z]%'
    BEGIN
        SELECT 'Password Must Contain At Least One Uppercase Letter.' AS Message;
        RETURN;
    END
    IF @PasswordHash NOT LIKE '%[a-z]%'
    BEGIN
        SELECT 'Password Must Contain At Least One Lowercase Letter.' AS Message;
        RETURN;
    END
    IF @PasswordHash NOT LIKE '%[0-9]%'
    BEGIN
        SELECT 'Password Must Contain At Least One Number.' AS Message;
        RETURN;
    END
    IF @PasswordHash NOT LIKE '%[^A-Za-z0-9]%'
    BEGIN
        SELECT 'Password Must Contain At Least One Special Character.' AS Message;
        RETURN;
    END
    IF @EmailId NOT LIKE '%_@_%._%'
       OR @EmailId LIKE '% %'
    BEGIN
        SELECT 'Invalid Email Format.' AS Message;
        RETURN;
    END
    IF @EmailId LIKE '%@%@%'
    BEGIN
        SELECT 'Email Cannot Contain Multiple @ Symbols.' AS Message;
        RETURN;
    END

    IF @EmailId LIKE '%..%'
    BEGIN
        SELECT 'Email Cannot Contain Consecutive Dots.' AS Message;
        RETURN;
    END
    IF LEFT(@EmailId,1)='.'
       OR RIGHT(@EmailId,1)='.'
    BEGIN
        SELECT 'Email Cannot Start Or End With Dot.' AS Message;
        RETURN;
    END
    IF @PhoneNumber LIKE '%[^0-9]%'
    BEGIN
        SELECT 'Phone Number Must Contain Only Digits.' AS Message;
        RETURN;
    END
    IF LEN(@PhoneNumber) <> 10
    BEGIN
        SELECT 'Phone Number Must Be 10 Digits.' AS Message;
        RETURN;
    END
    IF @PhoneNumber NOT LIKE '[6-9]%'
    BEGIN
        SELECT 'Invalid Indian Mobile Number.' AS Message;
        RETURN;
    END
    IF EXISTS
    (
        SELECT 1
        FROM tblSuperAdmin
        WHERE LOWER(EmailId) = LOWER(@EmailId)
    )
    BEGIN
        SELECT 'Email Already Exists.' AS Message;
        RETURN;
    END
    IF EXISTS
    (
        SELECT 1
        FROM tblSuperAdmin
        WHERE PhoneNumber = @PhoneNumber
    )
    BEGIN
        SELECT 'Phone Number Already Exists.' AS Message;
        RETURN;
    END
    INSERT INTO tblSuperAdmin
    (
        UserName,
        PasswordHash,
        EmailId,
        PhoneNumber,
        LastLogin,
        IsActive
    )
    VALUES
    (
        @UserName,
        @PasswordHash,
        @EmailId,
        @PhoneNumber,
        NULL,
        0
    );
    SELECT 'Super Admin Inserted Successfully.' AS Message;
END TRY
BEGIN CATCH
    SELECT
        ERROR_MESSAGE() AS Message,
        ERROR_LINE() AS ErrorLine,
        ERROR_PROCEDURE() AS ProcedureName;
END CATCH
END
GO