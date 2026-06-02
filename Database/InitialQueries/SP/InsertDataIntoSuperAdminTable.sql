CREATE PROC spInsertDataIntoSuperAdminTable
(
    @UserName VARCHAR(100),
    @PasswordHash VARCHAR(255),
    @Email_Id VARCHAR(150),
    @PhoneNumber VARCHAR(20)
)
AS
BEGIN
BEGIN TRY
    SET @UserName = LTRIM(RTRIM(@UserName));
    SET @PasswordHash = LTRIM(RTRIM(@PasswordHash));
    SET @Email_Id = LTRIM(RTRIM(@Email_Id));
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
    IF @Email_Id IS NULL OR @Email_Id = ''
    BEGIN
        SELECT 'Email is Required.' AS Message;
        RETURN;
    END
    IF @PhoneNumber IS NULL OR @PhoneNumber = ''
    BEGIN
        SELECT 'Phone Number is Required.' AS Message;
        RETURN;
    END
    IF @Email_Id NOT LIKE '%_@_%._%'
       OR @Email_Id LIKE '% %'
    BEGIN
        SELECT 'Invalid Email Format.' AS Message;
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
    IF EXISTS
    (
        SELECT 1
        FROM tblSuperAdmin
        WHERE Email_Id = @Email_Id
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
        Email_Id,
        PhoneNumber,
        LastLogin,
        IsActive
    )
    VALUES
    (
        @UserName,
        @PasswordHash,
        @Email_Id,
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