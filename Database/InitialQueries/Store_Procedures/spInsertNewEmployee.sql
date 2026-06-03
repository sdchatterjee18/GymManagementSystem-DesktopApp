CREATE PROC spInsertEmployee
(
    @FirstName VARCHAR(150),
    @MiddleName VARCHAR(50) = NULL,
    @LastName VARCHAR(50),
    @GenderId INT,
    @PhoneNo VARCHAR(20),
    @EmailId VARCHAR(150),
    @RoleName VARCHAR(100),
    @BankAccountNo VARCHAR(50),

    @Amount DECIMAL(10,2),

    @UserName VARCHAR(100) = NULL,
    @PasswordHash VARCHAR(255) = NULL,

    @TrainerType VARCHAR(100) = NULL,
    @Specialization VARCHAR(200) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    SET @FirstName = LTRIM(RTRIM(@FirstName))
    SET @LastName = LTRIM(RTRIM(@LastName))
    SET @PhoneNo = LTRIM(RTRIM(@PhoneNo))
    SET @EmailId = LTRIM(RTRIM(@EmailId))
    SET @RoleName = LTRIM(RTRIM(@RoleName))
    SET @BankAccountNo = LTRIM(RTRIM(@BankAccountNo))

    IF @MiddleName IS NOT NULL
    BEGIN
        SET @MiddleName = LTRIM(RTRIM(@MiddleName))
    END

    IF @UserName IS NOT NULL
    BEGIN
        SET @UserName = LTRIM(RTRIM(@UserName))
    END

    IF @TrainerType IS NOT NULL
    BEGIN
        SET @TrainerType = LTRIM(RTRIM(@TrainerType))
    END

    IF @Specialization IS NOT NULL
    BEGIN
        SET @Specialization = LTRIM(RTRIM(@Specialization))
    END

    IF @MiddleName = ''
    BEGIN
        SET @MiddleName = NULL
    END

    IF @UserName = ''
    BEGIN
        SET @UserName = NULL
    END

    IF @TrainerType = ''
    BEGIN
        SET @TrainerType = NULL
    END

    IF @Specialization = ''
    BEGIN
        SET @Specialization = NULL
    END

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

    IF @EmailId IS NULL OR @EmailId = ''
    BEGIN
        SELECT 'Email Id is Required.' AS Message
        RETURN
    END

    IF @RoleName IS NULL OR @RoleName = ''
    BEGIN
        SELECT 'Role Name is Required.' AS Message
        RETURN
    END

    IF @BankAccountNo IS NULL OR @BankAccountNo = ''
    BEGIN
        SELECT 'Bank Account Number is Required.' AS Message
        RETURN
    END

    IF @Amount IS NULL OR @Amount <= 0
    BEGIN
        SELECT 'Salary Amount Must Be Greater Than Zero.' AS Message
        RETURN
    END

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblGender
        WHERE GenderId = @GenderId
    )
    BEGIN
        SELECT 'Invalid Gender Selected.' AS Message
        RETURN
    END

    IF EXISTS
    (
        SELECT 1
        FROM tblEmployee
        WHERE PhoneNo = @PhoneNo
    )
    BEGIN
        SELECT 'Phone Number Already Exists.' AS Message
        RETURN
    END

    IF EXISTS
    (
        SELECT 1
        FROM tblEmployee
        WHERE EmailId = @EmailId
    )
    BEGIN
        SELECT 'Email Id Already Exists.' AS Message
        RETURN
    END

    IF EXISTS
    (
        SELECT 1
        FROM tblEmployee
        WHERE BankAccountNo = @BankAccountNo
    )
    BEGIN
        SELECT 'Bank Account Number Already Exists.' AS Message
        RETURN
    END

    DECLARE @SuperAdminId INT
        SELECT @SuperAdminId = SuperAdminId
        FROM tblSuperAdmin
        WHERE IsActive = 1

     IF @SuperAdminId IS NULL
        BEGIN
            SELECT 'No Active Super Admin Found.' AS Message
            RETURN
        END

    IF @RoleName = 'Admin'
    BEGIN

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

        IF EXISTS
        (
            SELECT 1
            FROM tblAdmin
            WHERE UserName = @UserName
        )
        BEGIN
            SELECT 'Username Already Exists.' AS Message
            RETURN
        END

    END

    IF @RoleName = 'Trainer'
    BEGIN

        IF @TrainerType IS NULL OR @TrainerType = ''
        BEGIN
            SELECT 'Trainer Type is Required.' AS Message
            RETURN
        END

        IF @TrainerType NOT IN ('Personal', 'General')
        BEGIN
            SELECT 'Trainer Type Must Be Personal Or General.' AS Message
            RETURN
        END

    END

    BEGIN TRY

        BEGIN TRANSACTION

        INSERT INTO tblEmployee
        (
            FirstName,
            MiddleName,
            LastName,
            GenderId,
            PhoneNo,
            EmailId,
            RoleName,
            BankAccountNo
        )
        VALUES
        (
            @FirstName,
            @MiddleName,
            @LastName,
            @GenderId,
            @PhoneNo,
            @EmailId,
            @RoleName,
            @BankAccountNo
        )

        DECLARE @EmployeeId INT

        SET @EmployeeId = SCOPE_IDENTITY()

        INSERT INTO tblSalary
        (
            EmployeeId,
            Amount
        )
        VALUES
        (
            @EmployeeId,
            @Amount
        )

        IF @RoleName = 'Admin'
        BEGIN

            INSERT INTO tblAdmin
            (
                EmployeeId,
                SuperAdminId,
                UserName,
                PasswordHash
            )
            VALUES
            (
                @EmployeeId,
                @SuperAdminId,
                @UserName,
                @PasswordHash
            )

        END

        IF @RoleName = 'Trainer'
        BEGIN

            INSERT INTO tblTrainer
            (
                EmployeeId,
                TrainerType,
                Specialization
            )
            VALUES
            (
                @EmployeeId,
                @TrainerType,
                @Specialization
            )

            DECLARE @TrainerId INT

            SET @TrainerId = SCOPE_IDENTITY()

            INSERT INTO tblTrainerShift
            (
                TrainerId,
                ShiftId,
                IsActive
            )
            SELECT
                @TrainerId,
                ShiftId,
                0
            FROM tblShift

        END

        COMMIT TRANSACTION

        SELECT
            'Employee Added Successfully.' AS Message,

    END TRY

    BEGIN CATCH

        IF @@TRANCOUNT > 0
        BEGIN
            ROLLBACK TRANSACTION
        END

        SELECT ERROR_MESSAGE() AS Message

    END CATCH

END
GO