CREATE PROC spUpdateAdminPassword
(
    @UserName VARCHAR(100),
    @CurrentPasswordHash VARCHAR(255),
    @NewPasswordHash VARCHAR(255)
)
AS
BEGIN
BEGIN TRY

    SET NOCOUNT ON;

    SET @UserName = LTRIM(RTRIM(@UserName));
    SET @CurrentPasswordHash = LTRIM(RTRIM(@CurrentPasswordHash));
    SET @NewPasswordHash = LTRIM(RTRIM(@NewPasswordHash));

    -- Username Validation
    IF @UserName IS NULL OR @UserName = ''
    BEGIN
        SELECT 'Username is Required.' AS Message;
        RETURN;
    END

    -- Current Password Validation
    IF @CurrentPasswordHash IS NULL OR @CurrentPasswordHash = ''
    BEGIN
        SELECT 'Current Password is Required.' AS Message;
        RETURN;
    END

    -- New Password Validation
    IF @NewPasswordHash IS NULL OR @NewPasswordHash = ''
    BEGIN
        SELECT 'New Password is Required.' AS Message;
        RETURN;
    END

    -- Check Username Exists
    IF NOT EXISTS
    (
        SELECT 1
        FROM tblAdmin
        WHERE UserName = @UserName
    )
    BEGIN
        SELECT 'Invalid Username.' AS Message;
        RETURN;
    END

    -- Check Current Password
    IF NOT EXISTS
    (
        SELECT 1
        FROM tblAdmin
        WHERE UserName = @UserName
          AND PasswordHash = @CurrentPasswordHash
    )
    BEGIN
        SELECT 'Current Password is Incorrect.' AS Message;
        RETURN;
    END

    -- New Password should not be same as Current Password
    IF @CurrentPasswordHash = @NewPasswordHash
    BEGIN
        SELECT 'New Password Cannot Be Same As Current Password.' AS Message;
        RETURN;
    END

    -- Password Length
    IF LEN(@NewPasswordHash) < 8
    BEGIN
        SELECT 'Password Must Be At Least 8 Characters.' AS Message;
        RETURN;
    END

    -- Uppercase Check
    IF @NewPasswordHash NOT LIKE '%[A-Z]%'
    BEGIN
        SELECT 'Password Must Contain At Least One Uppercase Letter.' AS Message;
        RETURN;
    END

    -- Lowercase Check
    IF @NewPasswordHash NOT LIKE '%[a-z]%'
    BEGIN
        SELECT 'Password Must Contain At Least One Lowercase Letter.' AS Message;
        RETURN;
    END

    -- Number Check
    IF @NewPasswordHash NOT LIKE '%[0-9]%'
    BEGIN
        SELECT 'Password Must Contain At Least One Number.' AS Message;
        RETURN;
    END

    -- Special Character Check
    IF @NewPasswordHash NOT LIKE '%[^A-Za-z0-9]%'
    BEGIN
        SELECT 'Password Must Contain At Least One Special Character.' AS Message;
        RETURN;
    END

    -- Update Password
    UPDATE tblAdmin
    SET PasswordHash = @NewPasswordHash
    WHERE UserName = @UserName
      AND PasswordHash = @CurrentPasswordHash;

    SELECT 'Password Updated Successfully.' AS Message;

END TRY

BEGIN CATCH

    SELECT
        ERROR_MESSAGE() AS Message,
        ERROR_LINE() AS ErrorLine,
        ERROR_PROCEDURE() AS ProcedureName;

END CATCH
END;
GO