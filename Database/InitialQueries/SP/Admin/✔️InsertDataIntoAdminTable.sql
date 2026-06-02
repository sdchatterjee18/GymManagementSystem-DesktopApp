CREATE PROC spInsertDataIntoAdminTable
(
    @EmployeeId INT,
    @SuperAdminID INT,
    @UserName VARCHAR(100),
    @PasswordHash VARCHAR(255)
)
AS
BEGIN
BEGIN TRY

    SET @UserName = LTRIM(RTRIM(@UserName))
    SET @PasswordHash = LTRIM(RTRIM(@PasswordHash))


    IF @EmployeeId IS NULL
    BEGIN
        SELECT 'Employee Id is Required.' AS Message
        RETURN
    END

    IF @SuperAdminID IS NULL
    BEGIN
        SELECT 'Super Admin Id is Required.' AS Message
        RETURN
    END

    IF @UserName IS NULL OR @UserName = ''
    BEGIN
        SELECT 'Username is Required.' AS Message
        RETURN
    END

    IF @PasswordHash IS NULL OR @PasswordHash = ''
    BEGIN
        SELECT 'Password is Required.' AS Message
        RETURN
    END

      IF NOT EXISTS
    (
        SELECT 1
        FROM tblEmployee
        WHERE EmployeeId = @EmployeeId
    )
    BEGIN
        SELECT 'Invalid Employee Id.' AS Message
        RETURN
    END

   IF NOT EXISTS
    (
        SELECT 1
        FROM tblSuperAdmin
        WHERE SuperAdminID = @SuperAdminID
    )
    BEGIN
        SELECT 'Invalid Super Admin Id.' AS Message
        RETURN
    END

    IF LEN(@UserName) < 4
    BEGIN
        SELECT 'Username Must Be At Least 4 Characters.' AS Message
        RETURN
    END

    IF @UserName LIKE '% %'
    BEGIN
        SELECT 'Username Cannot Contain Spaces.' AS Message
        RETURN
    END

    IF @UserName LIKE '%[^A-Za-z0-9_]%'
    BEGIN
        SELECT 'Username Can Contain Only Letters, Numbers And Underscore.' AS Message
        RETURN
    END

   IF EXISTS
    (
        SELECT 1
        FROM tblAdmin
        WHERE LOWER(UserName) = LOWER(@UserName)
    )
    BEGIN
        SELECT 'Username Already Exists.' AS Message
        RETURN
    END

    IF LEN(@PasswordHash) < 8
    BEGIN
        SELECT 'Password Must Be At Least 8 Characters.' AS Message
        RETURN
    END

    IF @PasswordHash NOT LIKE '%[A-Z]%'
    BEGIN
        SELECT 'Password Must Contain At Least One Uppercase Letter.' AS Message
        RETURN
    END

    IF @PasswordHash NOT LIKE '%[a-z]%'
    BEGIN
        SELECT 'Password Must Contain At Least One Lowercase Letter.' AS Message
        RETURN
    END

    IF @PasswordHash NOT LIKE '%[0-9]%'
    BEGIN
        SELECT 'Password Must Contain At Least One Number.' AS Message
        RETURN
    END

IF @PasswordHash NOT LIKE '%[^A-Za-z0-9]%'
    BEGIN
        SELECT 'Password Must Contain At Least One Special Character.' AS Message;
        RETURN;
    END

    INSERT INTO tblAdmin
    (
        EmployeeId,
        SuperAdminID,
        UserName,
        PasswordHash,
        LastLogin
    )
    VALUES
    (
        @EmployeeId,
        @SuperAdminID,
        @UserName,
        @PasswordHash,
        NULL
    )

    SELECT 'Admin Inserted Successfully.' AS Message

END TRY

BEGIN CATCH

    SELECT
        ERROR_MESSAGE() AS Message,
        ERROR_LINE() AS ErrorLine,
        ERROR_PROCEDURE() AS ProcedureName

END CATCH
END
GO
