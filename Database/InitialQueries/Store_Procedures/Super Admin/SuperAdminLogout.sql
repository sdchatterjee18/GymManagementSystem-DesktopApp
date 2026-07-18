CREATE PROC spSuperAdminLogout
(
    @UserName VARCHAR(100)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @UserName = LTRIM(RTRIM(@UserName));

        ---------------------------------------------------------
        -- Username Validation
        ---------------------------------------------------------
        IF @UserName IS NULL OR @UserName = ''
        BEGIN
            SELECT 0 AS Success, 'Username is Required.' AS Message;
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
        -- Already Logged Out
        ---------------------------------------------------------
        IF EXISTS
        (
            SELECT 1
            FROM tblSuperAdmin
            WHERE UserName = @UserName
              AND IsActive = 0
        )
        BEGIN
            SELECT 0 AS Success, 'Super Admin is Already Logged Out.' AS Message;
            RETURN;
        END

        ---------------------------------------------------------
        -- Logout
        ---------------------------------------------------------
        UPDATE tblSuperAdmin
        SET IsActive = 0
        WHERE UserName = @UserName;

        SELECT
            1 AS Success,
            'Logout Successful.' AS Message;

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