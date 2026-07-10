--------------------------------
--  MASTER STORED PROCEDURES  --
--------------------------------



-------------------------------------------------------------------
                   -- SUPER ADMIN MANAGEMENT SPs --
-------------------------------------------------------------------

--------------------------------
-- SP: spRegisterNewSuperAdmin
--------------------------------

CREATE PROC spRegisterNewSuperAdmin
(
    @UserName VARCHAR(100),
    @PasswordHash VARCHAR(255),
    @EmailId VARCHAR(150),
    @PhoneNumber VARCHAR(20)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @UserName = LTRIM(RTRIM(@UserName));
        SET @PasswordHash = LTRIM(RTRIM(@PasswordHash));
        SET @EmailId = LTRIM(RTRIM(@EmailId));
        SET @PhoneNumber = LTRIM(RTRIM(@PhoneNumber));

        -- Username Validation
        IF @UserName IS NULL OR @UserName = ''
        BEGIN
            SELECT 'Username is Required.' AS Message;
            RETURN;
        END

        IF LEN(@UserName) < 4
        BEGIN
            SELECT 'Username Must Be At Least 4 Characters.' AS Message;
            RETURN;
        END

        IF @UserName LIKE '% %'
        BEGIN
            SELECT 'Username Cannot Contain Spaces.' AS Message;
            RETURN;
        END

        IF @UserName LIKE '%[^A-Za-z0-9_]%'
        BEGIN
            SELECT 'Username Can Contain Only Letters, Numbers And Underscore.' AS Message;
            RETURN;
        END

        IF EXISTS
        (
            SELECT 1
            FROM tblSuperAdmin
            WHERE LOWER(UserName) = LOWER(@UserName)
        )
        BEGIN
            SELECT 'Username Already Exists.' AS Message;
            RETURN;
        END

        -- Email Validation
        IF @EmailId IS NULL OR @EmailId = ''
        BEGIN
            SELECT 'Email Id is Required.' AS Message;
            RETURN;
        END

        IF @EmailId NOT LIKE '%_@_%._%'
        BEGIN
            SELECT 'Invalid Email Id.' AS Message;
            RETURN;
        END

        IF EXISTS
        (
            SELECT 1
            FROM tblSuperAdmin
            WHERE LOWER(EmailId) = LOWER(@EmailId)
        )
        BEGIN
            SELECT 'Email Id Already Exists.' AS Message;
            RETURN;
        END

        -- Phone Validation
        IF @PhoneNumber IS NULL OR @PhoneNumber = ''
        BEGIN
            SELECT 'Phone Number is Required.' AS Message;
            RETURN;
        END

        IF @PhoneNumber LIKE '%[^0-9]%'
        BEGIN
            SELECT 'Phone Number Must Contain Only Digits.' AS Message;
            RETURN;
        END

        IF LEN(@PhoneNumber) <> 10
        BEGIN
            SELECT 'Phone Number Must Be 10 Digits.' AS Message;
            RETURN;
        END

        IF EXISTS
        (
            SELECT 1
            FROM tblSuperAdmin
            WHERE PhoneNumber = @PhoneNumber
        )
        BEGIN
            SELECT 'Phone Number Already Exists.' AS Message;
            RETURN;
        END

        -- Password Validation
        IF @PasswordHash IS NULL OR @PasswordHash = ''
        BEGIN
            SELECT 'Password is Required.' AS Message;
            RETURN;
        END

        INSERT INTO tblSuperAdmin
        (
            UserName,
            PasswordHash,
            EmailId,
            PhoneNumber,
            LastLogin,
            IsActive,
            CreatedAt
        )
        VALUES
        (
            @UserName,
            @PasswordHash,
            @EmailId,
            @PhoneNumber,
            NULL,
            0,
            GETDATE()
        );

        SELECT 'Super Admin Registered Successfully.' AS Message;

    END TRY

    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message;
    END CATCH

END;
GO

-----------------------------
--SP: spSuperAdminLoginLogout
-----------------------------
CREATE PROC spSuperAdminLoginLogout
(
    @UserName      VARCHAR(100),
    @PasswordHash  VARCHAR(255) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @UserName = LTRIM(RTRIM(ISNULL(@UserName, '')));
        SET @PasswordHash = LTRIM(RTRIM(ISNULL(@PasswordHash, '')));

        IF @UserName = ''
        BEGIN
            SELECT 'Username is Required.' AS Message;
            RETURN;
        END;

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblSuperAdmin
            WHERE UserName = @UserName
        )
        BEGIN
            SELECT 'Invalid Username.' AS Message;
            RETURN;
        END;

        IF EXISTS
        (
            SELECT 1
            FROM tblSuperAdmin
            WHERE UserName = @UserName
              AND IsActive = 1
        )
        BEGIN
            UPDATE tblSuperAdmin
            SET IsActive = 0
            WHERE UserName = @UserName;

            SELECT 'Logout Successful.' AS Message;
            RETURN;
        END;

        IF @PasswordHash = ''
        BEGIN
            SELECT 'Password is Required.' AS Message;
            RETURN;
        END;

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblSuperAdmin
            WHERE UserName = @UserName
              AND PasswordHash = @PasswordHash
        )
        BEGIN
            SELECT 'Invalid Password.' AS Message;
            RETURN;
        END;

        UPDATE tblSuperAdmin
        SET
            IsActive = 1,
            LastLogin = GETDATE()
        WHERE UserName = @UserName;

        SELECT 'Login Successful.' AS Message;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH

