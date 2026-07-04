CREATE PROCEDURE spUpdateEmployeeContactDetails
(
    @EmployeeId INT,
    @PhoneNo VARCHAR(20),
    @EmailId VARCHAR(150),
    @BankAccountNo VARCHAR(50)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @PhoneNo = LTRIM(RTRIM(@PhoneNo));
        SET @EmailId = LTRIM(RTRIM(@EmailId));
        SET @BankAccountNo = LTRIM(RTRIM(@BankAccountNo));

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblEmployee
            WHERE EmployeeId = @EmployeeId
        )
        BEGIN
            SELECT 'Employee not found.' AS Message;
            RETURN;
        END

        IF @PhoneNo = ''
        BEGIN
            SELECT 'Phone number is required.' AS Message;
            RETURN;
        END

        IF LEN(@PhoneNo) <> 10
        BEGIN
            SELECT 'Phone number must be 10 digits.' AS Message;
            RETURN;
        END

        IF @PhoneNo LIKE '%[^0-9]%'
        BEGIN
            SELECT 'Phone number must contain only digits.' AS Message;
            RETURN;
        END

        IF @EmailId = ''
        BEGIN
            SELECT 'Email is required.' AS Message;
            RETURN;
        END

        IF @EmailId NOT LIKE '%_@_%._%'
        BEGIN
            SELECT 'Invalid email address.' AS Message;
            RETURN;
        END

        IF @BankAccountNo = ''
        BEGIN
            SELECT 'Bank account number is required.' AS Message;
            RETURN;
        END

        IF EXISTS
        (
            SELECT 1
            FROM tblEmployee
            WHERE PhoneNo = @PhoneNo
            AND EmployeeId <> @EmployeeId
        )
        BEGIN
            SELECT 'Phone number already exists.' AS Message;
            RETURN;
        END

        IF EXISTS
        (
            SELECT 1
            FROM tblEmployee
            WHERE EmailId = @EmailId
            AND EmployeeId <> @EmployeeId
        )
        BEGIN
            SELECT 'Email already exists.' AS Message;
            RETURN;
        END

        IF EXISTS
        (
            SELECT 1
            FROM tblEmployee
            WHERE BankAccountNo = @BankAccountNo
            AND EmployeeId <> @EmployeeId
        )
        BEGIN
            SELECT 'Bank account number already exists.' AS Message;
            RETURN;
        END

        UPDATE tblEmployee
        SET
            PhoneNo = @PhoneNo,
            EmailId = @EmailId,
            BankAccountNo = @BankAccountNo
        WHERE EmployeeId = @EmployeeId;

        SELECT 'Employee details updated successfully.' AS Message;

    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message;
    END CATCH
END;
GO