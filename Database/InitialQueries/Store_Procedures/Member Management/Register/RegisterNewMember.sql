CREATE PROC spRegisterNewMember
(
    -- Member
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

    -- Subscription
    @MembershipPlanId INT,

	-- Payment
    @PaymentMethod VARCHAR(50),
    @FeesType VARCHAR(50),

    -- Shift
    @ShiftId INT,

    -- Diet
    @DietPlanId INT,

    -- Locker
    @NeedLocker BIT = 0
)
AS
BEGIN

    DECLARE @MemberId INT;
	DECLARE @LockerId INT = NULL;
	DECLARE @Message VARCHAR(300);

	DECLARE @StartDate DATE;
	DECLARE @ExpiryDate DATE;
	DECLARE @DurationInDays INT;
	DECLARE @Price DECIMAL(10,2);

BEGIN TRY

    ------------------------------------------------
    -- VALIDATION
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
		  AND IsActive = 1
	)
	BEGIN
		SELECT 'Invalid Membership Plan.' AS Message;
		RETURN;
	END

		IF NOT EXISTS
	(
		SELECT 1
		FROM tblShift
		WHERE ShiftId=@ShiftId
	)
	BEGIN
		SELECT 'Invalid Shift.' AS Message;
		RETURN;
	END

		IF NOT EXISTS
	(
		SELECT 1
		FROM tblDietPlans
		WHERE DietPlanId=@DietPlanId
	)
	BEGIN
		SELECT 'Invalid Diet Plan.' AS Message;
		RETURN;
	END

	SELECT
		@Price = Price,
		@DurationInDays = DurationInDays
	FROM tblMembershipPlans
	WHERE MembershipPlanId = @MembershipPlanId;
	------------------------------------------------
    -- START EXPIRE DATE CALCULATION
    ------------------------------------------------

	SET @StartDate = CAST(GETDATE() AS DATE);
	SET @ExpiryDate = DATEADD(DAY, @DurationInDays, @StartDate);

    ------------------------------------------------
    -- START TRANSACTION
    ------------------------------------------------

    BEGIN TRANSACTION;

    ------------------------------------------------
    -- MEMBER INSERT
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
        GETDATE()
    );


    SET @MemberId = SCOPE_IDENTITY();

    ------------------------------------------------
    -- SUBSCRIPTION
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
    -- SHIFT
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
    -- SUBCRIPTION PAYMENT
    ------------------------------------------------

		INSERT INTO tblSubscriptionPayment
	  (
		MemberId,
		MembershipPlanId,
		PaymentMethod,
		Amount,
		FeesType
	  )
	  VALUES
	 (
		@MemberId,
		@MembershipPlanId,
		@PaymentMethod,
		@Price,
		@FeesType
	 );

    ------------------------------------------------
    -- DIET
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
    -- LOCKER ALLOCATION
    ------------------------------------------------

    IF @NeedLocker = 1
    BEGIN

        SELECT TOP 1
            @LockerId = LockerId
        FROM tblLocker
        WHERE LockerStatus = 'Available'
        ORDER BY LockerId;

        IF @LockerId IS NOT NULL
        BEGIN

            INSERT INTO tblLockerAllocation
            (
                LockerId,
                MemberId
            )
            VALUES
            (
                @LockerId,
                @MemberId
            );

            UPDATE tblLocker
            SET LockerStatus = 'Occupied'
            WHERE LockerId = @LockerId;

            SET @Message =
            'Member Registered Successfully. Locker Allocated.';

        END
        ELSE
        BEGIN

            SET @Message =
            'Member Registered Successfully. No Locker Available. Added To Waiting List.';

        END

    END
    ELSE
    BEGIN

        SET @Message =
        'Member Registered Successfully. No Locker Requested.';

    END

    ------------------------------------------------
    -- COMMIT
    ------------------------------------------------

    COMMIT TRANSACTION;

    SELECT
        @Message AS Message,
        @MemberId AS MemberId,
        @LockerId AS AllocatedLockerId;

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