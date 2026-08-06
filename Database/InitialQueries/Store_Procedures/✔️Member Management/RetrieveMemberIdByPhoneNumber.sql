CREATE PROC spRetrieveMemberIdByPhoneNumber
(
    @PhoneNo VARCHAR(20)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        ------------------------------------------------
        -- Trim Phone Number
        ------------------------------------------------
        SET @PhoneNo = LTRIM(RTRIM(@PhoneNo));

        ------------------------------------------------
        -- Phone Number Required
        ------------------------------------------------
        IF @PhoneNo = ''
        BEGIN
            SELECT 'Phone Number is required.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Phone Number Validation
        ------------------------------------------------
        IF LEN(@PhoneNo) <> 10
        BEGIN
            SELECT 'Phone Number must be 10 digits.' AS Message;
            RETURN;
        END;

        IF @PhoneNo LIKE '%[^0-9]%'
        BEGIN
            SELECT 'Phone Number must contain only digits.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Member Exists
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMember
            WHERE PhoneNo = @PhoneNo
              AND IsActive = 1
        )
        BEGIN
            SELECT 'Member not found.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Return Member Id
        ------------------------------------------------
        SELECT
            MemberId
        FROM tblMember
        WHERE PhoneNo = @PhoneNo
          AND IsActive = 1;

    END TRY

    BEGIN CATCH

        SELECT
            ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO