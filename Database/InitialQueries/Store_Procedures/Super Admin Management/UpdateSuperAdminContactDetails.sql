CREATE PROC spUpdateSuperAdminContactDetails
(
    @UserName VARCHAR(100),
    @PasswordHash VARCHAR(255),
    @NewEmailId VARCHAR(150),
    @NewPhoneNumber VARCHAR(20)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @UserName = LTRIM(RTRIM(@UserName));
        SET @PasswordHash = LTRIM(RTRIM(@PasswordHash));
        SET @NewEmailId = LTRIM(RTRIM(@NewEmailId));
        SET @NewPhoneNumber = LTRIM(RTRIM(@NewPhoneNumber));

        -- Username Validation
        IF @UserName IS NULL OR @UserName = ''
        BEGIN
            SELECT 'Username is Required.' AS Message;
            RETURN;
        END;

        -- Password Validation
        IF @PasswordHash IS NULL OR @PasswordHash = ''
        BEGIN
            SELECT 'Password is Required.' AS Message;
            RETURN;
        END;

        -- Email Validation
        IF @NewEmailId IS NULL OR @NewEmailId = ''
        BEGIN
            SELECT 'New Email Id is Required.' AS Message;
            RETURN;
        END;

        IF @NewEmailId NOT LIKE '%_@_%._%'
        BEGIN
            SELECT 'Invalid Email Id.' AS Message;
            RETURN;
        END;

        -- Phone Validation
        IF @NewPhoneNumber IS NULL OR @NewPhoneNumber = ''
        BEGIN
            SELECT 'New Phone Number is Required.' AS Message;
            RETURN;
        END;

        IF @NewPhoneNumber LIKE '%[^0-9]%'
        BEGIN
            SELECT 'Phone Number Must Contain Only Digits.' AS Message;
            RETURN;
        END;

        IF LEN(@NewPhoneNumber) <> 10
        BEGIN
            SELECT 'Phone Number Must Be 10 Digits.' AS Message;
            RETURN;
        END;

        -- Username & Password Check
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblSuperAdmin
            WHERE UserName = @UserName
              AND PasswordHash = @PasswordHash
        )
        BEGIN
            SELECT 'Invalid Username or Password.' AS Message;
            RETURN;
        END;

        -- Email Already Exists
        IF EXISTS
        (
            SELECT 1
            FROM tblSuperAdmin
            WHERE EmailId = @NewEmailId
              AND UserName <> @UserName
        )
        BEGIN
            SELECT 'Email Id Already Exists.' AS Message;
            RETURN;
        END;

        -- Phone Already Exists
        IF EXISTS
        (
            SELECT 1
            FROM tblSuperAdmin
            WHERE PhoneNumber = @NewPhoneNumber
              AND UserName <> @UserName
        )
        BEGIN
            SELECT 'Phone Number Already Exists.' AS Message;
            RETURN;
        END;

        -- Update
        UPDATE tblSuperAdmin
        SET
            EmailId = @NewEmailId,
            PhoneNumber = @NewPhoneNumber
        WHERE UserName = @UserName
          AND PasswordHash = @PasswordHash;

        SELECT 'Email Id and Phone Number Updated Successfully.' AS Message;

    END TRY

    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message;
    END CATCH

END;
GO