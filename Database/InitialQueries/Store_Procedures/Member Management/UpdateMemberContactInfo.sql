CREATE PROCEDURE spUpdateMemberContactInfo
(
    @MemberId INT,
    @PhoneNo VARCHAR(20),
    @EmailId VARCHAR(150) = NULL,
    @EmergencyContact VARCHAR(20) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Default response
    DECLARE @Message VARCHAR(200);
    DECLARE @Status BIT;

    -- 1. Check member exists
    IF NOT EXISTS (SELECT 1 FROM tblMember WHERE MemberId = @MemberId)
    BEGIN
        SELECT 0 AS Status, 'Member not found' AS Message;
        RETURN;
    END

    -- 2. Phone validation
    IF @PhoneNo IS NULL OR LEN(@PhoneNo) < 10
    BEGIN
        SELECT 0 AS Status, 'Invalid phone number' AS Message;
        RETURN;
    END

    -- 3. Duplicate phone check
    IF EXISTS (
        SELECT 1 FROM tblMember
        WHERE PhoneNo = @PhoneNo
        AND MemberId <> @MemberId
    )
    BEGIN
        SELECT 0 AS Status, 'Phone number already exists' AS Message;
        RETURN;
    END

    -- 4. Email format check
    IF @EmailId IS NOT NULL AND @EmailId NOT LIKE '%_@_%._%'
    BEGIN
        SELECT 0 AS Status, 'Invalid email format' AS Message;
        RETURN;
    END

    -- 5. Duplicate email check
    IF @EmailId IS NOT NULL AND EXISTS (
        SELECT 1 FROM tblMember
        WHERE EmailId = @EmailId
        AND MemberId <> @MemberId
    )
    BEGIN
        SELECT 0 AS Status, 'Email already exists' AS Message;
        RETURN;
    END

    -- 6. Emergency contact validation
    IF @EmergencyContact IS NOT NULL AND LEN(@EmergencyContact) < 10
    BEGIN
        SELECT 0 AS Status, 'Invalid emergency contact' AS Message;
        RETURN;
    END

    -- 7. Update
    UPDATE tblMember
    SET
        PhoneNo = @PhoneNo,
        EmailId = @EmailId,
        EmergencyContact = @EmergencyContact,
        UpdatedAt = GETDATE()
    WHERE MemberId = @MemberId;

    -- Success response
    SELECT 1 AS Status, 'Member updated successfully' AS Message;

END;