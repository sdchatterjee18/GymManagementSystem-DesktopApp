CREATE PROC spInsertDataIntoMemberTable
(
    @FirstName VARCHAR(50),
    @MiddleName VARCHAR(50) = NULL,
    @LastName VARCHAR(50),
    @GenderId INT,
    @PhoneNo VARCHAR(20),
    @Email_Id VARCHAR(150) = NULL,
    @City VARCHAR(100),
    @District VARCHAR(100),
    @State VARCHAR(100),
    @EmergencyContact VARCHAR(20) = NULL,
    @ProfilePhoto VARBINARY(MAX) = NULL
)
AS
BEGIN
BEGIN TRY

    SET @FirstName = LTRIM(RTRIM(@FirstName))
    SET @LastName = LTRIM(RTRIM(@LastName))
    SET @PhoneNo = LTRIM(RTRIM(@PhoneNo))
    SET @City = LTRIM(RTRIM(@City))
    SET @District = LTRIM(RTRIM(@District))
    SET @State = LTRIM(RTRIM(@State))

    IF @MiddleName IS NOT NULL
        SET @MiddleName = LTRIM(RTRIM(@MiddleName))

    IF @Email_Id IS NOT NULL
        SET @Email_Id = LTRIM(RTRIM(@Email_Id))

    IF @EmergencyContact IS NOT NULL
        SET @EmergencyContact = LTRIM(RTRIM(@EmergencyContact))

   

    IF @FirstName IS NULL OR @FirstName = ''
    BEGIN
        SELECT 'First Name is Required.' AS Message
        RETURN
    END

    IF @LastName IS NULL OR @LastName = ''
    BEGIN
        SELECT 'Last Name is Required.' AS Message
        RETURN
    END

    IF @GenderId IS NULL
    BEGIN
        SELECT 'Gender is Required.' AS Message
        RETURN
    END

    IF @PhoneNo IS NULL OR @PhoneNo = ''
    BEGIN
        SELECT 'Phone Number is Required.' AS Message
        RETURN
    END

    IF @City IS NULL OR @City = ''
    BEGIN
        SELECT 'City is Required.' AS Message
        RETURN
    END

    IF @District IS NULL OR @District = ''
    BEGIN
        SELECT 'District is Required.' AS Message
        RETURN
    END

    IF @State IS NULL OR @State = ''
    BEGIN
        SELECT 'State is Required.' AS Message
        RETURN
    END



    IF @FirstName LIKE '%[^A-Za-z]%'
    BEGIN
        SELECT 'First Name Must Contain Only Letters.' AS Message
        RETURN
    END

    IF @MiddleName IS NOT NULL
       AND @MiddleName LIKE '%[^A-Za-z]%'
    BEGIN
        SELECT 'Middle Name Must Contain Only Letters.' AS Message
        RETURN
    END

    IF @LastName LIKE '%[^A-Za-z]%'
    BEGIN
        SELECT 'Last Name Must Contain Only Letters.' AS Message
        RETURN
    END


    IF @PhoneNo LIKE '%[^0-9]%'
    BEGIN
        SELECT 'Phone Number Must Contain Only Digits.' AS Message
        RETURN
    END

    IF LEN(@PhoneNo) <> 10
    BEGIN
        SELECT 'Phone Number Must Be 10 Digits.' AS Message
        RETURN
    END



    IF @EmergencyContact IS NOT NULL
       AND @EmergencyContact <> ''
    BEGIN
        IF @EmergencyContact LIKE '%[^0-9]%'
        BEGIN
            SELECT 'Emergency Contact Must Contain Only Digits.' AS Message
            RETURN
        END

        IF LEN(@EmergencyContact) <> 10
        BEGIN
            SELECT 'Emergency Contact Must Be 10 Digits.' AS Message
            RETURN
        END
    END


    IF @Email_Id IS NOT NULL
       AND @Email_Id <> ''
    BEGIN
        IF @Email_Id NOT LIKE '%_@_%._%'
           OR @Email_Id LIKE '% %'
        BEGIN
            SELECT 'Invalid Email Format.' AS Message
            RETURN
        END

        IF EXISTS
        (
            SELECT 1
            FROM tblMember
            WHERE LOWER(Email_Id) = LOWER(@Email_Id)
        )
        BEGIN
            SELECT 'Email Id Already Exists.' AS Message
            RETURN
        END
    END

  

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblGender
        WHERE GenderId = @GenderId
    )
    BEGIN
        SELECT 'Invalid Gender Id.' AS Message
        RETURN
    END


    IF EXISTS
    (
        SELECT 1
        FROM tblMember
        WHERE PhoneNo = @PhoneNo
    )
    BEGIN
        SELECT 'Phone Number Already Exists.' AS Message
        RETURN
    END

    INSERT INTO tblMember
    (
        FirstName,
        MiddleName,
        LastName,
        GenderId,
        PhoneNo,
        Email_Id,
        City,
        District,
        State,
        EmergencyContact,
        ProfilePhoto,
        JoiningDate,
        IsActive
    )
    VALUES
    (
        @FirstName,
        @MiddleName,
        @LastName,
        @GenderId,
        @PhoneNo,
        @Email_Id,
        @City,
        @District,
        @State,
        @EmergencyContact,
        @ProfilePhoto,
        GETDATE(),
        1
    )

    SELECT 'Member Inserted Successfully.' AS Message

END TRY

BEGIN CATCH

    SELECT
        ERROR_MESSAGE() AS Message,
        ERROR_LINE() AS ErrorLine,
        ERROR_PROCEDURE() AS ProcedureName

END CATCH
END
GO