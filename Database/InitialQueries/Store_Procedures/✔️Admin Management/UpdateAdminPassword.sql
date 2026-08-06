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

    -- Update Password
    UPDATE tblAdmin
    SET PasswordHash = @NewPasswordHash
    WHERE UserName = @UserName
      AND PasswordHash = @CurrentPasswordHash;

    SELECT 'Password Updated Successfully.' AS Message;

END TRY

BEGIN CATCH

    SELECT
        ERROR_MESSAGE() AS Message;

END CATCH
END;
GO