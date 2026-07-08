CREATE PROC spRegisterNewSuperAdmin
(
    @UserName VARCHAR(100),
    @PasswordHash VARCHAR(255),
    @EmailId VARCHAR(150),
    @PhoneNumber VARCHAR(20)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @UserName = LTRIM(RTRIM(@UserName));
        SET @PasswordHash = LTRIM(RTRIM(@PasswordHash));
        SET @EmailId = LTRIM(RTRIM(@EmailId));
        SET @PhoneNumber = LTRIM(RTRIM(@PhoneNumber));

        -- Username Validation
        IF @UserName IS NULL OR @UserName = ''
        BEGIN
            SELECT 'Username is Required.' AS Message;
            RETURN;
        END

        IF LEN(@UserName) < 4
        BEGIN
            SELECT 'Username Must Be At Least 4 Characters.' AS Message;
            RETURN;
        END

        IF @UserName LIKE '% %'
        BEGIN
            SELECT 'Username Cannot Contain Spaces.' AS Message;
            RETURN;
        END

        IF @UserName LIKE '%[^A-Za-z0-9_]%'
        BEGIN
            SELECT 'Username Can Contain Only Letters, Numbers And Underscore.' AS Message;
            RETURN;
        END

        IF EXISTS
        (
            SELECT 1
            FROM tblSuperAdmin
            WHERE LOWER(UserName) = LOWER(@UserName)
        )
        BEGIN
            SELECT 'Username Already Exists.' AS Message;
            RETURN;
        END

        -- Email Validation
        IF @EmailId IS NULL OR @EmailId = ''
        BEGIN
            SELECT 'Email Id is Required.' AS Message;
            RETURN;
        END

        IF @EmailId NOT LIKE '%_@_%._%'
        BEGIN
            SELECT 'Invalid Email Id.' AS Message;
            RETURN;
        END

        IF EXISTS
        (
            SELECT 1
            FROM tblSuperAdmin
            WHERE LOWER(EmailId) = LOWER(@EmailId)
        )
        BEGIN
            SELECT 'Email Id Already Exists.' AS Message;
            RETURN;
        END

        -- Phone Validation
        IF @PhoneNumber IS NULL OR @PhoneNumber = ''
        BEGIN
            SELECT 'Phone Number is Required.' AS Message;
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
            WHERE PhoneNumber = @PhoneNumber
        )
        BEGIN
            SELECT 'Phone Number Already Exists.' AS Message;
            RETURN;
        END

        -- Password Validation
        IF @PasswordHash IS NULL OR @PasswordHash = ''
        BEGIN
            SELECT 'Password is Required.' AS Message;
            RETURN;
        END

        INSERT INTO tblSuperAdmin
        (
            UserName,
            PasswordHash,
            EmailId,
            PhoneNumber,
            LastLogin,
            IsActive,
            CreatedAt
        )
        VALUES
        (
            @UserName,
            @PasswordHash,
            @EmailId,
            @PhoneNumber,
            NULL,
            0,
            GETDATE()
        );

        SELECT 'Super Admin Registered Successfully.' AS Message;

    END TRY

    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message;
    END CATCH

END;
GO















































































































































































