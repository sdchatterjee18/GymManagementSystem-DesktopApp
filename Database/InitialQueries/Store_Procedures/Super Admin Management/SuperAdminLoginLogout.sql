CREATE PROC spSuperAdminLoginLogout
(
    @UserName      VARCHAR(100),
    @PasswordHash  VARCHAR(255) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        ---------------------------------------------------------
        -- Trim Inputs
        ---------------------------------------------------------
        SET @UserName = LTRIM(RTRIM(ISNULL(@UserName, '')));
        SET @PasswordHash = LTRIM(RTRIM(ISNULL(@PasswordHash, '')));

        ---------------------------------------------------------
        -- Username Validation
        ---------------------------------------------------------
        IF @UserName = ''
        BEGIN
            SELECT 'Username is Required.' AS Message;
            RETURN;
        END;

        ---------------------------------------------------------
        -- Username Exists
        ---------------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblSuperAdmin
            WHERE UserName = @UserName
        )
        BEGIN
            SELECT 'Invalid Username.' AS Message;
            RETURN;
        END;

        ---------------------------------------------------------
        -- If Already Logged In -> Logout
        ---------------------------------------------------------
        IF EXISTS
        (
            SELECT 1
            FROM tblSuperAdmin
            WHERE UserName = @UserName
              AND IsActive = 1
        )
        BEGIN
            UPDATE tblSuperAdmin
            SET IsActive = 0
            WHERE UserName = @UserName;

            SELECT 'Logout Successful.' AS Message;
            RETURN;
        END;

        ---------------------------------------------------------
        -- Password Validation
        ---------------------------------------------------------
        IF @PasswordHash = ''
        BEGIN
            SELECT 'Password is Required.' AS Message;
            RETURN;
        END;

        ---------------------------------------------------------
        -- Password Check
        ---------------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblSuperAdmin
            WHERE UserName = @UserName
              AND PasswordHash = @PasswordHash
        )
        BEGIN
            SELECT 'Invalid Password.' AS Message;
            RETURN;
        END;

        ---------------------------------------------------------
        -- Login
        ---------------------------------------------------------
        UPDATE tblSuperAdmin
        SET
            IsActive = 1,
            LastLogin = GETDATE()
        WHERE UserName = @UserName;

        SELECT 'Login Successful.' AS Message;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH

END;
GO