END;
GO

------------------------------------
-- SP: spChangeSuperAdminPassword --
------------------------------------
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

        SET @UserName = LTRIM(RTRIM(@UserName));
        SET @CurrentPasswordHash = LTRIM(RTRIM(@CurrentPasswordHash));
        SET @NewPasswordHash = LTRIM(RTRIM(@NewPasswordHash));
        SET @ConfirmNewPasswordHash = LTRIM(RTRIM(@ConfirmNewPasswordHash));

        IF @UserName = ''
        BEGIN
            SELECT 'User Name Is Required.' AS Message;
            RETURN;
        END;

        IF @CurrentPasswordHash = ''
        BEGIN
            SELECT 'Current Password Is Required.' AS Message;
            RETURN;
        END;

        IF @NewPasswordHash = ''
        BEGIN
            SELECT 'New Password Is Required.' AS Message;
            RETURN;
        END;

        IF @ConfirmNewPasswordHash = ''
        BEGIN
            SELECT 'Confirm New Password Is Required.' AS Message;
            RETURN;
        END;

        IF @NewPasswordHash <> @ConfirmNewPasswordHash
        BEGIN
            SELECT 'New Password And Confirm Password Do Not Match.' AS Message;
            RETURN;
        END;

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

        UPDATE tblSuperAdmin
        SET PasswordHash = @NewPasswordHash
        WHERE UserName = @UserName;

        SELECT 'Password Changed Successfully.' AS Message;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END
GO


---------------------------------------
-- SP: spUpdateSuperAdminContactDetails
---------------------------------------

CREATE PROC spUpdateSuperAdminContactDetails
(
    @UserName VARCHAR(100),
    @PasswordHash VARCHAR(255),
    @NewEmailId VARCHAR(150),
    @NewPhoneNumber VARCHAR(20)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @UserName = LTRIM(RTRIM(@UserName));
        SET @PasswordHash = LTRIM(RTRIM(@PasswordHash));
        SET @NewEmailId = LTRIM(RTRIM(@NewEmailId));
        SET @NewPhoneNumber = LTRIM(RTRIM(@NewPhoneNumber));

        -- Username Validation
        IF @UserName IS NULL OR @UserName = ''
        BEGIN
            SELECT 'Username is Required.' AS Message;
            RETURN;
        END;

        -- Password Validation
        IF @PasswordHash IS NULL OR @PasswordHash = ''
        BEGIN
            SELECT 'Password is Required.' AS Message;
            RETURN;
        END;

        -- Email Validation
        IF @NewEmailId IS NULL OR @NewEmailId = ''
        BEGIN
            SELECT 'New Email Id is Required.' AS Message;
            RETURN;
        END;

        IF @NewEmailId NOT LIKE '%_@_%._%'
        BEGIN
            SELECT 'Invalid Email Id.' AS Message;
            RETURN;
        END;

        -- Phone Validation
        IF @NewPhoneNumber IS NULL OR @NewPhoneNumber = ''
        BEGIN
            SELECT 'New Phone Number is Required.' AS Message;
            RETURN;
        END;

        IF @NewPhoneNumber LIKE '%[^0-9]%'
        BEGIN
            SELECT 'Phone Number Must Contain Only Digits.' AS Message;
            RETURN;
        END;

        IF LEN(@NewPhoneNumber) <> 10
        BEGIN
            SELECT 'Phone Number Must Be 10 Digits.' AS Message;
            RETURN;
        END;

        -- Username & Password Check
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblSuperAdmin
            WHERE UserName = @UserName
              AND PasswordHash = @PasswordHash
        )
        BEGIN
            SELECT 'Invalid Username or Password.' AS Message;
            RETURN;
        END;

        -- Email Already Exists
        IF EXISTS
        (
            SELECT 1
            FROM tblSuperAdmin
            WHERE EmailId = @NewEmailId
              AND UserName <> @UserName
        )
        BEGIN
            SELECT 'Email Id Already Exists.' AS Message;
            RETURN;
        END;

        -- Phone Already Exists
        IF EXISTS
        (
            SELECT 1
            FROM tblSuperAdmin
            WHERE PhoneNumber = @NewPhoneNumber
              AND UserName <> @UserName
        )
        BEGIN
            SELECT 'Phone Number Already Exists.' AS Message;
            RETURN;
        END;

        -- Update
        UPDATE tblSuperAdmin
        SET
            EmailId = @NewEmailId,
            PhoneNumber = @NewPhoneNumber
        WHERE UserName = @UserName
          AND PasswordHash = @PasswordHash;

        SELECT 'Email Id and Phone Number Updated Successfully.' AS Message;

    END TRY

    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message;
    END CATCH

