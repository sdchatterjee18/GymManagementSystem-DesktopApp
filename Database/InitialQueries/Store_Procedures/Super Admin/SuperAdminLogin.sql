CREATE PROC spSuperAdminLogin
(
    @UserName VARCHAR(100),
    @PasswordHash VARCHAR(255)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @UserName = LTRIM(RTRIM(@UserName));
        SET @PasswordHash = LTRIM(RTRIM(@PasswordHash));

        ---------------------------------------------------------
        -- Username Validation
        ---------------------------------------------------------
        IF @UserName IS NULL OR @UserName = ''
        BEGIN
            SELECT 0 AS Success, 'Username is Required.' AS Message;
            RETURN;
        END

        ---------------------------------------------------------
        -- Password Validation
        ---------------------------------------------------------
        IF @PasswordHash IS NULL OR @PasswordHash = ''
        BEGIN
            SELECT 0 AS Success, 'Password is Required.' AS Message;
            RETURN;
        END

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
            SELECT 0 AS Success, 'Invalid Username.' AS Message;
            RETURN;
        END

        ---------------------------------------------------------
        -- Username & Password Check
        ---------------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblSuperAdmin
            WHERE UserName = @UserName
              AND PasswordHash = @PasswordHash
        )
        BEGIN
            SELECT 0 AS Success, 'Invalid Password.' AS Message;
            RETURN;
        END

        ---------------------------------------------------------
        -- Already Logged In
        ---------------------------------------------------------
        IF EXISTS
        (
            SELECT 1
            FROM tblSuperAdmin
            WHERE UserName = @UserName
              AND IsActive = 1
        )
        BEGIN
            SELECT 0 AS Success, 'Super Admin is Already Logged In.' AS Message;
            RETURN;
        END

        ---------------------------------------------------------
        -- Login Success
        ---------------------------------------------------------
        UPDATE tblSuperAdmin
        SET
            IsActive = 1,
            LastLogin = GETDATE()
        WHERE UserName = @UserName;

        SELECT
            1 AS Success,
            'Login Successful.' AS Message;

    END TRY

    BEGIN CATCH

        SELECT
            0 AS Success,
            ERROR_MESSAGE() AS Message,
            ERROR_LINE() AS ErrorLine,
            ERROR_PROCEDURE() AS ProcedureName;

    END CATCH
END;
GO