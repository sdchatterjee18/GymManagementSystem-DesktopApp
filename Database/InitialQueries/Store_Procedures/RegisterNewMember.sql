CREATE PROC spRegisterNewMember
(
    -- tblMember
    @FirstName VARCHAR(50),
    @MiddleName VARCHAR(50) = NULL,
    @LastName VARCHAR(50),
    @GenderId INT,
    @PhoneNo VARCHAR(20),
    @EmailId VARCHAR(150) = NULL,
    @City VARCHAR(100),
    @District VARCHAR(100),
    @State VARCHAR(100),
    @EmergencyContact VARCHAR(20) = NULL,
    @ProfilePhoto VARBINARY(MAX) = NULL,
	@UpdatedAt DATETIME = NULL,

    -- tblMembershipSubscription
    @MembershipPlanId INT,
    @StartDate DATE,
    @ExpiryDate DATE,

    -- tblMemberShift
    @ShiftId INT,

    -- tblMemberDietAssignment
    @DietPlanId INT
)
AS
BEGIN

SET NOCOUNT ON;
SET XACT_ABORT ON;

BEGIN TRY

    ------------------------------------------------
    -- VALIDATIONS
    ------------------------------------------------

    IF LTRIM(RTRIM(@FirstName)) = ''
    BEGIN
        SELECT 'First Name Is Required.' AS Message;
        RETURN;
    END

    IF LTRIM(RTRIM(@LastName)) = ''
    BEGIN
        SELECT 'Last Name Is Required.' AS Message;
        RETURN;
    END

    IF @GenderId IS NULL
    BEGIN
        SELECT 'Gender Id Is Required.' AS Message;
        RETURN;
    END

    IF @PhoneNo IS NULL OR LTRIM(RTRIM(@PhoneNo)) = ''
    BEGIN
        SELECT 'Phone Number Is Required.' AS Message;
        RETURN;
    END

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblGender
        WHERE GenderId = @GenderId
    )
    BEGIN
        SELECT 'Invalid Gender Id.' AS Message;
        RETURN;
    END

    IF EXISTS
    (
        SELECT 1
        FROM tblMember
        WHERE PhoneNo = @PhoneNo
    )
    BEGIN
        SELECT 'Phone Number Already Exists.' AS Message;
        RETURN;
    END

    IF @EmailId IS NOT NULL
    AND EXISTS
    (
        SELECT 1
        FROM tblMember
        WHERE EmailId = @EmailId
    )
    BEGIN
        SELECT 'Email Already Exists.' AS Message;
        RETURN;
    END

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMembershipPlans
        WHERE MembershipPlanId = @MembershipPlanId
    )
    BEGIN
        SELECT 'Invalid Membership Plan Id.' AS Message;
        RETURN;
    END

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblShift
        WHERE ShiftId = @ShiftId
    )
    BEGIN
        SELECT 'Invalid Shift Id.' AS Message;
        RETURN;
    END

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblDietPlans
        WHERE DietPlanId = @DietPlanId
    )
    BEGIN
        SELECT 'Invalid Diet Plan Id.' AS Message;
        RETURN;
    END

    IF @StartDate > @ExpiryDate
    BEGIN
        SELECT 'Expiry Date Must Be Greater Than Start Date.' AS Message;
        RETURN;
    END

    ------------------------------------------------
    -- TRANSACTION START
    ------------------------------------------------

    BEGIN TRANSACTION;

    ------------------------------------------------
    -- INSERT MEMBER
    ------------------------------------------------

    INSERT INTO tblMember
    (
        FirstName,
        MiddleName,
        LastName,
        GenderId,
        PhoneNo,
        EmailId,
        City,
        District,
        State,
        EmergencyContact,
        ProfilePhoto,
		UpdatedAt
    )
    VALUES
    (
        @FirstName,
        @MiddleName,
        @LastName,
        @GenderId,
        @PhoneNo,
        @EmailId,
        @City,
        @District,
        @State,
        @EmergencyContact,
        @ProfilePhoto,
		@UpdatedAt
    );

    DECLARE @MemberId INT;

    SET @MemberId = SCOPE_IDENTITY();

    ------------------------------------------------
    -- INSERT SUBSCRIPTION
    ------------------------------------------------

    INSERT INTO tblMembershipSubscription
    (
        MemberId,
        MembershipPlanId,
        StartDate,
        ExpiryDate
    )
    VALUES
    (
        @MemberId,
        @MembershipPlanId,
        @StartDate,
        @ExpiryDate
    );

    ------------------------------------------------
    -- INSERT SHIFT
    ------------------------------------------------

    INSERT INTO tblMemberShift
    (
        MemberId,
        ShiftId
    )
    VALUES
    (
        @MemberId,
        @ShiftId
    );

    ------------------------------------------------
    -- INSERT DIET PLAN
    ------------------------------------------------

    INSERT INTO tblMemberDietAssignment
    (
        MemberId,
        DietPlanId
    )
    VALUES
    (
        @MemberId,
        @DietPlanId
    );

    ------------------------------------------------
    -- COMMIT
    ------------------------------------------------

    COMMIT TRANSACTION;

    SELECT
        'Member Registered Successfully.' AS Message,
        @MemberId AS MemberId;

END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION;

    SELECT
        ERROR_MESSAGE() AS Message,
        ERROR_LINE() AS ErrorLine,
        ERROR_PROCEDURE() AS ProcedureName;

END CATCH

END
GO