END;
GO

-------------------------------------------------------------------
                   -- EMPLOYEE MANAGEMENT SPs --
-------------------------------------------------------------------

-----------------------
-- SP: spInsertEmployee
-----------------------

CREATE PROC spInsertEmployee
(
    @FirstName VARCHAR(150),
    @MiddleName VARCHAR(50) = NULL,
    @LastName VARCHAR(50),
    @GenderId INT,
    @PhoneNo VARCHAR(20),
    @EmailId VARCHAR(150),
    @BankAccountNo VARCHAR(50),

    @RoleId INT,

    @Amount DECIMAL(10,2),

    @UserName VARCHAR(100) = NULL,
    @PasswordHash VARCHAR(255) = NULL,

    @TrainerType VARCHAR(100) = NULL,
    @Specialization VARCHAR(200) = NULL,

    @Document VARBINARY(MAX) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    SET @FirstName = LTRIM(RTRIM(@FirstName))
    SET @LastName = LTRIM(RTRIM(@LastName))
    SET @PhoneNo = LTRIM(RTRIM(@PhoneNo))
    SET @EmailId = LTRIM(RTRIM(@EmailId))
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
    DECLARE @RoleName VARCHAR(MAX)
    SELECT @RoleName=Role FROM tblEmployeeRoleType WHERE RoleId=@RoleId

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
            RoleId,
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
            @RoleId,
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

            INSERT INTO tblCertificateDocument
            ( 
                TrainerId,
                Document
            )
            VALUES
            ( 
                @TrainerId,
                @Document
            )
            IF @TrainerType = 'Personal'
            BEGIN
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
        END

        COMMIT TRANSACTION

        SELECT
            'Employee Added Successfully.' AS Message

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



----------------------------------
-- SP: spDisplayAllEmployeeDetails
----------------------------------

CREATE PROC spDisplayAllEmployeeDetails
AS
BEGIN

    SELECT
        E.EmployeeId,
        E.FirstName,
        E.MiddleName,
        E.LastName,
        G.GenderName,
        E.PhoneNo,
        E.EmailId,
        E.JoiningDate,
        E.IsActive,
        R.Role AS RoleName,
        E.BankAccountNo,
        S.Amount AS Salary
    FROM tblEmployee E
    INNER JOIN tblGender G
        ON E.GenderId = G.GenderId
    INNER JOIN tblEmployeeRoleType R
        ON E.RoleId = R.RoleId
    INNER JOIN tblSalary S
        ON E.EmployeeId = S.EmployeeId
    ORDER BY E.EmployeeId;
END
GO


------------------------------------------------
-- SP: spUpdateEmployeeContactDetailsByEmployeeId
------------------------------------------------

CREATE PROCEDURE spUpdateEmployeeContactDetailsByEmployeeId
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


-----------------------------------------
-- SP: spUpdateEmployeeSalaryByEmployeeId
-----------------------------------------

CREATE PROCEDURE spUpdateEmployeeSalaryByEmployeeId
(
    @EmployeeId INT,
    @Amount DECIMAL(10,2)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

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

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblSalary
            WHERE EmployeeId = @EmployeeId
        )
        BEGIN
            SELECT 'Salary record not found.' AS Message;
            RETURN;
        END

        IF @Amount < 0
        BEGIN
            SELECT 'Salary amount cannot be negative.' AS Message;
            RETURN;
        END

        UPDATE tblSalary
        SET Amount = @Amount
        WHERE EmployeeId = @EmployeeId;

        SELECT 'Salary updated successfully.' AS Message;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO


-----------------------------------
-- SP: spToggleEmployeeActiveStatus
-----------------------------------

CREATE PROC spToggleEmployeeActiveStatus
(
    @EmployeeId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        BEGIN TRANSACTION;

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblEmployee
            WHERE EmployeeId = @EmployeeId
        )
        BEGIN
            SELECT 'Employee not found.' AS Message;
            ROLLBACK TRANSACTION;
            RETURN;
        END

        DECLARE @CurrentStatus BIT;
        DECLARE @TrainerId INT;
        DECLARE @TrainerType VARCHAR(100);

        SELECT @CurrentStatus = IsActive
        FROM tblEmployee
        WHERE EmployeeId = @EmployeeId;

        UPDATE tblEmployee
        SET IsActive =
            CASE
                WHEN IsActive = 1 THEN 0
                ELSE 1
            END
        WHERE EmployeeId = @EmployeeId;

        SELECT
            @TrainerId = TrainerId,
            @TrainerType = TrainerType
        FROM tblTrainer
        WHERE EmployeeId = @EmployeeId;

        IF @TrainerId IS NOT NULL
           AND @TrainerType = 'Personal'
        BEGIN

            IF @CurrentStatus = 1
            BEGIN
                DELETE FROM tblTrainerShift
                WHERE TrainerId = @TrainerId;

                UPDATE tblMemberTrainerAssignment
                SET IsActive = 0
                WHERE TrainerId = @TrainerId;
            END

            ELSE
            BEGIN

                INSERT INTO tblTrainerShift
                (
                    TrainerId,
                    ShiftId
                )
                SELECT
                    @TrainerId,
                    ShiftId
                FROM tblShift;
            END

        END

        COMMIT TRANSACTION;

        SELECT 'Employee status updated successfully.' AS Message;

    END TRY
    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO


-------------------------------
-- SP: spAddCertificateDocument
-------------------------------

CREATE PROCEDURE spAddCertificateDocument
(
    @TrainerId INT,
    @Document VARBINARY(MAX) 
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        INSERT INTO tblCertificateDocument
        (
            TrainerId,
            Document
        )
        VALUES
        (
            @TrainerId,
            @Document
        );

        SELECT 'Certificate added successfully.' AS Message;
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message;
    END CATCH
END;
GO


-------------------------------------------------------------------
                   -- ADMIN MANAGEMENT SPs --
-------------------------------------------------------------------

----------------------------
-- SP: spUpdateAdminPassword
----------------------------

CREATE PROC spUpdateAdminPassword
(
    @UserName VARCHAR(100),
    @CurrentPasswordHash VARCHAR(255),
    @NewPasswordHash VARCHAR(255)
)
AS
BEGIN
BEGIN TRY

    SET NOCOUNT ON;

    SET @UserName = LTRIM(RTRIM(@UserName));
    SET @CurrentPasswordHash = LTRIM(RTRIM(@CurrentPasswordHash));
    SET @NewPasswordHash = LTRIM(RTRIM(@NewPasswordHash));

    -- Username Validation
    IF @UserName IS NULL OR @UserName = ''
    BEGIN
        SELECT 'Username is Required.' AS Message;
        RETURN;
    END

    -- Current Password Validation
    IF @CurrentPasswordHash IS NULL OR @CurrentPasswordHash = ''
    BEGIN
        SELECT 'Current Password is Required.' AS Message;
        RETURN;
    END

    -- New Password Validation
    IF @NewPasswordHash IS NULL OR @NewPasswordHash = ''
    BEGIN
        SELECT 'New Password is Required.' AS Message;
        RETURN;
    END

    -- Check Username Exists
    IF NOT EXISTS
    (
        SELECT 1
        FROM tblAdmin
        WHERE UserName = @UserName
    )
    BEGIN
        SELECT 'Invalid Username.' AS Message;
        RETURN;
    END

    -- Check Current Password
    IF NOT EXISTS
    (
        SELECT 1
        FROM tblAdmin
        WHERE UserName = @UserName
          AND PasswordHash = @CurrentPasswordHash
    )
    BEGIN
        SELECT 'Current Password is Incorrect.' AS Message;
        RETURN;
    END

    -- New Password should not be same as Current Password
    IF @CurrentPasswordHash = @NewPasswordHash
    BEGIN
        SELECT 'New Password Cannot Be Same As Current Password.' AS Message;
        RETURN;
    END

    -- Update Password
    UPDATE tblAdmin
    SET PasswordHash = @NewPasswordHash
    WHERE UserName = @UserName
      AND PasswordHash = @CurrentPasswordHash;

    SELECT 'Password Updated Successfully.' AS Message;

END TRY

BEGIN CATCH

    SELECT
        ERROR_MESSAGE() AS Message;

END CATCH
END;
GO


-------------------------------------------------------------------
                   -- ADMIN MANAGEMENT SPs --
-------------------------------------------------------------------