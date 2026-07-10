CREATE PROC spChangeSuperAdminPassword
(
    @UserName VARCHAR(100),
    @CurrentPasswordHash VARCHAR(255),
    @NewPasswordHash VARCHAR(255),
    @ConfirmNewPasswordHash VARCHAR(255)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        ------------------------------------------------
        -- Trim Inputs
        ------------------------------------------------
        SET @UserName = LTRIM(RTRIM(@UserName));
        SET @CurrentPasswordHash = LTRIM(RTRIM(@CurrentPasswordHash));
        SET @NewPasswordHash = LTRIM(RTRIM(@NewPasswordHash));
        SET @ConfirmNewPasswordHash = LTRIM(RTRIM(@ConfirmNewPasswordHash));

        ------------------------------------------------
        -- User Name Validation
        ------------------------------------------------
        IF @UserName = ''
        BEGIN
            SELECT 'User Name Is Required.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Current Password Validation
        ------------------------------------------------
        IF @CurrentPasswordHash = ''
        BEGIN
            SELECT 'Current Password Is Required.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- New Password Validation
        ------------------------------------------------
        IF @NewPasswordHash = ''
        BEGIN
            SELECT 'New Password Is Required.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Confirm Password Validation
        ------------------------------------------------
        IF @ConfirmNewPasswordHash = ''
        BEGIN
            SELECT 'Confirm New Password Is Required.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Password Match Validation
        ------------------------------------------------
        IF @NewPasswordHash <> @ConfirmNewPasswordHash
        BEGIN
            SELECT 'New Password And Confirm Password Do Not Match.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Username & Current Password Verification
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblSuperAdmin
            WHERE UserName = @UserName
              AND PasswordHash = @CurrentPasswordHash
              AND IsActive = 1
        )
        BEGIN
            SELECT 'Invalid User Name Or Current Password.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Update Password
        ------------------------------------------------
        UPDATE tblSuperAdmin
        SET PasswordHash = @NewPasswordHash
        WHERE UserName = @UserName;

        ------------------------------------------------
        -- Success Message
        ------------------------------------------------
        SELECT 'Password Changed Successfully.' AS Message;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END
GO