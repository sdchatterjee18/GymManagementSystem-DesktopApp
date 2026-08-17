--------------------------------
--  MASTER STORED PROCEDURES  --
--------------------------------

--Super Admin Management — Line 23
--Employee Management — Line 455
--Admin Management — Line 1158
--Trainer Management — Line 1255
--Shift Management — Line 1712
--Membership Plan Management — Line 1822
--Expense Management — Line 2091
--Registration Management — Line 2556
--Locker Management — Line 2661
--Membership Subscription Management — Line 2742
--Subscription Payment Management — Line 4956
--Attendance Management — Line 4875
--Employee Salary Management — Line 5236
--Workout Schedule Management — Line 5835
--Diet Plan Management — Line 6165


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
                   1
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
                   -- TrainerManagement SPs --
-------------------------------------------------------------------

---------------------------------------
-- SP: spRetrieveTrainerIdByPhoneNumber
---------------------------------------
CREATE PROC spRetrieveTrainerIdByPhoneNumber
(
    @PhoneNo VARCHAR(20)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @PhoneNo = LTRIM(RTRIM(@PhoneNo));

        IF @PhoneNo = ''
        BEGIN
            SELECT 'Phone Number is required.' AS Message;
            RETURN;
        END;

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

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblTrainer T
            INNER JOIN tblEmployee E
                ON T.EmployeeId = E.EmployeeId
            WHERE E.PhoneNo = @PhoneNo
        )
        BEGIN
            SELECT 'Trainer not found.' AS Message;
            RETURN;
        END;

        SELECT
            T.TrainerId
        FROM tblTrainer T
        INNER JOIN tblEmployee E
            ON T.EmployeeId = E.EmployeeId
        WHERE E.PhoneNo = @PhoneNo;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO

----------------------------------------
-- SP: spGetAvailableTrainerCountByShift
----------------------------------------
CREATE OR ALTER PROC spRetrieveFreeTrainerByShift
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT
            S.ShiftId,
            S.ShiftName,
            COUNT(
                CASE
                    WHEN E.IsActive = 1 THEN TS.TrainerId
                END
            ) AS TotalFreeTrainer

        FROM tblShift S

        LEFT JOIN tblTrainerShift TS
            ON S.ShiftId = TS.ShiftId
            AND TS.IsActive = 1
        LEFT JOIN tblTrainer T
            ON TS.TrainerId = T.TrainerId
        LEFT JOIN tblEmployee E
            ON T.EmployeeId = E.EmployeeId
        GROUP BY
            S.ShiftId,
            S.ShiftName,
            S.StartTime
        ORDER BY
            S.StartTime;
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message;
    END CATCH
END

--------------------------------------------------
-- SP: spDisplayAssingedTrainersToMembersWithShift
--------------------------------------------------
CREATE PROCEDURE spDisplayAssingedTrainersToMembersWithShift
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT 
    MTA.MemberTrainerAssignmentId,
    CONCAT(M.FirstName,' ',M.MiddleName,' ',M.LastName) As MemberName,
    CONCAT(Employee.FirstName,' ',Employee.MiddleName,' ',Employee.LastName) As TrainerName,
    T.TrainerType,
    Sh.ShiftName,
    Sh.StartTime,
    Sh.EndTime 
    FROM tblMemberTrainerAssignment AS MTA
    INNER JOIN tblMember AS M
    ON MTA.MemberId = M.MemberId
    INNER JOIN tblShift AS Sh 
    ON M.MemberId=Sh.ShiftId
    INNER JOIN tblTrainer AS T
    ON MTA.TrainerId = T.TrainerId
    INNER JOIN tblEmployee AS Employee 
    ON T.EmployeeId = Employee.EmployeeId
    WHERE T.TrainerType = 'Personal';

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO

------------------------------
-- SP: DisplayGeneralTrainers
------------------------------
CREATE PROCEDURE DisplayGeneralTrainers
AS
BEGIN
	BEGIN TRY
		SELECT 
		E.EmployeeId,
		T.TrainerId,
		CONCAT(E.FirstName,' ',E.MiddleName,' ',E.LastName) AS TrainerName,
		T.Specialization,
		T.TrainerType,
		CD.Document,
		E.PhoneNo,
		G.GenderName
		FROM tblTrainer T
		INNER JOIN tblEmployee E
			ON T.EmployeeId = E.EmployeeId
		INNER JOIN tblGender G 
			ON E.GenderId = G.GenderId
		INNER JOIN tblCertificateDocument CD
			ON T.TrainerId = CD.TrainerId
		WHERE T.TrainerType = 'General' 
		AND E.IsActive = 1;
	END TRY
	BEGIN CATCH
		SELECT ERROR_MESSAGE() AS Message;
	END CATCH
END
GO

-------------------------------
-- SP: DisplayPersonalTrainers
-------------------------------
CREATE PROCEDURE DisplayPersonalTrainers
AS
BEGIN
	BEGIN TRY
		SELECT 
		E.EmployeeId,
		T.TrainerId,
		CONCAT(E.FirstName,' ',E.MiddleName,' ',E.LastName) AS TrainerName,
		T.Specialization,
		T.TrainerType,
		CD.Document,
		E.PhoneNo,
		G.GenderName
		FROM tblTrainer T
		INNER JOIN tblEmployee E
			ON T.EmployeeId = E.EmployeeId
		INNER JOIN tblGender G 
			ON E.GenderId = G.GenderId 
		INNER JOIN tblCertificateDocument CD
			ON T.TrainerId = CD.TrainerId
		WHERE T.TrainerType = 'Personal' 
		AND E.IsActive = 1;
	END TRY
	BEGIN CATCH	
		SELECT ERROR_MESSAGE() AS Message;
	END CATCH
END
GO

-----------------------------------------
-- SP: spRetrieveTrainersByPhoneNumber---
-----------------------------------------
CREATE PROC spRetrieveTrainersByPhoneNumberAndName
(
    @Search VARCHAR(100)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @Search = LTRIM(RTRIM(@Search));

        SELECT
            E.EmployeeId,
            T.TrainerId,
            CONCAT(
                E.FirstName, ' ',
                ISNULL(E.MiddleName + ' ', ''),
                E.LastName
            ) AS TrainerName,
            T.Specialization,
            T.TrainerType,
            CD.Document,
            E.PhoneNo,
            G.GenderName
        FROM tblTrainer T
        INNER JOIN tblEmployee E
            ON T.EmployeeId = E.EmployeeId
        INNER JOIN tblCertificateDocument CD
            ON T.TrainerId = CD.TrainerId
        INNER JOIN tblGender G
            ON E.GenderId = G.GenderId
        WHERE
            (
                E.FirstName LIKE @Search + '%'
                OR E.MiddleName LIKE @Search + '%'
                OR E.LastName LIKE @Search + '%'
                OR E.PhoneNo LIKE @Search + '%'
                OR T.Specialization LIKE @Search + '%'
            )
            AND E.IsActive = 1
        ORDER BY
            E.FirstName;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO


-------------------------------------------
-- SP: spDisplayMembersWithPersonalTrainer  xx
-------------------------------------------


---------------------------------------------
-- SP: spDisplayMembersWithoutPersonalTrainer  xx
---------------------------------------------


--------------------------------------
-- SP: spGetAllTrainerEmployeeDetails  
--------------------------------------
CREATE PROC spGetAllTrainerEmployeeDetails
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblEmployee E
            INNER JOIN tblEmployeeRoleType ERT
                ON E.RoleId = ERT.RoleId
            WHERE ERT.Role = 'Trainer'
        )
        BEGIN
            SELECT 'No Trainer Records Found.' AS Message;
            RETURN;
        END

        SELECT
            E.EmployeeId,
            T.TrainerId,
            CONCAT(E.FirstName,' ',E.MiddleName, ' ',E.LastName) AS TrainerName,
            T.Specialization,
            T.TrainerType,
            CD.Document,
            E.PhoneNo,
            G.GenderName AS Gender

        FROM tblEmployee E

        INNER JOIN tblEmployeeRoleType ERT
            ON E.RoleId = ERT.RoleId

        INNER JOIN tblTrainer T
            ON E.EmployeeId = T.EmployeeId

        LEFT JOIN tblCertificateDocument CD
            ON T.TrainerId = CD.TrainerId

        INNER JOIN tblGender G
            ON E.GenderId = G.GenderId

        WHERE ERT.Role = 'Trainer' AND E.IsActive=1

        ORDER BY
            E.FirstName,
            E.LastName;
            
    END TRY

    BEGIN CATCH
            SELECT ERROR_MESSAGE() AS Message
    END CATCH
END
GO

-------------------------------------------
-- SP: spGetInactivePersonalTrainersByShift ***
-------------------------------------------
CREATE PROC spGetInactivePersonalTrainersByShift
(
    @ShiftId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        -- Validation
        IF @ShiftId IS NULL OR @ShiftId <= 0
        BEGIN
            SELECT 'Valid ShiftId is required.' AS Message;
            RETURN;
        END

        -- Check Shift Exists
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblShift
            WHERE ShiftId = @ShiftId
        )
        BEGIN
            SELECT 'Shift does not exist.' AS Message;
            RETURN;
        END

        -- Fetch Personal Trainers whose TrainerShift IsActive = 0
        SELECT
           
            T.TrainerId,
           
            CONCAT(E.FirstName,' ',E.MiddleName,' ',E.LastName) AS TrainerName,
            E.PhoneNo,
            
            T.Specialization,
           
 
            TS.IsActive AS TrainerShiftStatus
        FROM tblTrainerShift TS
        INNER JOIN tblTrainer T
            ON TS.TrainerId = T.TrainerId
        INNER JOIN tblEmployee E
            ON T.EmployeeId = E.EmployeeId
        INNER JOIN tblShift S
            ON TS.ShiftId = S.ShiftId
        WHERE TS.ShiftId = @ShiftId
              AND TS.IsActive = 1
              AND T.TrainerType = 'Personal'
        ORDER BY E.FirstName, E.LastName;

    END TRY
    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message
    END CATCH
END
GO

-------------------------------------------
-- SP: spGetPersonalTrainerShiftStatus xx
-------------------------------------------
CREATE PROC spGetPersonalTrainerShiftStatus 
(
    @TrainerId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        -- Validation
        IF @TrainerId IS NULL OR @TrainerId <= 0
        BEGIN
            SELECT 'Valid TrainerId is required.' AS Message;
            RETURN;
        END;

        -- Check Trainer Exists
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblTrainer
            WHERE TrainerId = @TrainerId
        )
        BEGIN
            SELECT 'Trainer does not exist.' AS Message;
            RETURN;
        END;

        -- Check Trainer is Personal Trainer
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblTrainer
            WHERE TrainerId = @TrainerId
                  AND TrainerType = 'Personal'
        )
        BEGIN
            SELECT 'Specified trainer is not a Personal Trainer.' AS Message;
            RETURN;
        END;

        -- Show Trainer Shift Status
        SELECT
            T.TrainerId,
			CONCAT(E.FirstName,' ',E.MiddleName,' ',E.LastName) AS TrainerName,
            E.PhoneNo,
            S.ShiftName,
            S.StartTime,
            S.EndTime,
            TS.IsActive
        FROM tblTrainer T
		INNER JOIN tblEmployee E
                ON T.EmployeeId = E.EmployeeId
        INNER JOIN tblTrainerShift TS
            ON T.TrainerId = TS.TrainerId
        INNER JOIN tblShift S
            ON TS.ShiftId = S.ShiftId
        WHERE T.TrainerId = @TrainerId
              AND T.TrainerType = 'Personal'
        ORDER BY S.StartTime;

    END TRY

    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message
    END CATCH
END;
GO

-------------------------------------------
-- SP: spRetrieveTrainerOfSpecificMember
-------------------------------------------
CREATE PROC spRetrieveTrainerOfSpecificMember 
(
    @MemberId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        ------------------------------------------------
        -- Member Validation
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMember
            WHERE MemberId = @MemberId
        )
        BEGIN
            SELECT 'Invalid Member.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Active Trainer Assigned?
        ------------------------------------------------
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMemberTrainerAssignment
            WHERE MemberId = @MemberId
              AND IsActive = 1
        )
        BEGIN
            SELECT 'No Active Trainer Assigned To This Member.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Retrieve Trainer Details
        ------------------------------------------------
        SELECT
            CONCAT(E.FirstName ,' ',E.MiddleName,' ',E.LastName) AS TrainerName
        FROM tblMemberTrainerAssignment MTA
        INNER JOIN tblTrainer T
            ON MTA.TrainerId = T.TrainerId
        INNER JOIN tblEmployee E
            ON T.EmployeeId = E.EmployeeId
        INNER JOIN tblMember M
            ON MTA.MemberId = M.MemberId
        WHERE MTA.MemberId = @MemberId
          AND MTA.IsActive = 1;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message

    END CATCH
END;
GO

-------------------------------------------------------------------
                   -- ShiftManagement SPs --
-------------------------------------------------------------------

-------------------------------------
--SP: spRetrieveFreeTrainerByShift---
-------------------------------------
CREATE PROC spRetrieveFreeTrainerByShift
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT
            S.ShiftName,
            COUNT(
                CASE 
                    WHEN E.IsActive = 1 THEN TS.TrainerId
                END
            ) AS TotalFreeTrainer
        FROM tblShift S
        LEFT JOIN tblTrainerShift TS
            ON S.ShiftId = TS.ShiftId
            AND TS.IsActive = 1
        LEFT JOIN tblTrainer T
            ON TS.TrainerId = T.TrainerId
        LEFT JOIN tblEmployee E
            ON T.EmployeeId = E.EmployeeId
        GROUP BY
            S.ShiftId,
            S.ShiftName,
            S.StartTime
        ORDER BY
            S.StartTime;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END
GO
--------------------------
--SP: spUpdateShiftTime---
--------------------------
CREATE PROC spUpdateShiftTime 
(
    @ShiftId INT,
    @StartTime TIME,
    @EndTime TIME
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblShift
            WHERE ShiftId = @ShiftId
        )
        BEGIN
            SELECT 'Shift does not exist.' AS Message;
            RETURN;
        END;

        IF @StartTime >= @EndTime
        BEGIN
            SELECT 'End Time must be greater than Start Time.' AS Message;
            RETURN;
        END;

        UPDATE tblShift
        SET
            StartTime = @StartTime,
            EndTime = @EndTime
        WHERE ShiftId = @ShiftId;

        SELECT 'Shift time updated successfully.' AS Message;

    END TRY
    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO

--------------------------------
--SP: spRetrieveShiftTimeTable--
--------------------------------
CREATE PROC spRetrieveShiftTimeTable
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT
            ShiftId,
            ShiftName,
            FORMAT(CAST(StartTime AS datetime), 'hh:mm tt') AS StartTime,  
            FORMAT(CAST(EndTime AS datetime), 'hh:mm tt') AS EndTime
        FROM tblShift
        ORDER BY tblShift.StartTime ASC;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH

END;
GO

-------------------------
--SP: spGetCurrentShift--
-------------------------
CREATE PROC spGetCurrentShift
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        DECLARE @CurrentTime TIME = CAST(GETDATE() AS TIME);

        SELECT
            ShiftId,
            ShiftName,
            FORMAT(CAST(StartTime AS DATETIME), 'hh:mm tt') AS StartTime,
            FORMAT(CAST(EndTime AS DATETIME), 'hh:mm tt') AS EndTime
        FROM tblShift
        WHERE @CurrentTime BETWEEN StartTime AND EndTime;

    END TRY
    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO

-------------------------------------------------------------------
                   -- MembershipPlanManagement SPs --
-------------------------------------------------------------------

-------------------------------------------
--SP: spRetrieveTopThreeMembershipPlans--
-------------------------------------------
CREATE PROC spRetrieveTopThreeMembershipPlans
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT TOP 3
            MP.MembershipPlanName,
            COUNT(MS.MemberSubscriptionId) AS TotalSubscriptions
        FROM tblMembershipPlans MP
        LEFT JOIN tblMembershipSubscription MS
            ON MP.MembershipPlanId = MS.MembershipPlanId
            AND MS.IsActive = 1
        GROUP BY
            MP.MembershipPlanId,
            MP.MembershipPlanName
        ORDER BY
            TotalSubscriptions DESC,
            MP.MembershipPlanId;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END
GO
--------------------------------------
--SP: spInsertDataIntoMembershipPlan--
--------------------------------------
CREATE PROC spInsertDataIntoMembershipPlan
(
    @MembershipPlanName VARCHAR(100),
    @PlanTypeId         INT,
    @DurationInDays     INT,
    @Price              DECIMAL(10,2),
    @Description        VARCHAR(MAX) = NULL,
    @IsActive           BIT = 1
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
       
        IF @MembershipPlanName IS NULL OR LTRIM(RTRIM(@MembershipPlanName)) = ''
        BEGIN
            SELECT 'MembershipPlanName cannot be empty.' AS Message
            RETURN;
        END

        IF @DurationInDays IS NULL OR @DurationInDays <= 0
        BEGIN
            SELECT 'DurationInDays must be greater than zero.' AS Message
            RETURN;
        END

        IF @Price IS NULL OR @Price < 0
        BEGIN
            SELECT 'Price cannot be negative.' AS Message
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM tblMembershipPlanType WHERE PlanTypeId = @PlanTypeId)
        BEGIN
            SELECT 'Invalid PlanTypeId. No matching record found in tblMembershipPlanType.' AS Message
            RETURN;
        END

        IF EXISTS (SELECT 1 FROM tblMembershipPlans WHERE MembershipPlanName = @MembershipPlanName)
        BEGIN
            SELECT 'A membership plan with this name already exists.' AS Message            
            RETURN;
        END

        INSERT INTO tblMembershipPlans
        (
            MembershipPlanName,
            PlanTypeId,
            DurationInDays,
            Price,
            Description,
            IsActive
        )
        VALUES
        (
            @MembershipPlanName,
            @PlanTypeId,
            @DurationInDays,
            @Price,
            @Description,
            @IsActive
        );

         SELECT 'New Membership Plan added successfuly.' AS Message

    END TRY
    BEGIN CATCH
       SELECT ERROR_MESSAGE() AS Message
    END CATCH
END
GO

--------------------------------------------------------------------
--SP: spUpdateMembershipPlanDescriptionAndPriceByMembershipPlanId--
--------------------------------------------------------------------
CREATE PROC spUpdateMembershipPlanDescriptionAndPriceByMembershipPlanId 
(
    @MembershipPlanId INT,
    @Description      VARCHAR(MAX)  = NULL,
    @NewPrice         DECIMAL(10,2) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        IF NOT EXISTS (SELECT 1 FROM tblMembershipPlans WHERE MembershipPlanId = @MembershipPlanId)
        BEGIN
            SELECT 'MembershipPlanId not found.' AS Message
            RETURN;
        END

        IF @Description IS NULL AND @NewPrice IS NULL
        BEGIN
            SELECT 'No values supplied. Provide a Description and/or a NewPrice to update.' AS MESSAGE
            RETURN;
        END


        IF @NewPrice IS NOT NULL AND @NewPrice <= 0
        BEGIN
            SELECT 'Price cannot be negative or zero.' AS Message
            RETURN;
        END

        DECLARE @CurrentDescription VARCHAR(MAX);
        DECLARE @CurrentPrice       DECIMAL(10,2);

        SELECT
            @CurrentDescription = Description,
            @CurrentPrice       = Price
        FROM tblMembershipPlans
        WHERE MembershipPlanId = @MembershipPlanId;

        DECLARE @DescriptionChanged BIT = CASE
            WHEN @Description IS NOT NULL AND @Description <> @CurrentDescription THEN 1
            ELSE 0
        END;

        DECLARE @PriceChanged BIT = CASE
            WHEN @NewPrice IS NOT NULL AND @NewPrice <> @CurrentPrice THEN 1
            ELSE 0
        END;

        IF @DescriptionChanged = 0 AND @PriceChanged = 0
        BEGIN
            SELECT 'The supplied value(s) match the current record. No update performed.' AS Message
            RETURN;
        END

        UPDATE tblMembershipPlans
        SET
            Description = CASE WHEN @DescriptionChanged = 1 THEN @Description ELSE Description END,
            Price       = CASE WHEN @PriceChanged = 1 THEN @NewPrice ELSE Price END
        WHERE MembershipPlanId = @MembershipPlanId;

        SELECT
            CASE
                WHEN @DescriptionChanged = 1 AND @PriceChanged = 1 THEN 'Membership Plan Description and Price Updated Successfully.'
                WHEN @DescriptionChanged = 1 THEN 'Membership Plan Description Updated Successfully.'
                WHEN @PriceChanged = 1 THEN 'Membership Plan Price Updated Successfully.'
            END AS Message;

    END TRY
    BEGIN CATCH 
        SELECT ERROR_MESSAGE() AS Message
    END CATCH
END
GO

----------------------------------
--SP: spRetrieveMembershipPlans--
----------------------------------
CREATE PROCEDURE spRetrieveMembershipPlans  
AS  
BEGIN  
    SET NOCOUNT ON;  
  
    SELECT  
        mp.MembershipPlanId,  
        mp.MembershipPlanName,  
        mpt.PlanType,  
        mp.DurationInDays,  
        mp.Price,  
        mp.Description,  
        CASE  
            WHEN mp.IsActive = 1 THEN 'Active'  
            ELSE 'Inactive'  
        END IsActive  
    FROM tblMembershipPlans mp  
    INNER JOIN tblMembershipPlanType mpt  
        ON mp.PlanTypeId = mpt.PlanTypeId  
        ORDER BY mp.IsActive DESC,   
    mp.MembershipPlanId DESC;  
END; 
GO

---------------------------------------------------------
--SP: spRetrieveMembershipPlanDetailsByMembershipPlanId--
---------------------------------------------------------
CREATE PROCEDURE spSearchMembershipPlans   
    @SearchText NVARCHAR(100)  
AS  
BEGIN  
    SET NOCOUNT ON;  
  
    SELECT  
        MP.MembershipPlanId,  
        MP.MembershipPlanName,  
        PT.PlanType,  
        MP.DurationInDays,  
        MP.Price,  
        MP.Description,  
        CASE   
            WHEN MP.IsActive = 1 THEN 'Active'  
            ELSE 'InActive'  
        END AS IsActive  
    FROM tblMembershipPlans MP  
    INNER JOIN tblMembershipPlanType PT  
        ON MP.PlanTypeId = PT.PlanTypeId  
    WHERE  
        MP.MembershipPlanName LIKE '%' + @SearchText + '%'  
        OR CAST(MP.DurationInDays AS NVARCHAR(20)) LIKE '%' + @SearchText + '%'  
        OR CAST(MP.Price AS NVARCHAR(20)) LIKE '%' + @SearchText + '%'  
        OR PT.PlanType LIKE '%' + @SearchText + '%'  
        OR MP.Description LIKE '%' + @SearchText + '%'  
    ORDER BY MP.IsActive DESC,   
    MP.MembershipPlanId DESC;  
END
GO
-----------------------------------------------
--SP: spGetMembershipPlanPriceById--
-----------------------------------------------
CREATE PROCEDURE spGetMembershipPlanPriceById
(
    @MembershipPlanId INT
)
AS
BEGIN
    BEGIN TRY

        SELECT
            Price
        FROM tblMembershipPlans
        WHERE MembershipPlanId = @MembershipPlanId
          AND IsActive = 1;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END
GO
----------------------------------------------------
--SP: spDeactivateMembershipPlanByMembershipPlanId--
----------------------------------------------------
CREATE PROC spDeactivateMembershipPlanByMembershipPlanId 
(
    @MembershipPlanId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        
        IF NOT EXISTS (SELECT 1 FROM tblMembershipPlans WHERE MembershipPlanId = @MembershipPlanId)
        BEGIN
            SELECT 'MembershipPlanId not found.' AS Message
            RETURN;
        END

        IF EXISTS (SELECT 1 FROM tblMembershipPlans WHERE MembershipPlanId = @MembershipPlanId AND IsActive = 0)
        BEGIN
            SELECT 'This membership plan is already inactive.' AS Message
            RETURN;
        END

        UPDATE tblMembershipPlans
        SET IsActive = 0
        WHERE MembershipPlanId = @MembershipPlanId;
        SELECT 'Deactivate Membership Plan Successfully.' AS Message;

    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message
    END CATCH
END
GO


-------------------------------------------------------------------
                   -- ExpenseManagement SPs --
-------------------------------------------------------------------
------------------------------------------
--SP: spRetrieveCurrentMonthTotalExpense--
------------------------------------------
CREATE PROC spRetrieveCurrentMonthTotalExpense
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        DECLARE @CurrentMonth INT = MONTH(GETDATE());
        DECLARE @CurrentYear INT = YEAR(GETDATE());

        SELECT
            ISNULL(SUM(ExpenseAmount), 0) AS TotalExpense
        FROM tblExpense
        WHERE ExpenseDate >= DATEFROMPARTS(@CurrentYear, @CurrentMonth, 1)
          AND ExpenseDate < DATEADD(
                MONTH,
                1,
                DATEFROMPARTS(@CurrentYear, @CurrentMonth, 1)
              );

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END
GO

-------------------------------------
--SP: spRetrieveAllExpenseStatement--
------------------------------------
CREATE PROC spRetrieveAllExpenseStatement
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT
            E.ExpenseId,
            C.CategoryName,
            C.Category,
            E.ExpenseAmount,
            E.ExpenseDate,
            E.Notes
        FROM tblExpense AS E
        INNER JOIN tblExpensesCategories AS C
            ON E.ExpenseCategoryId = C.ExpenseCategoryId
        ORDER BY
            E.ExpenseDate DESC,
            E.ExpenseId DESC;

    END TRY
    BEGIN CATCH

        SELECT
            ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO

-----------------------
--SP: spInsertExpense--
-----------------------
CREATE PROC spInsertExpense  
(  
    @ExpenseCategoryId INT,  
    @ExpenseAmount DECIMAL(10,2),  
    @Notes VARCHAR(MAX)  
)  
AS  
BEGIN  
    BEGIN TRY  
  
        SET NOCOUNT ON;  
  
        SET @Notes = LTRIM(RTRIM(@Notes));  
  
        IF @ExpenseCategoryId IS NULL  
        BEGIN  
            SELECT 'Expense Category is Required.' AS Message;  
            RETURN;  
        END  
  
        IF NOT EXISTS  
        (  
            SELECT 1  
            FROM tblExpensesCategories  
            WHERE ExpenseCategoryId = @ExpenseCategoryId  
        )  
        BEGIN  
            SELECT 'Invalid Expense Category.' AS Message;  
            RETURN;  
        END  
  
        IF @ExpenseAmount IS NULL OR @ExpenseAmount < 0  
        BEGIN  
            SELECT 'Expense Amount Must Be >= 0.' AS Message;  
            RETURN;  
        END  
  
        INSERT INTO tblExpense  
        (  
            ExpenseCategoryId,  
            ExpenseAmount,  
            ExpenseDate,  
            Notes  
        )  
        VALUES  
        (  
            @ExpenseCategoryId,  
            @ExpenseAmount,  
            CAST(GETDATE() AS DATETIME),  
            @Notes  
        );  
  
        SELECT 'Expense Inserted Successfully.' AS Message;  
  
    END TRY  
  
    BEGIN CATCH  
  
        SELECT ERROR_MESSAGE() AS Message;  
  
    END CATCH  
END;  
GO

---------------------------------------------
--SP: spRetrieveExpenseStatementByDateRange--
---------------------------------------------
CREATE PROC spRetrieveExpenseStatementByDateRange 
(
    @FromDate DATE,
    @ToDate DATE
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF @FromDate IS NULL
        BEGIN
            SELECT 'From Date is required.' AS Message;
            RETURN;
        END;
        IF @ToDate IS NULL
        BEGIN
            SELECT 'To Date is required.' AS Message;
            RETURN;
        END;
        IF @FromDate > CAST(GETDATE() AS DATE)
        BEGIN
            SELECT 'From Date cannot be greater than today.' AS Message;
            RETURN;
        END;

        IF @ToDate > CAST(GETDATE() AS DATE)
        BEGIN
            SELECT 'To Date cannot be greater than today.' AS Message;
            RETURN;
        END;
        IF @FromDate > @ToDate
        BEGIN
            SELECT 'From Date cannot be greater than To Date.' AS Message;
            RETURN;
        END;
        SELECT
            E.ExpenseId,
            EC.CategoryName,
            EC.Category,
            E.ExpenseAmount,
            E.ExpenseDate,
            E.Notes
        FROM tblExpense E
        INNER JOIN tblExpensesCategories EC
            ON E.ExpenseCategoryId = EC.ExpenseCategoryId
        WHERE E.ExpenseDate BETWEEN @FromDate AND @ToDate
        ORDER BY
            E.ExpenseDate DESC
    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO

-----------------------------------------
--SP: spRetrieveTotalExpenseByDateRange--
-----------------------------------------
CREATE PROC spRetrieveTotalExpenseByDateRange 
(
    @FromDate DATE,
    @ToDate DATE
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF @FromDate IS NULL
        BEGIN
            SELECT 'From Date is required.' AS Message;
            RETURN;
        END;
        IF @ToDate IS NULL
        BEGIN
            SELECT 'To Date is required.' AS Message;
            RETURN;
        END;
        IF @FromDate > CAST(GETDATE() AS DATE)
        BEGIN
            SELECT 'From Date cannot be greater than today.' AS Message;
            RETURN;
        END;

        IF @ToDate > CAST(GETDATE() AS DATE)
        BEGIN
            SELECT 'To Date cannot be greater than today.' AS Message;
            RETURN;
        END;
        IF @FromDate > @ToDate
        BEGIN
            SELECT 'From Date cannot be greater than To Date.' AS Message;
            RETURN;
        END;
        SELECT
            ISNULL(SUM(ExpenseAmount), 0) AS TotalExpense
        FROM tblExpense
        WHERE ExpenseDate BETWEEN @FromDate AND @ToDate;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO

-----------------------------------------
--SP: spRetrieveExpenseStatementByMonth--
-----------------------------------------
CREATE PROC spRetrieveExpenseStatementByMonth
(
    @Month INT,
    @Year INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF @Month IS NULL
           OR @Month NOT BETWEEN 1 AND 12
        BEGIN
            SELECT 'Invalid Month.' AS Message;
            RETURN;
        END;
        IF @Year IS NULL
           OR @Year < 2000
           OR @Year > YEAR(GETDATE())
        BEGIN
            SELECT 'Invalid Year.' AS Message;
            RETURN;
        END;
        SELECT
            E.ExpenseId,
            EC.CategoryName,
            EC.Category,
            E.ExpenseAmount,
            E.ExpenseDate,
            E.Notes
        FROM tblExpense E
        INNER JOIN tblExpensesCategories EC
            ON E.ExpenseCategoryId = EC.ExpenseCategoryId
        WHERE E.ExpenseDate >= DATEFROMPARTS(@Year, @Month, 1)
          AND E.ExpenseDate < DATEADD(MONTH, 1, DATEFROMPARTS(@Year, @Month, 1))
        ORDER BY
            E.ExpenseDate DESC
    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO

-------------------------------------
--SP: spRetrieveTotalExpenseByMonth--
-------------------------------------
CREATE PROC spRetrieveTotalExpenseByMonth 
(
    @Month INT,
    @Year INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF @Month IS NULL
           OR @Month NOT BETWEEN 1 AND 12
        BEGIN
            SELECT 'Invalid Month.' AS Message;
            RETURN;
        END;
        IF @Year IS NULL
           OR @Year < 2000
           OR @Year > YEAR(GETDATE())
        BEGIN
            SELECT 'Invalid Year.' AS Message;
            RETURN;
        END;
        SELECT
            ISNULL(SUM(ExpenseAmount), 0) AS TotalExpense
        FROM tblExpense
        WHERE ExpenseDate >= DATEFROMPARTS(@Year, @Month, 1)
          AND ExpenseDate < DATEADD(MONTH, 1, DATEFROMPARTS(@Year, @Month, 1));

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO

----------------------------------------
--SP: spRetrieveExpenseStatementByYear--
----------------------------------------
CREATE PROC spRetrieveExpenseStatementByYear 
(
    @Year INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF @Year IS NULL
           OR @Year < 2000
           OR @Year > YEAR(GETDATE())
        BEGIN
            SELECT 'Invalid Year.' AS Message;
            RETURN;
        END;
        SELECT
            E.ExpenseId,
            EC.CategoryName,
            EC.Category,
            E.ExpenseAmount,
            E.ExpenseDate,
            E.Notes
        FROM tblExpense E
        INNER JOIN tblExpensesCategories EC
            ON E.ExpenseCategoryId = EC.ExpenseCategoryId
        WHERE YEAR(E.ExpenseDate) = @Year
        ORDER BY
            E.ExpenseDate DESC,
            E.ExpenseId DESC;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO

----------------------------------------
--SP: spRetrieveExpenseStatementByYear--
----------------------------------------
CREATE PROC spRetrieveTotalExpenseByYear
(
    @Year INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF @Year IS NULL
           OR @Year < 2000
           OR @Year > YEAR(GETDATE())
        BEGIN
            SELECT 'Invalid Year.' AS Message;
            RETURN;
        END;
        SELECT
            ISNULL(SUM(ExpenseAmount), 0) AS TotalExpense
        FROM tblExpense
        WHERE YEAR(ExpenseDate) = @Year;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO

----------------------------
--SP: spAddExpenseCategory--
----------------------------
CREATE PROCEDURE spAddExpenseCategory 
(
    @CategoryName VARCHAR(100),
    @Category VARCHAR(100)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @CategoryName = LTRIM(RTRIM(@CategoryName));
        SET @Category = LTRIM(RTRIM(@Category));

        IF @CategoryName = ''
        BEGIN
            SELECT 'Category name is required.' AS Message;
            RETURN;
        END

        IF @Category = ''
        BEGIN
            SELECT 'Category is required.' AS Message;
            RETURN;
        END

        IF EXISTS
        (
            SELECT 1
            FROM tblExpensesCategories
            WHERE CategoryName = @CategoryName
        )
        BEGIN
            SELECT 'Category name already exists.' AS Message;
            RETURN;
        END

        INSERT INTO tblExpensesCategories
        (
            CategoryName,
            Category
        )
        VALUES
        (
            @CategoryName,
            @Category
        );

        SELECT 'Expense category added successfully.' AS Message;

    END TRY
    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO

----------------------------------
--SP: spGetAllExpensesCategories--
----------------------------------
CREATE PROC spGetAllExpensesCategories
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        ExpenseCategoryID,
        CategoryName,
        Category
    FROM tblExpensesCategories
    ORDER BY CategoryName;
END
GO
-------------------------------------------------------------------
                   -- RegistrationFeesManagement SPs --
-------------------------------------------------------------------

--------------------------------
--SP: spGetAllRegistrationFees--
--------------------------------
CREATE PROCEDURE spGetAllRegistrationFees
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        RegistrationFeesId,
        FeeAmount,
        CASE
            WHEN IsActive = 1 THEN 'Active'
            ELSE 'Inactive'
        END IsActive,
        CreatedAt
    FROM tblRegistrationFees
    ORDER BY RegistrationFeesId DESC;
END
GO

---------------------------------------------
--SP: spInsertDataIntoRegistrationFeesTable--
---------------------------------------------
CREATE PROC spInsertDataIntoRegistrationFeesTable
(
    @FeeAmount DECIMAL(10,2)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF @FeeAmount IS NULL
        BEGIN
            SELECT 'Fee Amount is Required.' AS Message;
            RETURN;
        END;

        IF @FeeAmount < 0
        BEGIN
            SELECT 'Fee Amount Cannot Be Negative.' AS Message;
            RETURN;
        END;
        IF EXISTS
        (
            SELECT 1
            FROM tblRegistrationFees
            WHERE FeeAmount = @FeeAmount
              AND IsActive = 1
        )
        BEGIN
            SELECT 'Registration Fee Already Exists.' AS Message;
            RETURN;
        END;

        BEGIN TRANSACTION;
        IF EXISTS
        (
            SELECT 1
            FROM tblRegistrationFees
            WHERE IsActive = 1
        )
        BEGIN
            UPDATE tblRegistrationFees
            SET IsActive = 0
            WHERE IsActive = 1;
        END
        INSERT INTO tblRegistrationFees
        (
            FeeAmount,
            IsActive
        )
        VALUES
        (
            @FeeAmount,
            1
        );

        COMMIT TRANSACTION;

        SELECT 'Registration Fee Updated Successfully.' AS Message;

    END TRY

    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH

END;
GO

-------------------------------------------------------------------
                   -- LockerManagement SPs --
-------------------------------------------------------------------

-----------------------------------
--SP: spInsertDataIntoLockerTable--
-----------------------------------
CREATE PROC spInsertDataIntoLockerTable 
(
    @LockerNo VARCHAR(20)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @LockerNo = LTRIM(RTRIM(@LockerNo));
        IF @LockerNo IS NULL OR @LockerNo = ''
        BEGIN
            SELECT 'Locker Number is Required.' AS Message;
            RETURN;
        END;
        IF EXISTS
        (
            SELECT 1
            FROM tblLocker
            WHERE LockerNo = @LockerNo
        )
        BEGIN
            SELECT 'Locker Number Already Exists.' AS Message;
            RETURN;
        END;
        INSERT INTO tblLocker
        (
            LockerNo,
            LockerStatus
        )
        VALUES
        (
            @LockerNo,
            'Available'
        );

        SELECT 'Locker Inserted Successfully.' AS Message;

    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message;
    END CATCH
END;
GO

--------------------------
--SP: spGetLockerDetails--
--------------------------
CREATE PROC spGetLockerDetails
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        L.LockerId,
        L.LockerNo,
        ISNULL(
            M.FirstName +
            CASE 
                WHEN M.MiddleName IS NULL OR LTRIM(RTRIM(M.MiddleName)) = ''
                    THEN ' '
                ELSE ' ' + M.MiddleName + ' '
            END +
            M.LastName,
            ''
        ) AS MemberName,
        L.LockerStatus
    FROM tblLocker AS L
    LEFT JOIN tblLockerAllocation AS LA
        ON L.LockerId = LA.LockerId
    LEFT JOIN tblMember AS M
        ON LA.MemberId = M.MemberId
    ORDER BY L.LockerNo;
END;
GO


-------------------------------------------------------------------------------
                   -- MembershipSubscriptionManagement SPs --
-------------------------------------------------------------------------------

-----------------------------------------------
--SP: spRetrieveCurrentMonthSubscriptionNo--
-----------------------------------------------
CREATE PROC spRetrieveCurrentMonthSubscriptionNo
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        DECLARE @StartOfMonth DATE =
            DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1);

        DECLARE @StartOfNextMonth DATE =
            DATEADD(MONTH, 1, @StartOfMonth);

        SELECT
            COUNT(*) AS SubscriptionNo
        FROM tblMembershipSubscription
        WHERE StartDate >= @StartOfMonth
          AND StartDate < @StartOfNextMonth;

    END TRY

    BEGIN CATCH

        SELECT
            ERROR_MESSAGE() AS Message;

    END CATCH
END
-----------------------------------------------
--SP: spGetTopThreeHighestSellingSubscription--
-----------------------------------------------
CREATE PROC spGetTopThreeHighestSellingSubscription
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TOP (3)
        mp.MembershipPlanName,
        COUNT(ms.MemberSubscriptionId) AS TotalSubscriptions
    FROM tblMembershipSubscription ms
    INNER JOIN tblMembershipPlans mp
        ON ms.MembershipPlanId = mp.MembershipPlanId
    GROUP BY mp.MembershipPlanName
    ORDER BY COUNT(ms.MemberSubscriptionId) DESC;
END;
GO

----------------------------------------
--SP: spGetTotalSubscriptionsThisMonth--
----------------------------------------
CREATE PROC spGetTotalSubscriptionsThisMonth
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        COUNT(MemberSubscriptionId) AS TotalSubscriptionsSold
    FROM tblMembershipSubscription
    WHERE StartDate >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)
      AND StartDate <= EOMONTH(GETDATE());
END;
GO

----------------------------------------------------------------
--SP: spInsertDataIntoMembershipSubscriptionTableWhileReneweal  
----------------------------------------------------------------
CREATE PROC spInsertDataIntoMembershipSubscriptionTableWhileReneweal 
(
    @MemberId INT,
    @MembershipPlanId INT,
    @PaymentMethod VARCHAR(50)
)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
    BEGIN TRANSACTION;
        DECLARE @DurationInDays INT;
        DECLARE @StartDate DATE;
        DECLARE @ExpiryDate DATE;
        DECLARE @LastExpiryDate DATE;
        DECLARE @Amount DECIMAL(10,2);

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMember
            WHERE MemberId = @MemberId
              AND IsActive = 1
        )
        BEGIN
            ROLLBACK TRANSACTION;
            SELECT 'Member does not exist or is inactive.' AS Message
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
            ROLLBACK TRANSACTION;
            SELECT 'Membership plan does not exist or is inactive.' AS Message
            RETURN;
        END
        SELECT
            @DurationInDays = DurationInDays,
            @Amount = Price
        FROM tblMembershipPlans
        WHERE MembershipPlanId = @MembershipPlanId;

        SELECT @LastExpiryDate = MAX(ExpiryDate)
        FROM tblMembershipSubscription
        WHERE MemberId = @MemberId;

        IF @LastExpiryDate IS NOT NULL
           AND @LastExpiryDate >= CAST(GETDATE() AS DATE)
        BEGIN
            SET @StartDate = DATEADD(DAY, 1, @LastExpiryDate);
        END
        ELSE
        BEGIN
            SET @StartDate = CAST(GETDATE() AS DATE);
        END

        SET @ExpiryDate = DATEADD(DAY, @DurationInDays - 1, @StartDate);
        DECLARE @MemberSubscriptionId INT;
        INSERT INTO tblMembershipSubscription
        (
            MemberId,
            MembershipPlanId,
            StartDate,
            ExpiryDate,
            IsActive
        )
        VALUES
        (
            @MemberId,
            @MembershipPlanId,
            @StartDate,
            @ExpiryDate,
            1
        );
        SET @MemberSubscriptionId = SCOPE_IDENTITY();
        INSERT INTO tblSubscriptionPayment
        (
            MemberId,
            MemberSubscriptionId,
            MembershipPlanId,
            PaymentMethod,
            Amount,
            FeesType
        )
        VALUES
        (
            @MemberId,
            @MemberSubscriptionId,
            @MembershipPlanId,
            @PaymentMethod,
            @Amount,
            'Renewal'
        );

        COMMIT TRANSACTION;

        SELECT 'Membership renewed successfully.' AS Message;

    END TRY

    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO

------------------------------------------------------
--SP: spGetMembershipSubscriptionsByMembershipPlanId--
------------------------------------------------------
CREATE PROC spGetMembershipSubscriptionsByMembershipPlanId   
(
    @MembershipPlanId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMembershipPlans
        WHERE MembershipPlanId = @MembershipPlanId
    )
    BEGIN
        SELECT 'Membership plan does not exist.' AS Message;
        RETURN;
    END

    SELECT
        MS.MemberSubscriptionId,
        M.MemberId,
        M.FirstName,
        M.LastName,
        MP.MembershipPlanName,
        MS.StartDate,
        MS.ExpiryDate,
        MS.IsActive
    FROM tblMembershipSubscription AS MS
    INNER JOIN tblMember AS M
        ON MS.MemberId = M.MemberId
    INNER JOIN tblMembershipPlans AS MP
        ON MS.MembershipPlanId = MP.MembershipPlanId
    WHERE MS.MembershipPlanId = @MembershipPlanId
    ORDER BY MS.StartDate DESC;
END;
GO

-----------------------------------------------
--SP: spGetActiveMembershipDetailsByMemberId--
-----------------------------------------------
CREATE PROC spGetActiveMembershipDetailsByMemberId
(
    @MemberId INT
)
AS
BEGIN
    SELECT
        MS.MemberSubscriptionId,
        MP.MembershipPlanName,
        MP.DurationInDays,
        MP.Price,
        MP.Description,
        MS.StartDate,
        MS.ExpiryDate
    FROM tblMembershipSubscription MS
    INNER JOIN tblMembershipPlans MP
        ON MS.MembershipPlanId = MP.MembershipPlanId
    WHERE
        MS.MemberId = @MemberId
        AND MS.IsActive = 1
        AND MP.IsActive = 1
        AND CAST(GETDATE() AS DATE) BETWEEN MS.StartDate AND MS.ExpiryDate;
END
GO

-----------------------------------------------------------------------
--SP: spGetMembershipSubscriptionsByMembershipPlanIdForASpecificMonth--
-----------------------------------------------------------------------
CREATE PROC spGetMembershipSubscriptionsByMembershipPlanIdForASpecificMonth 
(
    @MembershipPlanId INT,
    @Month INT,
    @Year INT
)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMembershipPlans
        WHERE MembershipPlanId = @MembershipPlanId
    )
    BEGIN
        SELECT 'Membership plan does not exist.' AS Message;
        RETURN;
    END

    SELECT
        MS.MemberSubscriptionId,
        M.MemberId,
        M.FirstName,
        M.LastName,
        MP.MembershipPlanName,
        MS.StartDate,
        MS.ExpiryDate,
        MS.IsActive
    FROM tblMembershipSubscription AS MS
    INNER JOIN tblMember AS M
        ON MS.MemberId = M.MemberId
    INNER JOIN tblMembershipPlans AS MP
        ON MS.MembershipPlanId = MP.MembershipPlanId
    WHERE MS.MembershipPlanId = @MembershipPlanId
      AND MONTH(MS.StartDate) = @Month
      AND YEAR(MS.StartDate) = @Year
    ORDER BY MS.StartDate DESC;
END;
GO

----------------------------------------------------------------------------
--SP: spGetCountMembershipSubscriptionsByMembershipPlanIdForASpecificMonth--
----------------------------------------------------------------------------
CREATE PROC spGetCountMembershipSubscriptionsByMembershipPlanIdForASpecificMonth
(
    @MembershipPlanId INT,
    @Month INT,
    @Year INT
)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT COUNT(*) AS TotalAssignments
    FROM tblMembershipSubscription
    WHERE MembershipPlanId = @MembershipPlanId
      AND MONTH(StartDate) = @Month
      AND YEAR(StartDate) = @Year;
END;
GO

----------------------------------------------------
--SP: spGetMembershipSubscriptionHistoryByMemberId--
----------------------------------------------------
CREATE PROC spGetMembershipSubscriptionHistoryByMemberId 
(
    @MemberId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMember
        WHERE MemberId = @MemberId
    )
    BEGIN
        SELECT 'Member does not exist.' AS Message;
        RETURN;
    END

    SELECT
        MS.MemberSubscriptionId,
        MP.MembershipPlanName,
        MS.StartDate,
        MS.ExpiryDate,
        MS.IsActive
    FROM tblMembershipSubscription AS MS
    INNER JOIN tblMembershipPlans AS MP
        ON MS.MembershipPlanId = MP.MembershipPlanId
    WHERE MS.MemberId = @MemberId
    ORDER BY MS.StartDate DESC;
END;
GO


----------------------------------------------------------------
                   -- MemberManagement SPs --
----------------------------------------------------------------
---------------------------
--SP: spRegisterNewMember--
---------------------------
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
SET NOCOUNT ON;

    DECLARE @MemberId INT;
	DECLARE @LockerId INT = NULL;
	DECLARE @Message VARCHAR(300);
	DECLARE @StartDate DATE;
	DECLARE @ExpiryDate DATE;
	DECLARE @DurationInDays INT;
	DECLARE @Price DECIMAL(10,2);
	DECLARE @RegistrationFee DECIMAL(10,2);
	DECLARE @TotalAmount DECIMAL(10,2);
    DECLARE @MemberSubscriptionId INT;

BEGIN TRY

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

	IF LTRIM(RTRIM(@PaymentMethod))=''
	BEGIN
		SELECT 'Payment Method Required.' AS Message;
		RETURN;
	END
	IF LTRIM(RTRIM(@FeesType)) = ''
	BEGIN
		SELECT 'Fees Type Required.' AS Message;
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
	IF LTRIM(RTRIM(@PhoneNo)) = ''
	BEGIN
		SELECT 'Phone Number Required.' AS Message;
		RETURN;
	END
	IF LEN(@PhoneNo) <> 10
	BEGIN
		SELECT 'Phone Number Must Be 10 Digits.' AS Message;
		RETURN;
	END
	IF @PhoneNo LIKE '%[^0-9]%'
	BEGIN
		SELECT 'Phone Number Must Contain Only Digits.' AS Message;
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
	SET @EmailId = NULLIF(LTRIM(RTRIM(@EmailId)), '');
	IF @EmailId IS NOT NULL
	AND @EmailId NOT LIKE '%@%.%'
	BEGIN
		SELECT 'Invalid Email Format.' AS Message;
		RETURN;
	END
    IF @EmailId IS NOT NULL
    AND EXISTS
    (
        SELECT 1
        FROM tblMember
        WHERE LOWER(EmailId)=LOWER(@EmailId)
    )
    BEGIN
        SELECT 'Email Already Exists.' AS Message;
        RETURN;
    END
	SET @EmergencyContact = NULLIF(LTRIM(RTRIM(@EmergencyContact)), '');
	IF @EmergencyContact IS NOT NULL
	BEGIN
		IF LEN(@EmergencyContact) <> 10
		BEGIN
			SELECT 'Emergency Contact Must Be 10 Digits.' AS Message;
			RETURN;
		END;

		IF @EmergencyContact LIKE '%[^0-9]%'
		BEGIN
			SELECT 'Emergency Contact Must Contain Only Digits.' AS Message;
			RETURN;
		END;
	END;
	SET @City = LTRIM(RTRIM(@City));
	SET @District = LTRIM(RTRIM(@District));
    SET @State = LTRIM(RTRIM(@State));
	IF @City=''
	BEGIN
		SELECT 'City Required.' AS Message;
		RETURN;
	END

	IF @District=''
	BEGIN
		SELECT 'District Required.' AS Message;
		RETURN;
	END

	IF @State=''
	BEGIN
		SELECT 'State Required.' AS Message;
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

	IF NOT EXISTS
	(
		SELECT 1
		FROM tblRegistrationFees
		WHERE IsActive = 1
	)
	BEGIN
		SELECT 'Registration Fee Is Not Active.' AS Message;
		RETURN;
	END

	SELECT
		@Price = Price,
		@DurationInDays = DurationInDays
	FROM tblMembershipPlans
	WHERE MembershipPlanId = @MembershipPlanId;

	SELECT TOP 1
    @RegistrationFee = FeeAmount
	FROM tblRegistrationFees
	WHERE IsActive = 1
	ORDER BY RegistrationFeesId DESC;

	SET @TotalAmount = @Price + @RegistrationFee;
	SET @StartDate = CAST(GETDATE() AS DATE);
	SET @ExpiryDate = DATEADD(DAY, @DurationInDays, @StartDate);

    BEGIN TRANSACTION;

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
        
    SET @MemberSubscriptionId=SCOPE_IDENTITY();
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
	INSERT INTO tblSubscriptionPayment
	(
		MemberId,
        MemberSubscriptionId,
		MembershipPlanId,
		PaymentMethod,
		Amount,
		FeesType
	)
	VALUES
	(
		@MemberId,
        @MemberSubscriptionId,
		@MembershipPlanId,
		@PaymentMethod,
		@TotalAmount,
		@FeesType
	);
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
        ERROR_MESSAGE() AS Message;

END CATCH

END
GO

-----------------------------------------
--SP: spRetrieveShiftWiseMemberNumbers--
-----------------------------------------
CREATE PROC spRetrieveShiftWiseMemberNumbers
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT
            s.ShiftId,
            s.ShiftName,
            COUNT(ms.MemberShiftId) AS MemberCount
        FROM tblShift s
        LEFT JOIN tblMemberShift ms
            ON s.ShiftId = ms.ShiftId
            AND ms.IsActive = 1
        LEFT JOIN tblMember m
            ON ms.MemberId = m.MemberId
            AND m.IsActive = 1
        GROUP BY
            s.ShiftId,
            s.ShiftName
        ORDER BY
            s.ShiftId;

    END TRY
    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END
-----------------------------------------
--SP: spRetrieveCurrentMonthNewMembers--
-----------------------------------------
CREATE PROC spRetrieveCurrentMonthNewMembers
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        DECLARE @StartOfMonth DATE =
            DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1);

        DECLARE @StartOfNextMonth DATE =
            DATEADD(MONTH, 1, @StartOfMonth);

        SELECT
            COUNT(*) AS NewMembers
        FROM tblMember
        WHERE JoiningDate >= @StartOfMonth
          AND JoiningDate < @StartOfNextMonth;

    END TRY

    BEGIN CATCH

        SELECT
            ERROR_MESSAGE() AS Message;

    END CATCH
END
GO
---------------------------------------
--SP: spAssignPersonalTrainerToMember--
---------------------------------------
CREATE PROC spAssignPersonalTrainerToMember  
(
    @MemberId INT,
    @TrainerId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ShiftId INT;

    BEGIN TRY
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMember
            WHERE MemberId = @MemberId
              AND IsActive = 1
        )
        BEGIN
            SELECT 'Member does not exist or is inactive.' AS Message;
            RETURN;
        END;
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMembershipSubscription
            WHERE MemberId = @MemberId
              AND IsActive = 1
              AND ExpiryDate >= CAST(GETDATE() AS DATE)
        )
        BEGIN
            SELECT 'Member has no active membership.' AS Message;
            RETURN;
        END;
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblTrainer T
            INNER JOIN tblEmployee E
                ON T.EmployeeId = E.EmployeeId
            WHERE T.TrainerId = @TrainerId
              AND E.IsActive = 1
        )
        BEGIN
            SELECT 'Trainer does not exist or is inactive.' AS Message;
            RETURN;
        END;
        SELECT @ShiftId = ShiftId
        FROM tblMemberShift
        WHERE MemberId = @MemberId
          AND IsActive = 1;

        IF @ShiftId IS NULL
        BEGIN
            SELECT 'Member has no active shift.' AS Message;
            RETURN;
        END;
        IF EXISTS
        (
            SELECT 1
            FROM tblTrainerShift
            WHERE TrainerId = @TrainerId
              AND ShiftId = @ShiftId
              AND IsActive = 0
        )
        BEGIN
            SELECT 'Trainer is not available in this shift.' AS Message;
            RETURN;
        END;
        IF EXISTS
        (
            SELECT 1
            FROM tblMemberTrainerAssignment
            WHERE MemberId = @MemberId
              AND IsActive = 1
        )
        BEGIN
            SELECT 'Personal trainer is already assigned to this member.' AS Message;
            RETURN;
        END;
        BEGIN TRANSACTION;

        INSERT INTO tblMemberTrainerAssignment
        (
            MemberId,
            TrainerId,
            ShiftId,
            AssignedDate,
            IsActive
        )
        VALUES
        (
            @MemberId,
            @TrainerId,
            @ShiftId,
            CAST(GETDATE() AS DATE),
            1
        );
        UPDATE tblTrainerShift
        SET IsActive = 0
        WHERE TrainerId = @TrainerId
          AND ShiftId = @ShiftId
          AND IsActive = 1;

        COMMIT TRANSACTION;

        SELECT 'Personal trainer assigned successfully.' AS Message;

    END TRY

    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO

-------------------------------
--SP: spChangePersonalTrainer--
-------------------------------
CREATE PROC spChangePersonalTrainer  
(
    @MemberId INT,
    @NewTrainerId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE
        @ShiftId INT,
        @OldTrainerId INT;

    BEGIN TRY
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMember
            WHERE MemberId = @MemberId
              AND IsActive = 1
        )
        BEGIN
            SELECT 'Member does not exist or is inactive.' AS Message;
            RETURN;
        END;
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMembershipSubscription
            WHERE MemberId = @MemberId
              AND IsActive = 1
              AND ExpiryDate >= CAST(GETDATE() AS DATE)
        )
        BEGIN
            SELECT 'Member has no active membership.' AS Message;
            RETURN;
        END;
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblTrainer T
            INNER JOIN tblEmployee E
                ON T.EmployeeId = E.EmployeeId
            WHERE T.TrainerId = @NewTrainerId
              AND E.IsActive = 1
        )
        BEGIN
            SELECT 'New trainer does not exist or is inactive.' AS Message;
            RETURN;
        END;
        SELECT @ShiftId = ShiftId
        FROM tblMemberShift
        WHERE MemberId = @MemberId
          AND IsActive = 1;
        SELECT @OldTrainerId = TrainerId
        FROM tblMemberTrainerAssignment
        WHERE MemberId = @MemberId
          AND IsActive = 1;
        IF @OldTrainerId = @NewTrainerId
        BEGIN
            SELECT 'This trainer is already assigned to the member.' AS Message;
            RETURN;
        END;
        BEGIN TRANSACTION;
        UPDATE tblMemberTrainerAssignment
        SET IsActive = 0
        WHERE MemberId = @MemberId
          AND TrainerId = @OldTrainerId
          AND IsActive = 1;
        UPDATE tblTrainerShift
        SET IsActive = 1
        WHERE TrainerId = @OldTrainerId
          AND ShiftId = @ShiftId;
        INSERT INTO tblMemberTrainerAssignment
        (
            MemberId,
            TrainerId,
            ShiftId,
            AssignedDate,
            IsActive
        )
        VALUES
        (
            @MemberId,
            @NewTrainerId,
            @ShiftId,
            CAST(GETDATE() AS DATE),
            1
        );
        UPDATE tblTrainerShift
        SET IsActive = 0
        WHERE TrainerId = @NewTrainerId
          AND ShiftId = @ShiftId;

        COMMIT TRANSACTION;

        SELECT 'Personal trainer changed successfully.' AS Message;

    END TRY

    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO

-------------------------------
  --SP: spChangeMemberShift--
-------------------------------
CREATE PROC spChangeMemberShift
(
    @MemberId INT,
    @NewShiftId INT
)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE
        @CurrentShiftId INT,
        @TrainerId INT,
        @MaxCapacity INT,
        @CurrentMemberCount INT;

    BEGIN TRY
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMember
            WHERE MemberId = @MemberId
              AND IsActive = 1
        )
        BEGIN
            SELECT 'Member does not exist or is inactive.' AS Message;
            RETURN;
        END;
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMembershipSubscription
            WHERE MemberId = @MemberId
              AND ExpiryDate >= CAST(GETDATE() AS DATE)
              AND IsActive = 1
        )
        BEGIN
            SELECT 'Member has no active membership.' AS Message;
            RETURN;
        END;
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblShift
            WHERE ShiftId = @NewShiftId
        )
        BEGIN
            SELECT 'Invalid Shift.' AS Message;
            RETURN;
        END;
        SELECT
            @CurrentShiftId = ShiftId
        FROM tblMemberShift
        WHERE MemberId = @MemberId
          AND IsActive = 1;

        IF @CurrentShiftId IS NULL
        BEGIN
            SELECT 'Current active shift not found.' AS Message;
            RETURN;
        END;
        IF @CurrentShiftId = @NewShiftId
        BEGIN
            SELECT 'Member is already assigned to this shift.' AS Message;
            RETURN;
        END;
        SELECT TOP (1)
            @MaxCapacity = MaxCapacity
        FROM tblShiftCapacity;

        IF @MaxCapacity IS NULL
        BEGIN
            SELECT 'Shift capacity is not configured.' AS Message;
            RETURN;
        END;
        SELECT
            @CurrentMemberCount = COUNT(*)
        FROM tblMemberShift
        WHERE ShiftId = @NewShiftId
          AND IsActive = 1;

        IF @CurrentMemberCount >= @MaxCapacity
        BEGIN
            SELECT 'Selected shift is already full.' AS Message;
            RETURN;
        END;
        SELECT TOP (1)
            @TrainerId = TrainerId
        FROM tblMemberTrainerAssignment
        WHERE MemberId = @MemberId
          AND IsActive = 1;
        BEGIN TRANSACTION;
        -- Deactivate Current Shift
        UPDATE tblMemberShift
        SET IsActive = 0
        WHERE MemberId = @MemberId
          AND IsActive = 1;
        -- Assign New Shift
        INSERT INTO tblMemberShift
        (
            MemberId,
            ShiftId,
            IsActive
        )
        VALUES
        (
            @MemberId,
            @NewShiftId,
            1
        );
        -- Deactivate Personal Trainer Assignment
        IF @TrainerId IS NOT NULL
        BEGIN
            UPDATE tblMemberTrainerAssignment
            SET IsActive = 0
            WHERE MemberId = @MemberId
              AND TrainerId = @TrainerId
              AND IsActive = 1;
				UPDATE tblTrainerShift
				SET IsActive = 1
				WHERE TrainerId = @TrainerId
				  AND ShiftId = @CurrentShiftId
				  AND IsActive = 0;
        END;
        COMMIT TRANSACTION;
        SELECT 'Member shift changed successfully.' AS Message;
    END TRY
    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO

-------------------------------
  --SP: spDeactivateMembers--
-------------------------------
CREATE PROC spDeactivateMembers
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        BEGIN TRANSACTION;

        ---------------------------------------------------------
        -- Deactivate Members
        ---------------------------------------------------------
        UPDATE M
        SET M.IsActive = 0
        FROM tblMember M
        INNER JOIN tblMembershipSubscription MS
            ON M.MemberId = MS.MemberId
        WHERE MS.MemberSubscriptionId =
        (
            SELECT MAX(MemberSubscriptionId)
            FROM tblMembershipSubscription
            WHERE MemberId = M.MemberId
        )
        AND MS.IsActive = 0
        AND DATEADD(MONTH,3,MS.ExpiryDate) < CAST(GETDATE() AS DATE)
        AND M.IsActive = 1;

        ---------------------------------------------------------
        -- Deactivate Member Shifts
        ---------------------------------------------------------
        UPDATE MSH
        SET MSH.IsActive = 0
        FROM tblMemberShift MSH
        INNER JOIN tblMembershipSubscription MS
            ON MSH.MemberId = MS.MemberId
        WHERE MS.MemberSubscriptionId =
        (
            SELECT MAX(MemberSubscriptionId)
            FROM tblMembershipSubscription
            WHERE MemberId = MSH.MemberId
        )
        AND MS.IsActive = 0
        AND DATEADD(MONTH,3,MS.ExpiryDate) < CAST(GETDATE() AS DATE)
        AND MSH.IsActive = 1;

        ---------------------------------------------------------
        -- Release Lockers
        ---------------------------------------------------------
        UPDATE L
        SET LockerStatus = 'Available'
        FROM tblLocker L
        INNER JOIN tblLockerAllocation LA
            ON L.LockerId = LA.LockerId
        INNER JOIN tblMembershipSubscription MS
            ON LA.MemberId = MS.MemberId
        WHERE MS.MemberSubscriptionId =
        (
            SELECT MAX(MemberSubscriptionId)
            FROM tblMembershipSubscription
            WHERE MemberId = LA.MemberId
        )
        AND MS.IsActive = 0
        AND DATEADD(MONTH,3,MS.ExpiryDate) < CAST(GETDATE() AS DATE);

        ---------------------------------------------------------
        -- Remove Locker Allocation
        ---------------------------------------------------------
        DELETE LA
        FROM tblLockerAllocation LA
        INNER JOIN tblMembershipSubscription MS
            ON LA.MemberId = MS.MemberId
        WHERE MS.MemberSubscriptionId =
        (
            SELECT MAX(MemberSubscriptionId)
            FROM tblMembershipSubscription
            WHERE MemberId = LA.MemberId
        )
        AND MS.IsActive = 0
        AND DATEADD(MONTH,3,MS.ExpiryDate) < CAST(GETDATE() AS DATE);

        COMMIT TRANSACTION;

        SELECT 'Inactive members processed successfully.' AS Message;

    END TRY

    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO

-------------------------------
  --SP: spExpireMembership--
-------------------------------
CREATE PROC spExpireMembership
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Expire memberships
        UPDATE MS
        SET MS.IsActive = 0
        FROM tblMembershipSubscription MS
        WHERE MS.IsActive = 1
          AND MS.ExpiryDate < CAST(GETDATE() AS DATE);

        -- Deactivate trainer assignment
        UPDATE MTA
        SET MTA.IsActive = 0
        FROM tblMemberTrainerAssignment MTA
        INNER JOIN tblMembershipSubscription MS
            ON MS.MemberId = MTA.MemberId
        WHERE MTA.IsActive = 1
          AND MS.IsActive = 0;

        -- Free only that trainer's shift
        UPDATE TS
        SET TS.IsActive = 1
        FROM tblTrainerShift TS
        INNER JOIN tblMemberTrainerAssignment MTA
            ON TS.TrainerId = MTA.TrainerId
           AND TS.ShiftId = MTA.ShiftId
        WHERE TS.IsActive = 0
          AND MTA.IsActive = 0;

        COMMIT TRANSACTION;

        SELECT 'Expired memberships processed successfully.' AS Message;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        THROW;
    END CATCH
END;
GO

---------------------------------
  --SP: spRetrieveActiveMembers--
---------------------------------
CREATE PROC spRetrieveAllMemberDetails
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT
            M.MemberId,
            M.FirstName + ' ' +
            ISNULL(M.MiddleName + ' ', '') +
            M.LastName AS MemberName,
            M.PhoneNo,
            M.IsActive AS MemberIsActive
        FROM tblMember M
        ORDER BY M.IsActive DESC,
        M.JoiningDate DESC;
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message;
    END CATCH
END;
GO

----------------------------------------
  --SP: spRetrieveActiveMembersByShift--
----------------------------------------
CREATE PROC spRetrieveActiveMembersByShift 
(
    @ShiftId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblShift
            WHERE ShiftId = @ShiftId
        )
        BEGIN
            SELECT 'Invalid Shift.' AS Message;
            RETURN;
        END;
        SELECT
            M.MemberId,
            CONCAT(M.FirstName, ' ', M.LastName) AS MemberName,
            M.PhoneNo,
            M.EmailId
        FROM tblMemberShift MS
        INNER JOIN tblMember M
            ON MS.MemberId = M.MemberId
        WHERE MS.ShiftId = @ShiftId
          AND MS.IsActive = 1
          AND M.IsActive = 1
        ORDER BY M.FirstName, M.LastName;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO

------------------------------------------------------
  --SP: spRetrieveAllMemberTrainerAssignmentsDetails--
------------------------------------------------------
CREATE PROC spRetrieveAllMemberTrainerAssignmentsDetails
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        CONCAT(
            m.FirstName+' ', 
            ISNULL(m.MiddleName + ' ', ''), 
            m.LastName
        ) AS MemberName,
        m.PhoneNo,
        CONCAT(
            e.FirstName+' ', 
            ISNULL(e.MiddleName + ' ', ''), 
            e.LastName
        ) AS TrainerName
    FROM tblMemberTrainerAssignment mta
    JOIN tblMember m 
        ON mta.MemberId = m.MemberId
        AND mta.IsActive = 1
    JOIN tblTrainer t 
        ON mta.TrainerId = t.TrainerId 
    JOIN tblEmployee e 
        ON t.EmployeeId = e.EmployeeId
        AND e.IsActive = 1 
    ORDER BY mta.MemberTrainerAssignmentId;
END
GO

-----------------------------------------------
  --SP: spRetrieveCurrentMonthNewMemberCount--
-----------------------------------------------
CREATE PROC spRetrieveCurrentMonthNewMemberCount
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT
            COUNT(MemberId) AS TotalNewMembers
        FROM tblMember
        WHERE
            MONTH(JoiningDate) = MONTH(GETDATE())
            AND YEAR(JoiningDate) = YEAR(GETDATE())
            AND IsActive = 1;

    END TRY
    BEGIN CATCH

        SELECT
            ERROR_MESSAGE() AS ErrorMessage;

    END CATCH
END;
GO

--------------------------------------
  --SP: spRetrieveMemberCurrentShift--
--------------------------------------
CREATE PROC spRetrieveMemberCurrentShift 
(
    @MemberId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMember
            WHERE MemberId = @MemberId
        )
        BEGIN
            SELECT 'Invalid Member.' AS Message;
            RETURN;
        END;
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMemberShift
            WHERE MemberId = @MemberId
              AND IsActive = 1
        )
        BEGIN
            SELECT 'No Active Shift Assigned To This Member.' AS Message;
            RETURN;
        END;
        SELECT
            M.MemberId,
            CONCAT
            (
                M.FirstName, ' ',
                ISNULL(M.MiddleName + ' ', ''),
                M.LastName
            ) AS MemberName,
            S.ShiftId,
            S.ShiftName,
            S.StartTime,
            S.EndTime
        FROM tblMember M
        INNER JOIN tblMemberShift MS
            ON M.MemberId = MS.MemberId
        INNER JOIN tblShift S
            ON MS.ShiftId = S.ShiftId
        WHERE M.MemberId = @MemberId
          AND MS.IsActive = 1;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO

-----------------------------------------
  --SP: spRetrieveMemberIdByPhoneNumber--
-----------------------------------------
CREATE PROC spRetrieveMemberIdByPhoneNumber
(
    @PhoneNo VARCHAR(20)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        SET @PhoneNo = LTRIM(RTRIM(@PhoneNo));
        IF @PhoneNo = ''
        BEGIN
            SELECT 'Phone Number is required.' AS Message;
            RETURN;
        END;
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

------------------------------------------------------------------
  --SP: spRetrieveMemberTrainerAssignmentsDetailsByMemberPhoneNo--
------------------------------------------------------------------
CREATE PROC spRetrieveMemberTrainerAssignmentsDetailsByMemberPhoneNo  
(  
    @Search VARCHAR(100)  
)  
AS  
BEGIN  
    SET NOCOUNT ON;  
  
    BEGIN TRY  
  
        SET @Search = LTRIM(RTRIM(@Search));  
  
        SELECT  
            CONCAT(  
                m.FirstName, ' ',  
                ISNULL(m.MiddleName + ' ', ''),  
                m.LastName  
            ) AS MemberName,  
  
            m.PhoneNo,  
  
            CONCAT(  
                e.FirstName, ' ',  
                ISNULL(e.MiddleName + ' ', ''),  
                e.LastName  
            ) AS TrainerName  
  
        FROM tblMemberTrainerAssignment mta  
  
        INNER JOIN tblMember m  
            ON mta.MemberId = m.MemberId  
            AND m.IsActive = 1  
  
        INNER JOIN tblTrainer t  
            ON mta.TrainerId = t.TrainerId  
            AND mta.IsActive = 1  
  
        INNER JOIN tblEmployee e  
            ON t.EmployeeId = e.EmployeeId  
            AND e.IsActive = 1  
  
        WHERE  
            (  
                m.FirstName LIKE @Search + '%'  
                OR m.MiddleName LIKE @Search + '%'  
                OR m.LastName LIKE @Search + '%'  
                OR m.PhoneNo LIKE @Search + '%'  
                OR e.FirstName LIKE @Search + '%'  
                OR e.MiddleName LIKE @Search + '%'  
                OR e.LastName LIKE @Search + '%'  
            )  
  
        ORDER BY  
            mta.MemberTrainerAssignmentId;  
  
    END TRY  
  
    BEGIN CATCH  
  
        SELECT ERROR_MESSAGE() AS Message;  
  
    END CATCH  
END;
GO
-----------------------------------------
  --SP: spRetrieveAllMemberDetails--
-----------------------------------------
CREATE PROC spRetrieveRegisterMemberDetailsByMemberId
(
    @MemberId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMember
            WHERE MemberId = @MemberId
        )
        BEGIN
            SELECT 'Invalid Member ID.' AS Message;
            RETURN;
        END

        SELECT

            M.MemberId,

            M.FirstName + ' ' +
            ISNULL(M.MiddleName + ' ', '') +
            M.LastName AS MemberName,

            G.GenderName AS Gender,

            M.PhoneNo,
            M.EmailId,

            M.City,
            M.District,
            M.State,

            M.EmergencyContact,

            M.ProfilePhoto,

            M.JoiningDate,
            M.UpdatedAt,
            M.IsActive AS MemberStatus,

            -----------------------------
            -- Membership
            -----------------------------
            MP.MembershipPlanId,
            MP.MembershipPlanName,
            MS.StartDate,
            MS.ExpiryDate,

            -----------------------------
            -- Shift
            -----------------------------
            S.ShiftId,
            S.ShiftName,
            S.StartTime,
            S.EndTime,

            -----------------------------
            -- Diet Plan
            -----------------------------
            Dp.DietPlanId,
            DP.CaloriesPerDay,
            DP.ConditionStatus,
            DP.DietPlanDocument,

            -----------------------------
            -- Trainer
            -----------------------------
            T.TrainerId,

            E.FirstName + ' ' +
            ISNULL(E.MiddleName + ' ', '') +
            E.LastName AS TrainerName,

            E.PhoneNo AS TrainerPhoneNo,
            E.EmailId AS TrainerEmailId,

            T.TrainerType,
            T.Specialization,

            MTA.AssignedDate,

            -----------------------------
            -- Locker
            -----------------------------
            L.LockerId,
            L.LockerNo,
            L.LockerStatus,
            -----------------------------
            -- Payment
            -----------------------------
            SP.PaymentDate,
            SP.PaymentMethod,
            SP.Amount,
            SP.FeesType

        FROM tblMember M

        LEFT JOIN tblGender G
            ON M.GenderId = G.GenderId

        -----------------------------
        -- Membership
        -----------------------------

        LEFT JOIN tblMembershipSubscription MS
            ON M.MemberId = MS.MemberId
            AND MS.IsActive = 1

        LEFT JOIN tblMembershipPlans MP
            ON MS.MembershipPlanId = MP.MembershipPlanId

        -----------------------------
        -- Shift
        -----------------------------

        LEFT JOIN tblMemberShift MSH
            ON M.MemberId = MSH.MemberId
            AND MSH.IsActive = 1

        LEFT JOIN tblShift S
            ON MSH.ShiftId = S.ShiftId

        -----------------------------
        -- Diet
        -----------------------------

        LEFT JOIN tblMemberDietAssignment MDA
            ON M.MemberId = MDA.MemberId
            AND MDA.IsActive = 1

        LEFT JOIN tblDietPlans DP
            ON MDA.DietPlanId = DP.DietPlanId

        -----------------------------
        -- Trainer
        -----------------------------

        LEFT JOIN tblMemberTrainerAssignment MTA
            ON M.MemberId = MTA.MemberId
            AND MTA.IsActive = 1

        LEFT JOIN tblTrainer T
            ON MTA.TrainerId = T.TrainerId

        LEFT JOIN tblEmployee E
            ON T.EmployeeId = E.EmployeeId
            AND E.IsActive = 1

        -----------------------------
        -- Locker
        -----------------------------

        LEFT JOIN tblLockerAllocation LA
            ON M.MemberId = LA.MemberId

        LEFT JOIN tblLocker L
            ON LA.LockerId = L.LockerId

        -----------------------------
        -- Payment
        -----------------------------

        LEFT JOIN tblSubscriptionPayment SP
            ON M.MemberId = SP.MemberId

        WHERE M.MemberId = @MemberId;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH

END;

-----------------------------------------
  --SP: spUpdateMemberContactInfo--
-----------------------------------------
CREATE PROC spUpdateMemberContactInfo
(
    @MemberId INT,
    @PhoneNo VARCHAR(20),
    @EmailId VARCHAR(150) = NULL,
    @EmergencyContact VARCHAR(20) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        -- 1. Check member exists
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMember
            WHERE MemberId = @MemberId
        )
        BEGIN
            SELECT 'Member not found' AS Message;
            RETURN;
        END;

        -- 2. Phone validation
        IF @PhoneNo IS NULL
           OR LEN(@PhoneNo) < 10
        BEGIN
            SELECT 'Invalid phone number' AS Message;
            RETURN;
        END;

        -- 3. Duplicate phone check
        IF EXISTS
        (
            SELECT 1
            FROM tblMember
            WHERE PhoneNo = @PhoneNo
              AND MemberId <> @MemberId
        )
        BEGIN
            SELECT 'Phone number already exists' AS Message;
            RETURN;
        END;

        -- 4. Email format check
        IF @EmailId IS NOT NULL
           AND @EmailId NOT LIKE '%_@_%._%'
        BEGIN
            SELECT 'Invalid email format' AS Message;
            RETURN;
        END;

        -- 5. Duplicate email check
        IF @EmailId IS NOT NULL
           AND EXISTS
           (
               SELECT 1
               FROM tblMember
               WHERE EmailId = @EmailId
                 AND MemberId <> @MemberId
           )
        BEGIN
            SELECT 'Email already exists' AS Message;
            RETURN;
        END;

        -- 6. Emergency contact validation
        IF @EmergencyContact IS NOT NULL
           AND LEN(@EmergencyContact) < 10
        BEGIN
            SELECT 'Invalid emergency contact' AS Message;
            RETURN;
        END;

        -- 7. Update
        UPDATE tblMember
        SET
            PhoneNo = @PhoneNo,
            EmailId = @EmailId,
            EmergencyContact = @EmergencyContact,
            UpdatedAt = GETDATE()
        WHERE MemberId = @MemberId;

        -- Success response
        SELECT 'Member updated successfully' AS Message;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH

END;
GO

-------------------------------------------------
  --SP: spRetrieveMembersWithoutActiveMembership--
--------------------------------------------------
CREATE PROC spRetrieveMembersWithoutActiveMembership
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT
            M.MemberId,
            m.FirstName + ' ' + ISNULL(m.MiddleName + ' ', '') + m.LastName AS MemberName,
            M.PhoneNo,
            M.EmailId,
            M.City,
            M.District,
            M.State,
            M.EmergencyContact,
            M.ProfilePhoto,
            M.JoiningDate,
            M.UpdatedAt
        FROM tblMember M
        WHERE M.IsActive = 1
          AND NOT EXISTS
          (
              SELECT 1
              FROM tblMembershipSubscription MS
              WHERE MS.MemberId = M.MemberId
                AND MS.IsActive = 1
          );

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO

-------------------------------------------------------------------------------
                   -- SubscriptionPaymentManagement SPs --
-------------------------------------------------------------------------------

--------------------------------------------------------------
  --SP: spGetAllMemberSubscriptionPaymentDetails--
--------------------------------------------------------------
CREATE PROC spGetAllMemberSubscriptionPaymentDetails
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        m.FirstName + ' ' + 
        ISNULL(m.MiddleName + ' ', '') + 
        m.LastName AS MemberName,
        mp.MembershipPlanName,
        s.PaymentDate,
        s.PaymentMethod,
        s.Amount,
        s.FeesType
    FROM tblSubscriptionPayment s
    INNER JOIN tblMembershipPlans mp
        ON s.MembershipPlanId = mp.MembershipPlanId
    INNER JOIN tblMember m
        ON s.MemberId = m.MemberId
    ORDER BY s.PaymentDate DESC;
END
GO
---------------------------------------------
  --SP: spGetSubscriptionHistoryByPhoneNo--
---------------------------------------------
CREATE PROC spGetSubscriptionHistoryByPhoneNo 
    @PhoneNo VARCHAR(10)
AS
BEGIN
	SET NOCOUNT ON;

	IF @PhoneNo IS NOT NULL AND LTRIM(RTRIM(@PhoneNo)) <> ''
		BEGIN
			SELECT 
				s.PaymentId,
				s.MemberId,
				CONCAT(
                    m.FirstName, 
                    CASE WHEN m.MiddleName IS NOT NULL THEN ' ' + m.MiddleName ELSE '' END,
                    ' ', m.LastName
                ) AS MemberName,
				
				s.Amount,
				m.EmailId,
				m.PhoneNo,
				mp.MembershipPlanName,
				s.PaymentDate,
				s.PaymentMethod,
				s.FeesType
			FROM tblSubscriptionPayment s 
			JOIN tblMember m
				ON s.MemberId = m.MemberId
			JOIN tblMembershipPlans mp
				ON s.MembershipPlanId = mp.MembershipPlanId
			Where m.PhoneNo = @PhoneNo order by s.PaymentDate desc;
		END
	ELSE
		BEGIN
			SELECT 'Phone number is required.' AS Message
		END
END


---------------------------------------------
  --SP: spGetCurrentMonthTotalIncome--
---------------------------------------------
CREATE PROC spGetCurrentMonthTotalIncome
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CurrentMonth INT = MONTH(GETDATE());
    DECLARE @CurrentYear INT = YEAR(GETDATE());

    DECLARE @TotalIncome DECIMAL(18,2) = 0;
    DECLARE @TotalSalary DECIMAL(18,2) = 0;
    DECLARE @TotalExpense DECIMAL(18,2) = 0;

SELECT
    @TotalIncome = ISNULL(SUM(sp.Amount), 0)
FROM tblSubscriptionPayment sp
WHERE MONTH(sp.PaymentDate) = @CurrentMonth
  AND YEAR(sp.PaymentDate) = @CurrentYear;


    -- Salary Paid
    SELECT
        @TotalSalary = ISNULL(SUM(s.Amount), 0)
    FROM tblSalaryPayment sp
    INNER JOIN tblSalary s
        ON sp.SalaryId = s.SalaryId
    WHERE MONTH(sp.PaymentDate) = @CurrentMonth
      AND YEAR(sp.PaymentDate) = @CurrentYear
      AND sp.PaymentStatus = 'Paid';


    -- Other Expenses
    SELECT
        @TotalExpense = ISNULL(SUM(ExpenseAmount), 0)
    FROM tblExpense
    WHERE MONTH(ExpenseDate) = @CurrentMonth
      AND YEAR(ExpenseDate) = @CurrentYear;


    -- Dashboard Total Income
    SELECT
        (@TotalIncome - @TotalSalary - @TotalExpense) AS TotalIncome;
END;
GO

-----------------------------------------------------------------------------------------------------
  --SP: spGetCurrentYearIncomeExpenseNetRevenue--      SUPER ADMIN DASHBOARD
--------------------------------------------------
CREATE PROC spGetCurrentYearIncomeExpenseNetRevenue  
AS  
BEGIN  
    SET NOCOUNT ON;  
  
    DECLARE @CurrentYear INT = YEAR(GETDATE());  
  
    DECLARE @TotalIncome DECIMAL(18,2) = 0;  
    DECLARE @TotalSalary DECIMAL(18,2) = 0;  
    DECLARE @TotalExpense DECIMAL(18,2) = 0;  
  
  
    -- Current Year Membership Income  
    SELECT  
        @TotalIncome = ISNULL(SUM(sp.Amount), 0)  
    FROM tblSubscriptionPayment sp  
    WHERE YEAR(sp.PaymentDate) = @CurrentYear;  
  
  
    -- Current Year Salary  
    SELECT  
        @TotalSalary = ISNULL(SUM(s.Amount), 0)  
    FROM tblSalaryPayment sp  
    INNER JOIN tblSalary s  
        ON sp.SalaryId = s.SalaryId  
    WHERE YEAR(sp.PaymentDate) = @CurrentYear  
      AND sp.PaymentStatus = 'Paid';  
  
  
    -- Current Year Other Expense  
    SELECT  
        @TotalExpense = ISNULL(SUM(e.ExpenseAmount), 0)  
    FROM tblExpense e  
    WHERE YEAR(e.ExpenseDate) = @CurrentYear;  
  
  
    -- Final Result  
    SELECT  
        @TotalIncome AS TotalIncome,  
        (@TotalSalary + @TotalExpense) AS TotalExpense,  
        (  
            @TotalIncome  
            - @TotalSalary  
            - @TotalExpense  
        ) AS NetRevenue;  
  
END;  
GO

------------------------------
  --SP: spTotalMontlyIncome--
------------------------------
CREATE PROC spTotalMontlyIncome
AS
BEGIN
DECLARE @CurrentMonth INT = MONTH(GETDATE());
DECLARE @CurrentYear INT = YEAR(GETDATE());
DECLARE @Income DECIMAL(18,2);
    -- Membership Income
  SELECT
    @Income = ISNULL(SUM(sp.Amount), 0)
FROM tblSubscriptionPayment sp
WHERE MONTH(sp.PaymentDate) = @CurrentMonth
  AND YEAR(sp.PaymentDate) = @CurrentYear;
SELECT @Income AS TotalIncome
END
GO
---------------------------------------------------
  --SP: spGetCurrentMonthIncomeExpenseNetRevenue--
--------------------------------------------------
CREATE PROC spGetCurrentMonthIncomeExpenseNetRevenue
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CurrentMonth INT = MONTH(GETDATE());
    DECLARE @CurrentYear INT = YEAR(GETDATE());

    DECLARE @TotalIncome DECIMAL(18,2) = 0;
    DECLARE @TotalSalary DECIMAL(18,2) = 0;
    DECLARE @TotalExpense DECIMAL(18,2) = 0;

    -- Current Month Membership Income
    SELECT
        @TotalIncome = ISNULL(SUM(sp.Amount), 0)
    FROM tblSubscriptionPayment sp
    WHERE MONTH(sp.PaymentDate) = @CurrentMonth
      AND YEAR(sp.PaymentDate) = @CurrentYear;


    -- Current Month Salary
    SELECT
        @TotalSalary = ISNULL(SUM(s.Amount), 0)
    FROM tblSalaryPayment sp
    INNER JOIN tblSalary s
        ON sp.SalaryId = s.SalaryId
    WHERE MONTH(sp.PaymentDate) = @CurrentMonth
      AND YEAR(sp.PaymentDate) = @CurrentYear
      AND sp.PaymentStatus = 'Paid';


    -- Current Month Other Expense
    SELECT
        @TotalExpense = ISNULL(SUM(e.ExpenseAmount), 0)
    FROM tblExpense e
    WHERE MONTH(e.ExpenseDate) = @CurrentMonth
      AND YEAR(e.ExpenseDate) = @CurrentYear;


    -- Final Result
    SELECT
        @TotalIncome AS TotalIncome,
        (@TotalSalary + @TotalExpense) AS TotalExpense,
        (
            @TotalIncome
            - @TotalSalary
            - @TotalExpense
        ) AS NetRevenue;

END;
GO

---------------------------------------------
  --SP: spGetCurrentMonthFinancialSummary--
---------------------------------------------
CREATE PROC spGetCurrentMonthFinancialSummary  
AS  
BEGIN  
    SET NOCOUNT ON;  
  
    DECLARE @CurrentMonth INT = MONTH(GETDATE());  
    DECLARE @CurrentYear INT = YEAR(GETDATE());  
  
    DECLARE @Income DECIMAL(18,2);  
    DECLARE @Expense DECIMAL(18,2);  
    DECLARE @Salary DECIMAL(18,2);  
  
    -- Membership Income  
  SELECT  
    @Income = ISNULL(SUM(sp.Amount), 0)  
FROM tblSubscriptionPayment sp  
WHERE MONTH(sp.PaymentDate) = @CurrentMonth  
  AND YEAR(sp.PaymentDate) = @CurrentYear;  
  
  
    -- Expense  
    SELECT  
        @Expense = ISNULL(SUM(ExpenseAmount), 0)  
    FROM tblExpense  
    WHERE MONTH(ExpenseDate) = @CurrentMonth  
      AND YEAR(ExpenseDate) = @CurrentYear;  
  
  
    -- Salary  
    SELECT  
        @Salary = ISNULL(SUM(s.Amount), 0)  
    FROM tblSalaryPayment sp  
    INNER JOIN tblSalary s  
        ON sp.SalaryId = s.SalaryId  
    WHERE MONTH(sp.PaymentDate) = @CurrentMonth  
      AND YEAR(sp.PaymentDate) = @CurrentYear  
      AND sp.PaymentStatus = 'Paid';  
  
  
    -- Dashboard Doughnut Chart Data  
    SELECT  
        @Income AS Income,  
        @Expense AS Expense,  
        @Salary AS Salary;  
END;  
GO

-----------------------------------------------------------
  --SP: spGetMonthlyIncomeExpenseNetRevenueOfCurrentYear--****
-----------------------------------------------------------
CREATE PROC spGetMonthlyIncomeExpenseNetRevenueOfCurrentYear    
AS    
BEGIN    
    SET NOCOUNT ON;    
    
    DECLARE @CurrentYear INT = YEAR(GETDATE());    
    
    ;WITH Months AS    
    (    
        SELECT 1 AS MonthId, 1 AS MonthNumber, 'Jan' AS MonthName    
        UNION ALL SELECT 2, 2, 'Feb'    
        UNION ALL SELECT 3, 3, 'Mar'    
        UNION ALL SELECT 4, 4, 'Apr'    
        UNION ALL SELECT 5, 5, 'May'    
        UNION ALL SELECT 6, 6, 'Jun'    
        UNION ALL SELECT 7, 7, 'Jul'    
        UNION ALL SELECT 8, 8, 'Aug'    
        UNION ALL SELECT 9, 9, 'Sep'    
        UNION ALL SELECT 10, 10, 'Oct'    
        UNION ALL SELECT 11, 11, 'Nov'    
        UNION ALL SELECT 12, 12, 'Dec'    
    ),    
    
    MonthlyIncome AS    
    (    
        SELECT    
            MONTH(sp.PaymentDate) AS MonthNumber,    
            SUM(sp.Amount) AS Income    
        FROM tblSubscriptionPayment sp    
        WHERE YEAR(sp.PaymentDate) = @CurrentYear    
        GROUP BY MONTH(sp.PaymentDate)    
    ),    
    
    MonthlySalary AS    
    (    
        SELECT    
            MONTH(sp.PaymentDate) AS MonthNumber,    
            SUM(s.Amount) AS Salary    
        FROM tblSalaryPayment sp    
        INNER JOIN tblSalary s    
            ON sp.SalaryId = s.SalaryId    
        WHERE YEAR(sp.PaymentDate) = @CurrentYear    
          AND sp.PaymentStatus = 'Paid'    
        GROUP BY MONTH(sp.PaymentDate)    
    ),    
    
    MonthlyExpense AS    
    (    
        SELECT    
            MONTH(e.ExpenseDate) AS MonthNumber,    
            SUM(e.ExpenseAmount) AS Expense    
        FROM tblExpense e    
        WHERE YEAR(e.ExpenseDate) = @CurrentYear    
        GROUP BY MONTH(e.ExpenseDate)    
    )    
    
    SELECT    
        m.MonthId,    
        m.MonthName,    
    
        -- Total Subscription Income    
        ISNULL(i.Income, 0) AS TotalIncome,    
    
        -- Total Expense = Salary + Other Expense    
        ISNULL(s.Salary, 0)    
        + ISNULL(e.Expense, 0) AS TotalExpense,    
    
        -- Net Revenue = Income - Salary - Other Expense    
        ISNULL(i.Income, 0)    
        - ISNULL(s.Salary, 0)    
        - ISNULL(e.Expense, 0) AS NetRevenue    
    
    FROM Months m    
    
    LEFT JOIN MonthlyIncome i    
        ON m.MonthNumber = i.MonthNumber    
    
    LEFT JOIN MonthlySalary s    
        ON m.MonthNumber = s.MonthNumber    
    
    LEFT JOIN MonthlyExpense e    
        ON m.MonthNumber = e.MonthNumber    
    
    ORDER BY m.MonthNumber;    
    
END;  
GO
---------------------------------------------------------------------------------------
  --SP: spGetMonthlyIncomeExpenseNetRevenueByYear--        SUPER ADMIN PROFIT LOSS  
---------------------------------------------------
CREATE PROC spGetMonthlyIncomeExpenseNetRevenueByYear    
(    
    @Year INT    
)    
AS    
BEGIN    
    SET NOCOUNT ON;    
    
    ;WITH Months AS    
    (    
        SELECT 1 AS MonthNumber, 'January' AS MonthName    
        UNION ALL SELECT 2, 'February'    
        UNION ALL SELECT 3, 'March'    
        UNION ALL SELECT 4, 'April'    
        UNION ALL SELECT 5, 'May'    
        UNION ALL SELECT 6, 'June'    
        UNION ALL SELECT 7, 'July'    
        UNION ALL SELECT 8, 'August'    
        UNION ALL SELECT 9, 'September'    
        UNION ALL SELECT 10, 'October'    
        UNION ALL SELECT 11, 'November'    
        UNION ALL SELECT 12, 'December'    
    ),    
    
    MonthlyIncome AS    
    (    
        SELECT    
            MONTH(sp.PaymentDate) AS MonthNumber,    
            SUM(sp.Amount) AS Income    
        FROM tblSubscriptionPayment sp    
        WHERE YEAR(sp.PaymentDate) = @Year    
        GROUP BY MONTH(sp.PaymentDate)    
    ),    
    
    MonthlySalary AS    
    (    
        SELECT    
            MONTH(sp.PaymentDate) AS MonthNumber,    
            SUM(s.Amount) AS Salary    
        FROM tblSalaryPayment sp    
        INNER JOIN tblSalary s    
            ON sp.SalaryId = s.SalaryId    
        WHERE YEAR(sp.PaymentDate) = @Year    
          AND sp.PaymentStatus = 'Paid'    
        GROUP BY MONTH(sp.PaymentDate)    
    ),    
    
    MonthlyExpense AS    
    (    
        SELECT    
            MONTH(e.ExpenseDate) AS MonthNumber,    
            SUM(e.ExpenseAmount) AS Expense    
        FROM tblExpense e    
        WHERE YEAR(e.ExpenseDate) = @Year    
        GROUP BY MONTH(e.ExpenseDate)    
    )    
    
    SELECT    
        m.MonthNumber AS MonthId,    
        m.MonthName,    
    
        -- Total Income    
        ISNULL(i.Income, 0) AS TotalIncome,    
    
        -- Total Expense = Salary + Other Expense    
        ISNULL(s.Salary, 0)    
        + ISNULL(e.Expense, 0) AS TotalExpense,    
    
        -- Net Revenue = Income - Total Expense    
        ISNULL(i.Income, 0)    
        - ISNULL(s.Salary, 0)    
        - ISNULL(e.Expense, 0) AS NetRevenue    
    
    FROM Months m    
    
    LEFT JOIN MonthlyIncome i    
        ON m.MonthNumber = i.MonthNumber    
    
    LEFT JOIN MonthlySalary s    
        ON m.MonthNumber = s.MonthNumber    
    
    LEFT JOIN MonthlyExpense e    
        ON m.MonthNumber = e.MonthNumber    
    
    ORDER BY m.MonthNumber;    
    
END;
GO

---------------------------------------------------------------
  --SP: spGetIncomeExpenseNetRevenueForRevenueSectionByYear--
---------------------------------------------------------------
CREATE PROC spGetIncomeExpenseNetRevenueForRevenueSectionByYear
(    
    @Year INT    
)    
AS    
BEGIN    
    SET NOCOUNT ON;    
    
    DECLARE @TotalIncome DECIMAL(18,2) = 0;    
    DECLARE @TotalSalary DECIMAL(18,2) = 0;    
    DECLARE @TotalExpense DECIMAL(18,2) = 0;    
    
    -- Selected Year Membership Income    
    SELECT    
        @TotalIncome = ISNULL(SUM(sp.Amount), 0)    
    FROM tblSubscriptionPayment sp    
    WHERE YEAR(sp.PaymentDate) = @Year;    
    
    -- Selected Year Salary    
    SELECT    
        @TotalSalary = ISNULL(SUM(s.Amount), 0)    
    FROM tblSalaryPayment sp    
    INNER JOIN tblSalary s    
        ON sp.SalaryId = s.SalaryId    
    WHERE YEAR(sp.PaymentDate) = @Year    
      AND sp.PaymentStatus = 'Paid';    
    
    -- Selected Year Other Expense    
    SELECT    
        @TotalExpense = ISNULL(SUM(e.ExpenseAmount), 0)    
    FROM tblExpense e    
    WHERE YEAR(e.ExpenseDate) = @Year;    
    
    -- Final Result    
    SELECT    
        @Year AS CurrentYear,    
        @TotalIncome AS TotalIncome,    
        (@TotalSalary + @TotalExpense) AS TotalExpense,    
        (    
            @TotalIncome    
            - @TotalSalary    
            - @TotalExpense    
        ) AS NetRevenue,    
        (    
            @TotalIncome    
            - @TotalSalary    
            - @TotalExpense    
        ) / 12.0 AS AverageMonthlyNetRevenue;    
END;    
GO


------------------------------------------------------------------------------------------------
  --SP: spRetrieveSubscriptionPaymentDetailsBetweenDateRange--
--------------------------------------------------------------
CREATE PROC spRetrieveSubscriptionPaymentDetailsBetweenDateRange 
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        IF @StartDate IS NULL OR @EndDate IS NULL
        BEGIN
            SELECT 'Both StartDate and EndDate are required.' AS Message;
            RETURN;
        END

        IF @StartDate > @EndDate
        BEGIN
            SELECT 'StartDate cannot be later than EndDate.' AS Message;
            RETURN;
        END

        SELECT 
            sp.PaymentId,
            sp.MemberId,
            CONCAT(
                m.FirstName,
                CASE
                    WHEN m.MiddleName IS NOT NULL
                         AND LTRIM(RTRIM(m.MiddleName)) <> ''
                    THEN ' ' + m.MiddleName
                    ELSE ''
                END,
                ' ',
                m.LastName
            ) AS MemberName,
            m.EmailId,
            sp.MembershipPlanId,
            mp.MembershipPlanName,
            ms.StartDate,
            ms.ExpiryDate,
            sp.PaymentDate,
            sp.PaymentMethod,
            sp.Amount,
            sp.FeesType
        FROM tblSubscriptionPayment sp
        INNER JOIN tblMember m
            ON sp.MemberId = m.MemberId
        INNER JOIN tblMembershipPlans mp
            ON sp.MembershipPlanId = mp.MembershipPlanId
        INNER JOIN tblMembershipSubscription ms
            ON sp.MemberSubscriptionId = ms.MemberSubscriptionId
        WHERE sp.PaymentDate BETWEEN @StartDate AND @EndDate
        ORDER BY sp.PaymentDate DESC, sp.PaymentId DESC;

    END TRY
    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO

---------------------------------------------------------------
  --SP: spRetrieveTotalPaidSubscriptionAmountBetweenDateRange--
---------------------------------------------------------------
CREATE PROC spRetrieveTotalPaidSubscriptionAmountBetweenDateRange 
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        IF @StartDate IS NULL OR @EndDate IS NULL
        BEGIN
            SELECT 'Both StartDate and EndDate are required.' AS Message;
            RETURN;
        END

        IF @StartDate > @EndDate
        BEGIN
            SELECT 'StartDate cannot be later than EndDate.' AS Message;
            RETURN;
        END

        SELECT 
            SUM(sp.Amount) AS TotalRevenue
        FROM tblSubscriptionPayment sp
        JOIN tblMembershipPlans mp 
            ON sp.MembershipPlanId = mp.MembershipPlanId
        JOIN tblMember m 
            ON sp.MemberId = m.MemberId
        WHERE 
            sp.PaymentDate BETWEEN @StartDate AND @EndDate;

    END TRY
    BEGIN CATCH

        SELECT 
            ERROR_MESSAGE() AS Message;
    END CATCH
END
GO

----------------------------------------------------
  --SP: spRetrieveSubscriptionPaymentDetailsByYear--
----------------------------------------------------
CREATE PROC spRetrieveSubscriptionPaymentDetailsByYear
    @Year INT
AS
BEGIN
    SET NOCOUNT ON;

    IF @Year IS NOT NULL
    BEGIN
        SELECT
            s.PaymentId,
            s.MemberId,
            CONCAT(
                m.FirstName,
                CASE
                    WHEN m.MiddleName IS NOT NULL
                         AND LTRIM(RTRIM(m.MiddleName)) <> ''
                    THEN ' ' + m.MiddleName
                    ELSE ''
                END,
                ' ',
                m.LastName
            ) AS MemberName,
            s.PaymentDate,
            s.PaymentMethod,
            s.Amount,
            m.EmailId,
            mp.MembershipPlanName,
            ms.StartDate,
            ms.ExpiryDate,
            s.FeesType
        FROM tblSubscriptionPayment s
        INNER JOIN tblMember m
            ON s.MemberId = m.MemberId
        INNER JOIN tblMembershipSubscription ms
            ON s.MemberSubscriptionId = ms.MemberSubscriptionId
        INNER JOIN tblMembershipPlans mp
            ON s.MembershipPlanId = mp.MembershipPlanId
        WHERE YEAR(s.PaymentDate) = @Year
        ORDER BY s.PaymentDate DESC, s.PaymentId DESC;
    END
    ELSE
    BEGIN
        SELECT 'Year is required.' AS Message;
    END
END;
GO

----------------------------------------------------
  --SP: spRetrieveTotalPaidSubscriptionAmountByYear--
----------------------------------------------------
CREATE PROC spRetrieveTotalPaidSubscriptionAmountByYear 
    @Year INT
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        IF @Year IS NULL OR @Year < 1900 OR @Year > YEAR(GETDATE())
            BEGIN
                SELECT 
                    'Invalid year. Please provide a valid year (1900 - current year).' AS Message
                RETURN;
            END

        SELECT 
            SUM(sp.Amount) AS YearlyRevenue
        FROM tblSubscriptionPayment sp
        JOIN tblMembershipPlans mp 
            ON sp.MembershipPlanId = mp.MembershipPlanId
        JOIN tblMember m 
            ON sp.MemberId = m.MemberId
        WHERE 
           FORMAT(sp.PaymentDate, 'yyyy') = CAST(@Year AS VARCHAR(4))
    END TRY
    BEGIN CATCH
       SELECT ERROR_MESSAGE() AS Message
    END CATCH
END
GO

----------------------------------------------------
  --SP: spGetSubscriptionPaymentDetailsByMonth--
----------------------------------------------------
CREATE PROC spRetrieveSubscriptionPaymentDetailsByMonth
    @Month INT,
    @Year INT
AS
BEGIN
    SET NOCOUNT ON;

    IF @Month IS NULL OR @Month NOT BETWEEN 1 AND 12
    BEGIN
        SELECT 'INVALID MONTH' AS Message;
        RETURN;
    END

    IF @Year IS NULL OR @Year NOT BETWEEN 1900 AND 9999
    BEGIN
        SELECT 'INVALID YEAR' AS Message;
        RETURN;
    END

    SELECT 
        s.PaymentId,
        s.MemberId,
        CONCAT(
            m.FirstName,
            CASE
                WHEN m.MiddleName IS NOT NULL
                     AND LTRIM(RTRIM(m.MiddleName)) <> ''
                THEN ' ' + m.MiddleName
                ELSE ''
            END,
            ' ',
            m.LastName
        ) AS MemberName,
        s.PaymentDate,
        s.PaymentMethod,
        s.Amount,
        m.EmailId,
        mp.MembershipPlanName,
        ms.StartDate,
        ms.ExpiryDate,
        s.FeesType
    FROM tblSubscriptionPayment s
    INNER JOIN tblMember m
        ON s.MemberId = m.MemberId
    INNER JOIN tblMembershipSubscription ms
        ON s.MemberSubscriptionId = ms.MemberSubscriptionId
    INNER JOIN tblMembershipPlans mp
        ON s.MembershipPlanId = mp.MembershipPlanId
    WHERE MONTH(s.PaymentDate) = @Month
      AND YEAR(s.PaymentDate) = @Year
    ORDER BY s.PaymentDate DESC, s.PaymentId DESC;
END
GO

----------------------------------------------------
  --SP: spRetrieveTotalPaidSubscriptionAmountByYear--
----------------------------------------------------
CREATE PROC spRetrieveTotalPaidSubscriptionAmountByMonth 
    @Month INT,
    @Year INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF @Year IS NULL OR @Year < 1900 OR @Year > YEAR(GETDATE())
            BEGIN
                SELECT 'Invalid year. Please provide a valid year (1900 - current year).' AS Message
                RETURN;
            END

        IF @Month IS NULL OR @Month NOT BETWEEN 1 AND 12
            BEGIN
                SELECT 'Invalid month. Please provide a number between 1 and 12.' AS Message
                RETURN;
            END

        SELECT 
            SUM(sp.Amount) AS TotalRevenueThisMonth
        FROM tblSubscriptionPayment sp
        LEFT JOIN tblMembershipPlans mp 
            ON sp.MembershipPlanId = mp.MembershipPlanId
        LEFT JOIN tblMember m 
            ON sp.MemberId = m.MemberId
        WHERE MONTH(sp.PaymentDate) = @Month
          AND YEAR(sp.PaymentDate) = @Year
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message
    END CATCH
END
GO
----------------------------------------------------
  --SP: spGetSubscriptionPaymentHistoryByMemberId--
----------------------------------------------------
CREATE PROC spGetSubscriptionPaymentHistoryByMemberId 
    @MemberId INT
AS
BEGIN
    SET NOCOUNT ON;

    IF @MemberId IS NOT NULL
    BEGIN
        SELECT
            s.PaymentId,
            s.MemberId,
            CONCAT(
                m.FirstName,
                CASE
                    WHEN m.MiddleName IS NOT NULL AND LTRIM(RTRIM(m.MiddleName)) <> ''
                        THEN ' ' + m.MiddleName
                    ELSE ''
                END,
                ' ',
                m.LastName
            ) AS MemberName,
            s.PaymentDate,
            s.PaymentMethod,
            s.Amount,
            m.EmailId,
            mp.MembershipPlanName,
            ms.StartDate,
            ms.ExpiryDate,
            s.FeesType
        FROM tblSubscriptionPayment s
        INNER JOIN tblMember m
            ON s.MemberId = m.MemberId
        INNER JOIN tblMembershipSubscription ms
            ON s.MemberSubscriptionId = ms.MemberSubscriptionId
        INNER JOIN tblMembershipPlans mp
            ON s.MembershipPlanId = mp.MembershipPlanId
        WHERE s.MemberId = @MemberId
        ORDER BY s.PaymentDate DESC;
    END
    ELSE
    BEGIN
        SELECT 'Member Id is required.' AS Message;
    END
END;
GO


-------------------------------------------------------------------------------
                   -- AttendanceManagement SPs --
-------------------------------------------------------------------------------
-----------------------------------------
  --SP: spRetrieveTodayMemberAttendance--
-----------------------------------------
CREATE PROC spRetrieveTodayMemberAttendance
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT
            s.ShiftId,
            s.ShiftName,
            COUNT(ma.AttendanceId) AS AttendanceCount
        FROM tblShift s
        LEFT JOIN tblMemberAttendance ma
            ON s.ShiftId = ma.ShiftId
            AND ma.AttendanceDate >= CAST(GETDATE() AS DATE)
            AND ma.AttendanceDate < DATEADD(DAY, 1, CAST(GETDATE() AS DATE))
        GROUP BY
            s.ShiftId,
            s.ShiftName
        ORDER BY
            s.ShiftId;

    END TRY

    BEGIN CATCH

        SELECT
            ERROR_MESSAGE() AS Message;

    END CATCH
END
GO
-----------------------------------------------------
  --SP: spRetrieveAbsentMembersOnCurrentDateByShift--
------------------------------------------------------
CREATE  PROC spRetrievePresentAbsentMembersOnCurrentDateByShift  
    @ShiftId INT  
AS  
BEGIN  
    SET NOCOUNT ON;  
  
    BEGIN TRY  
  
        /* ============================================  
           1. Validate ShiftId  
           ============================================ */  
  
        IF @ShiftId IS NULL OR @ShiftId <= 0  
        BEGIN  
            SELECT  
                'Invalid ShiftId. Please provide a valid positive integer.'  
                AS Message;  
            RETURN;  
        END;  
  
  
        /* ============================================  
           2. Check Shift Exists  
           ============================================ */  
  
        IF NOT EXISTS  
        (  
            SELECT 1  
            FROM tblShift  
            WHERE ShiftId = @ShiftId  
        )  
        BEGIN  
            SELECT  
                'ShiftId does not exist in tblShift.'  
                AS Message;  
            RETURN;  
        END;  
  
  
        /* ============================================  
           3. Retrieve Present & Absent Members  
           ============================================ */  
  
        SELECT DISTINCT  
  
            m.MemberId,  
  
            CONCAT(  
                ISNULL(m.FirstName, ''),  
                ' ',  
                ISNULL(m.MiddleName, ''),  
                ' ',  
                ISNULL(m.LastName, '')  
            ) AS MemberName,  
  
            s.ShiftId,  
            s.ShiftName,  
            m.PhoneNo,  
  
            CASE  
                WHEN ma.AttendanceId IS NULL  
                    THEN 'Absent'  
                ELSE 'Present'  
            END AS AttendanceStatus  
  
        FROM tblShift s  
  
        INNER JOIN tblMemberShift ms  
            ON ms.ShiftId = s.ShiftId  
            AND ms.IsActive = 1  
  
        INNER JOIN tblMember m  
            ON m.MemberId = ms.MemberId  
            AND m.IsActive = 1  
  
        LEFT JOIN tblMemberAttendance ma  
            ON ma.MemberId = m.MemberId  
            AND ma.ShiftId = s.ShiftId  
            AND CAST(ma.AttendanceDate AS DATE)  
                = CAST(GETDATE() AS DATE)  
  
        WHERE s.ShiftId = @ShiftId  
  
        ORDER BY  
            AttendanceStatus,  
            MemberName;  
  
    END TRY  
  
    BEGIN CATCH  
  
        SELECT  
            ERROR_MESSAGE() AS Message;  
  
    END CATCH  
END;
GO
-----------------------------------------------------------
  --SP: spRetrieveAbsentPresentMembersOnCurrentDateByShift--
-----------------------------------------------------------
CREATE   PROC spRetrieveAbsentPresentMembersOnCurrentDateByShift  
AS  
BEGIN  
    BEGIN TRY  
  
        DECLARE @CurrentTime TIME = CAST(GETDATE() AS TIME);  
        DECLARE @CurrentDate DATE = CAST(GETDATE() AS DATE);  
        DECLARE @ShiftId INT;  
        SELECT TOP 1  
            @ShiftId = s.ShiftId  
        FROM tblShift s  
        WHERE  
            (   
                s.StartTime < s.EndTime  
                AND @CurrentTime >= s.StartTime  
                AND @CurrentTime < s.EndTime  
            )  
            OR  
            (  
                s.StartTime > s.EndTime  
                AND (  
                    @CurrentTime >= s.StartTime  
                    OR @CurrentTime < s.EndTime  
                )  
            )  
        ORDER BY s.ShiftId;  
        IF @ShiftId IS NULL  
        BEGIN  
            SELECT   
                'No active shift found for current time.' AS Message;  
            RETURN;  
        END;  
        SELECT DISTINCT  
            m.MemberId,  
  
            CONCAT(  
                ISNULL(m.FirstName, ''), ' ',  
                ISNULL(m.MiddleName, ''), ' ',  
                ISNULL(m.LastName, '')  
            ) AS MemberName,  
  
            s.ShiftId,  
            s.ShiftName,  
            m.PhoneNo,  
  
            CASE  
                WHEN ma.AttendanceId IS NULL   
                    THEN 'Absent'  
                ELSE 'Present'  
            END AS AttendanceStatus  
  
        FROM tblShift s  
  
        INNER JOIN tblMemberShift ms  
            ON ms.ShiftId = s.ShiftId  
            AND ms.IsActive = 1  
  
        INNER JOIN tblMember m  
            ON m.MemberId = ms.MemberId  
            AND m.IsActive = 1  
  
        LEFT JOIN tblMemberAttendance ma  
            ON ma.MemberId = m.MemberId  
            AND ma.ShiftId = s.ShiftId  
            AND CAST(ma.AttendanceDate AS DATE) = @CurrentDate  
  
        WHERE s.ShiftId = @ShiftId  
  
        ORDER BY  
            AttendanceStatus,  
            MemberName;  
  
    END TRY  
  
    BEGIN CATCH  
  
        SELECT  
            ERROR_MESSAGE() AS Message;  
  
    END CATCH  
END
GO
--------------------------------
  --SP: spMarkMemberAttendance--
--------------------------------
CREATE PROC spMarkMemberAttendance 
(
    @MemberId INT,
    @ShiftId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        DECLARE @CurrentTime TIME = CAST(GETDATE() AS TIME);
        DECLARE @CurrentShiftId INT;

        SELECT TOP 1
            @CurrentShiftId = ShiftId
        FROM tblShift
        WHERE
            (
                -- Normal Shift
                StartTime < EndTime
                AND @CurrentTime >= StartTime
                AND @CurrentTime < EndTime
            )
            OR
            (
                -- Overnight Shift
                StartTime > EndTime
                AND
                (
                    @CurrentTime >= StartTime
                    OR @CurrentTime < EndTime
                )
            );

        IF @CurrentShiftId IS NULL
        BEGIN
            SELECT 'No active shift found for current time.' AS Message;
            RETURN;
        END;

        IF @ShiftId <> @CurrentShiftId
        BEGIN
            SELECT
                'Member is not in the current shift. Attendance cannot be marked.'
                AS Message;
            RETURN;
        END;

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMember
            WHERE MemberId = @MemberId
        )
        BEGIN
            SELECT 'Invalid Member.' AS Message;
            RETURN;
        END;

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMember
            WHERE MemberId = @MemberId
              AND IsActive = 1
        )
        BEGIN
            SELECT 'Member Is Not Active.' AS Message;
            RETURN;
        END;

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblShift
            WHERE ShiftId = @ShiftId
        )
        BEGIN
            SELECT 'Invalid Shift.' AS Message;
            RETURN;
        END;

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMemberShift
            WHERE MemberId = @MemberId
              AND ShiftId = @ShiftId
              AND IsActive = 1
        )
        BEGIN
            SELECT
                'Attendance Allowed Only In Assigned Active Shift.'
                AS Message;
            RETURN;
        END;

        IF EXISTS
        (
            SELECT 1
            FROM tblMemberAttendance
            WHERE MemberId = @MemberId
              AND ShiftId = @ShiftId
              AND CAST(AttendanceDate AS DATE)
                  = CAST(GETDATE() AS DATE)
        )
        BEGIN
            SELECT
                'Attendance Already Marked For Today.'
                AS Message;
            RETURN;
        END;

        INSERT INTO tblMemberAttendance
        (
            MemberId,
            ShiftId
        )
        VALUES
        (
            @MemberId,
            @ShiftId
        );


        SELECT
            'Attendance Marked Successfully.'
            AS Message;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH

END;
GO

--------------------------------------------------
  --SP: spRetrieveMembersByPhoneNumberAndName--
-------------------------------------------------
CREATE   PROC spRetrieveMembersByPhoneNumberAndName  
(  
    @Search VARCHAR(100) = NULL  
)  
AS  
BEGIN  
    SET NOCOUNT ON;  
  
    BEGIN TRY  
  
        SET @Search = NULLIF(LTRIM(RTRIM(@Search)), '');  
  
        IF @Search IS NULL  
        BEGIN  
  
            DECLARE @CurrentTime TIME = CAST(GETDATE() AS TIME);  
            DECLARE @CurrentShiftId INT;  
  
            SELECT TOP 1  
                @CurrentShiftId = S.ShiftId  
  
            FROM tblShift S  
  
            WHERE  
                (  
                    S.StartTime < S.EndTime  
                    AND @CurrentTime >= S.StartTime  
                    AND @CurrentTime < S.EndTime  
                )  
                OR  
                (  
                    S.StartTime > S.EndTime  
                    AND  
                    (  
                        @CurrentTime >= S.StartTime  
                        OR @CurrentTime < S.EndTime  
                    )  
                )  
  
            ORDER BY S.ShiftId;  
  
            IF @CurrentShiftId IS NULL  
            BEGIN  
  
                SELECT  
                    'No active shift found for current time.' AS Message;  
  
                RETURN;  
  
            END;  
            SELECT  
  
                M.MemberId,  
  
                LTRIM(RTRIM(  
                    CONCAT(  
                        ISNULL(M.FirstName, ''),  
                        ' ',  
                        ISNULL(M.MiddleName, ''),  
                        ' ',  
                        ISNULL(M.LastName, '')  
                    )  
                )) AS MemberName,  
  
                M.PhoneNo,  
  
                S.ShiftId,  
  
                S.ShiftName,  
  
                CASE  
                    WHEN MA.AttendanceId IS NULL  
                        THEN 'Absent'  
                    ELSE 'Present'  
                END AS AttendanceStatus  
  
            FROM tblShift S  
  
            INNER JOIN tblMemberShift MS  
                ON MS.ShiftId = S.ShiftId  
                AND MS.IsActive = 1  
  
            INNER JOIN tblMember M  
                ON M.MemberId = MS.MemberId  
                AND M.IsActive = 1  
  
            LEFT JOIN tblMemberAttendance MA  
                ON MA.MemberId = M.MemberId  
                AND MA.ShiftId = S.ShiftId  
                AND CAST(MA.AttendanceDate AS DATE)  
                    = CAST(GETDATE() AS DATE)  
  
            WHERE S.ShiftId = @CurrentShiftId  
  
            ORDER BY  
                CASE  
                    WHEN MA.AttendanceId IS NOT NULL THEN 1  
                    ELSE 2  
                END,  
                M.FirstName;  
  
            RETURN;  
  
        END;  
  
  
        /* =====================================================  
           MODE 2:  
           @Search has value  
           → Search Member  
           ===================================================== */  
  
        SELECT  
  
            M.MemberId,  
  
            LTRIM(RTRIM(  
                CONCAT(  
                    ISNULL(M.FirstName, ''),  
                    ' ',  
                    ISNULL(M.MiddleName, ''),  
                    ' ',  
                    ISNULL(M.LastName, '')  
                )  
            )) AS MemberName,  
  
            M.PhoneNo,  
  
            S.ShiftId,  
  
            S.ShiftName,  
  
            CASE  
                WHEN MA.AttendanceId IS NULL  
                    THEN 'Absent'  
                ELSE 'Present'  
            END AS AttendanceStatus  
  
        FROM tblMember M  
  
        LEFT JOIN tblMemberShift MS  
            ON MS.MemberId = M.MemberId  
            AND MS.IsActive = 1  
  
        LEFT JOIN tblShift S  
            ON S.ShiftId = MS.ShiftId  
  
        LEFT JOIN tblMemberAttendance MA  
            ON MA.MemberId = M.MemberId  
            AND MA.ShiftId = S.ShiftId  
            AND CAST(MA.AttendanceDate AS DATE)  
                = CAST(GETDATE() AS DATE)  
  
        WHERE  
            (  
                -- Full Name  
                LTRIM(RTRIM(  
                    CONCAT(  
                        ISNULL(M.FirstName, ''),  
                        ' ',  
                        ISNULL(M.MiddleName, ''),  
                        ' ',  
                        ISNULL(M.LastName, '')  
                    )  
                )) LIKE '%' + @Search + '%'  
  
                OR  
  
                -- First Name  
                M.FirstName LIKE '%' + @Search + '%'  
  
                OR  
  
                -- Middle Name  
                M.MiddleName LIKE '%' + @Search + '%'  
  
                OR  
  
                -- Last Name  
                M.LastName LIKE '%' + @Search + '%'  
  
                OR  
  
                -- Phone Number  
                M.PhoneNo LIKE '%' + @Search + '%'  
            )  
  
            AND M.IsActive = 1  
  
        ORDER BY  
  
            CASE  
  
                -- 1. Phone Number  
                WHEN M.PhoneNo LIKE @Search + '%'  
                    THEN 1  
  
                -- 2. First Name  
                WHEN M.FirstName LIKE @Search + '%'  
                    THEN 2  
  
                -- 3. Middle Name  
                WHEN M.MiddleName LIKE @Search + '%'  
                    THEN 3  
  
                -- 4. Last Name  
                WHEN M.LastName LIKE @Search + '%'  
                    THEN 4  
  
                -- 5. Full Name  
                WHEN LTRIM(RTRIM(  
                    CONCAT(  
                        ISNULL(M.FirstName, ''),  
                        ' ',  
                        ISNULL(M.MiddleName, ''),  
                        ' ',  
                        ISNULL(M.LastName, '')  
                    )  
                )) LIKE @Search + '%'  
                    THEN 5  
  
                ELSE 6  
  
            END,  
  
            M.FirstName;  
  
    END TRY  
  
    BEGIN CATCH  
  
        SELECT  
            ERROR_MESSAGE() AS Message;  
  
    END CATCH  
  
END;
GO

-----------------------------------------------------
  --SP: spRetrieveCurrentMonthAllPresentAttendance--
-----------------------------------------------------
CREATE PROC spRetrieveCurrentMonthAllPresentAttendance
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        ma.AttendanceId,
        ma.MemberId,

        CONCAT(
            ISNULL(m.FirstName, ''), ' ',
            ISNULL(m.MiddleName, ''), ' ',
            ISNULL(m.LastName, '')
        ) AS MemberName,

        m.PhoneNo,

        ma.ShiftId,
        s.ShiftName,

        CAST(ma.AttendanceDate AS DATE) AS AttendanceDate

    FROM tblMemberAttendance ma

    INNER JOIN tblMember m
        ON m.MemberId = ma.MemberId
        AND m.IsActive = 1

    INNER JOIN tblShift s
        ON s.ShiftId = ma.ShiftId

    WHERE
        ma.AttendanceDate >= DATEFROMPARTS(
            YEAR(GETDATE()),
            MONTH(GETDATE()),
            1
        )
        AND ma.AttendanceDate < DATEADD(
            MONTH,
            1,
            DATEFROMPARTS(
                YEAR(GETDATE()),
                MONTH(GETDATE()),
                1
            )
        )

    ORDER BY
        CAST(ma.AttendanceDate AS DATETIME) DESC;
       
END
GO
-----------------------------------------------------
  --SP: spRetrieveMemberAttendanceByPhoneMonthYear--
-----------------------------------------------------
CREATE  PROC spRetrieveMemberAttendanceByPhoneMonthYear 
    @PhoneNo VARCHAR(20),
    @MonthNumber INT,
    @Year INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        ma.AttendanceId,
        m.MemberId,

        CONCAT(
            ISNULL(m.FirstName, ''), ' ',
            ISNULL(m.MiddleName, ''), ' ',
            ISNULL(m.LastName, '')
        ) AS MemberName,

        m.PhoneNo,

        ma.ShiftId,
        s.ShiftName,

        CAST(ma.AttendanceDate AS DATE) AS AttendanceDate

    FROM tblMemberAttendance ma

    INNER JOIN tblMember m
        ON m.MemberId = ma.MemberId

    INNER JOIN tblShift s
        ON s.ShiftId = ma.ShiftId

    WHERE
        m.PhoneNo = @PhoneNo

        AND MONTH(ma.AttendanceDate) = @MonthNumber

        AND YEAR(ma.AttendanceDate) = @Year

    ORDER BY
        CAST(ma.AttendanceDate AS DATE) DESC;
    
END
GO
--------------------------------------------
  --SP: spRetrieveShiftWiseTotalAttendance--
--------------------------------------------
CREATE PROC spRetrieveShiftWiseTotalAttendance
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT
            S.ShiftName,
            ISNULL(COUNT(MA.AttendanceId), 0) AS TotalAttendance
        FROM tblShift S
        LEFT JOIN tblMemberAttendance MA
            ON S.ShiftId = MA.ShiftId
           AND CAST(MA.AttendanceDate AS DATE) = CAST(GETDATE() AS DATE)
        GROUP BY
            S.ShiftName,
            S.StartTime
        ORDER BY
            S.StartTime;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END
GO

----------------------------------------
  --SP: spRetrieveTodayAttendanceCount--
----------------------------------------
CREATE PROC spRetrieveTodayAttendanceCount
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SELECT
            COUNT(MemberId) AS TodayAttendanceCount
        FROM tblMemberAttendance
        WHERE AttendanceDate >= CAST(GETDATE() AS DATE)
          AND AttendanceDate < DATEADD(DAY, 1, CAST(GETDATE() AS DATE));

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH

END;
GO

------------------------------------------------
  --SP: spRetrieveMemberAttendanceCountByMonth--
------------------------------------------------
CREATE PROC spRetrieveMemberAttendanceCountByMonth 
(
    @MemberId INT,
    @Month INT,
    @Year INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMember
            WHERE MemberId = @MemberId
              AND IsActive = 1
        )
        BEGIN
            SELECT 'Invalid Member.' AS Message;
            RETURN;
        END;
        IF @Month NOT BETWEEN 1 AND 12
        BEGIN
            SELECT 'Invalid Month.' AS Message;
            RETURN;
        END;
        IF @Year < 2000
        BEGIN
            SELECT 'Invalid Year.' AS Message;
            RETURN;
        END;
        SELECT
            M.MemberId,
            M.FirstName + ' ' + ISNULL(M.MiddleName + ' ', '') + M.LastName AS MemberName,
            @Month AS [Month],
            @Year AS [Year],
            COUNT(DISTINCT CAST(MA.AttendanceDate AS DATE)) AS TotalAttendanceDays
        FROM tblMember M
        LEFT JOIN tblMemberAttendance MA
            ON M.MemberId = MA.MemberId
           AND MONTH(MA.AttendanceDate) = @Month
           AND YEAR(MA.AttendanceDate) = @Year
        WHERE M.MemberId = @MemberId
        GROUP BY
            M.MemberId,
            M.FirstName,
            M.MiddleName,
            M.LastName;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END
GO

--------------------------------------------------
  --SP: spRetrieveMemberAttendanceDetailsByMonth--
--------------------------------------------------
CREATE PROC spRetrieveMemberAttendanceDetailsByMonth 
(
    @MemberId INT,
    @Month INT,
    @Year INT
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMember
            WHERE MemberId = @MemberId
              AND IsActive = 1
        )
        BEGIN
            SELECT 'Invalid Member.' AS Message;
            RETURN;
        END;
        IF @Month NOT BETWEEN 1 AND 12
        BEGIN
            SELECT 'Invalid Month.' AS Message;
            RETURN;
        END;
        IF @Year < 2000
        BEGIN
            SELECT 'Invalid Year.' AS Message;
            RETURN;
        END;

        ------------------------------------------------
        -- Monthly Attendance Details
        ------------------------------------------------
        SELECT
            M.MemberId,

            LTRIM(RTRIM(
                M.FirstName + ' ' +
                ISNULL(M.MiddleName + ' ', '') +
                M.LastName
            )) AS FullName,

            M.GenderId,
            M.PhoneNo,
            M.EmailId,
            M.City,
            M.District,
            M.State,
            M.EmergencyContact,
            M.ProfilePhoto,
            M.JoiningDate,
            M.IsActive,

            MA.AttendanceId,

            CAST(MA.AttendanceDate AS DATE) AS AttendanceDate,

            MA.ShiftId,
            S.ShiftName,
            S.StartTime,
            S.EndTime

        FROM tblMember M

        INNER JOIN tblMemberAttendance MA
            ON M.MemberId = MA.MemberId

        INNER JOIN tblShift S
            ON MA.ShiftId = S.ShiftId

        WHERE M.MemberId = @MemberId
          AND MA.AttendanceDate >= DATEFROMPARTS(@Year, @Month, 1)
          AND MA.AttendanceDate < DATEADD
          (
              MONTH,
              1,
              DATEFROMPARTS(@Year, @Month, 1)
          )

        ORDER BY
            MA.AttendanceDate ASC;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END;
GO


-------------------------------------------------------------------------------
                   -- EmployeeSalaryManagement SPs --
-------------------------------------------------------------------------------
-------------------------------------------
  --SP: spGetDetailsOfEmployeesNotPaidYet--
-------------------------------------------
CREATE PROC spGetDetailsOfEmployeesNotPaidYet
AS
BEGIN
    BEGIN TRY
        SET NOCOUNT ON;

        DECLARE @CurrentMonth VARCHAR(20) = DATENAME(MONTH, GETDATE());
        DECLARE @CurrentYear  INT = DATEPART(YEAR, GETDATE());
        
        SELECT 
            e.EmployeeId,
            TRIM(
                e.FirstName + ' ' +
                ISNULL(e.MiddleName + ' ', '') +
                e.LastName
            ) AS FullName,
            ert.Role AS RoleName,
            e.PhoneNo,
            e.EmailId,
            s.SalaryId,
            s.Amount AS SalaryAmount,
            @CurrentMonth AS CurrentMonth,
            @CurrentYear AS CurrentYear,
            'Not Paid' AS PaymentStatus
        FROM tblEmployee e
        INNER JOIN tblEmployeeRoleType ert
            ON e.RoleId = ert.RoleId
        INNER JOIN tblSalary s
            ON e.EmployeeId = s.EmployeeId
        WHERE e.IsActive = 1
          AND NOT EXISTS (
                SELECT 1 
                FROM tblSalaryPayment sp
                WHERE sp.SalaryId = s.SalaryId
                  AND sp.PaymentMonth = @CurrentMonth
                  AND sp.PaymentYear = @CurrentYear
                  AND sp.PaymentStatus = 'Paid'
          )
        ORDER BY e.EmployeeId;
    
    END TRY
    BEGIN CATCH
        SELECT
            ERROR_MESSAGE() AS Message;
    END CATCH
END;
GO

--------------------------------------------------
  --SP: spGetEmployeeSalaryDetailsByCurrentMonth--
--------------------------------------------------
CREATE PROC spGetEmployeeSalaryDetailsByCurrentMonth  
AS  
BEGIN  
    BEGIN TRY  
        SET NOCOUNT ON;  
  
        DECLARE @CurrentMonth VARCHAR(10) = DATENAME(MONTH, GETDATE());  
        DECLARE @CurrentYear INT = YEAR(GETDATE());  
  
        SELECT  
            e.EmployeeId,  
  
            TRIM(  
                e.FirstName + ' ' +  
                ISNULL(e.MiddleName + ' ', '') +  
                e.LastName  
            ) AS EmployeeName,  
  
            e.PhoneNo,  
  
            s.SalaryId,  
  
            s.Amount AS Salary,  
  
            CASE  
                WHEN sp.PaymentId IS NOT NULL THEN 1  
                ELSE 0  
            END AS IsPaid  
  
        FROM tblEmployee e  
  
        INNER JOIN tblSalary s  
            ON e.EmployeeId = s.EmployeeId  
  
        LEFT JOIN tblSalaryPayment sp  
            ON s.SalaryId = sp.SalaryId  
            AND sp.PaymentMonth = @CurrentMonth  
            AND sp.PaymentYear = @CurrentYear  
            AND sp.PaymentStatus = 'Paid'  
  
        WHERE e.IsActive = 1  
  
        ORDER BY  
            CASE  
                WHEN sp.PaymentId IS NOT NULL THEN 0  
                ELSE 1  
            END,  
            e.EmployeeId;  
  
    END TRY  
  
    BEGIN CATCH  
  
        SELECT  
            ERROR_MESSAGE() AS Message;  
  
    END CATCH  
END;
GO
-------------------------------------------
  --SP: spPaySalaryToEmployeeByEmployeeId---
-------------------------------------------
CREATE PROC spPaySalaryToEmployeeByEmployeeId
    @EmployeeId INT = NULL,
    @PaymentMode VARCHAR(50) = NULL
AS
BEGIN
    BEGIN TRY
        SET NOCOUNT ON;

        IF @EmployeeId IS NULL
        BEGIN
            SELECT
                'EmployeeId is required' AS Message;
            RETURN;
        END

        IF NOT EXISTS
        (
            SELECT 1
            FROM tblEmployee
            WHERE EmployeeId = @EmployeeId
              AND IsActive = 1
        )
        BEGIN
            SELECT
                'EmployeeId does not exist' AS Message;
            RETURN;
        END

        DECLARE @CurrentDate DATETIME = GETDATE();
        DECLARE @Month VARCHAR(20) = DATENAME(MONTH, @CurrentDate);
        DECLARE @Year INT = DATEPART(YEAR, @CurrentDate);
        DECLARE @PaymentStatus VARCHAR(12) = 'Paid';

        DECLARE @SalaryId INT =
        (
            SELECT SalaryId
            FROM tblSalary
            WHERE EmployeeId = @EmployeeId
        );

        IF @SalaryId IS NULL
        BEGIN
            SELECT
                'No salary record found for this employee' AS Message;
            RETURN;
        END

        IF EXISTS
        (
            SELECT 1
            FROM tblSalaryPayment
            WHERE SalaryId = @SalaryId
              AND PaymentMonth = @Month
              AND PaymentYear = @Year
              AND PaymentStatus = @PaymentStatus
        )
        BEGIN
            SELECT
                'Salary already paid for this month' AS Message;
            RETURN;
        END

        INSERT INTO tblSalaryPayment
        (
            SalaryId,
            PaymentMode,
            PaymentMonth,
            PaymentYear,
            PaymentDate,
            PaymentStatus
        )
        VALUES
        (
            @SalaryId,
            @PaymentMode,
            @Month,
            @Year,
            @CurrentDate,
            @PaymentStatus
        );

        SELECT
            'Payment recorded successfully' AS Message;

    END TRY
    BEGIN CATCH
        SELECT
            ERROR_MESSAGE() AS Message;
    END CATCH
END;
GO

-------------------------------------------------------------
  --SP: spRetrieveEmployeeSalaryDetailsByPhoneNumberAndName--
-------------------------------------------------------------
CREATE PROC spRetrieveEmployeeSalaryDetailsByPhoneNumberAndName  
(  
    @Search VARCHAR(100)  
)  
AS  
BEGIN  
    SET NOCOUNT ON;  
  
    BEGIN TRY  
  
        SET @Search = LTRIM(RTRIM(@Search));  
  
        DECLARE @CurrentMonth VARCHAR(10) =  
            DATENAME(MONTH, GETDATE());  
  
        DECLARE @CurrentYear INT =  
            YEAR(GETDATE());  
  
        SELECT  
            E.EmployeeId,  
  
            S.SalaryId,  
  
            TRIM(  
                E.FirstName + ' ' +  
                ISNULL(E.MiddleName + ' ', '') +  
                E.LastName  
            ) AS EmployeeName,  
  
            E.PhoneNo,  
  
            S.Amount AS Salary,  
  
            CASE  
                WHEN SP.PaymentId IS NOT NULL THEN 1  
                ELSE 0  
            END AS IsPaid  
  
        FROM tblEmployee E  
  
        INNER JOIN tblSalary S  
            ON E.EmployeeId = S.EmployeeId  
  
        LEFT JOIN tblSalaryPayment SP  
            ON S.SalaryId = SP.SalaryId  
            AND SP.PaymentMonth = @CurrentMonth  
            AND SP.PaymentYear = @CurrentYear  
            AND SP.PaymentStatus = 'Paid'  
  
        WHERE  
            (  
                E.FirstName LIKE @Search + '%'  
                OR E.MiddleName LIKE @Search + '%'  
                OR E.LastName LIKE @Search + '%'  
                OR E.PhoneNo LIKE @Search + '%'  
            )  
            AND E.IsActive = 1  
  
        ORDER BY  
            CASE  
                WHEN SP.PaymentId IS NOT NULL THEN 0  
                ELSE 1  
            END,  
            E.EmployeeId;  
  
    END TRY  
  
    BEGIN CATCH  
  
        SELECT  
            ERROR_MESSAGE() AS Message;  
  
    END CATCH  
END;
GO
----------------------------------------------
  --SP: spGetAllEmployeeSalaryPaymentDetails--
----------------------------------------------
CREATE PROC spGetAllEmployeeSalaryPaymentDetails
AS
BEGIN
    BEGIN TRY
        SET NOCOUNT ON;

        SELECT 
            e.EmployeeId,
            TRIM(
                e.FirstName + ' ' +
                ISNULL(e.MiddleName + ' ', '') +
                e.LastName
            ) AS FullName,
            ert.Role AS RoleName,
            e.PhoneNo,
            e.EmailId,
            s.Amount AS SalaryAmount,
            sp.PaymentMode,
            sp.PaymentMonth,
            sp.PaymentYear,
            sp.PaymentDate,
            sp.PaymentStatus

        FROM tblEmployee e
        INNER JOIN tblEmployeeRoleType ert
            ON e.RoleId = ert.RoleId
        INNER JOIN tblSalary s
            ON e.EmployeeId = s.EmployeeId
        INNER JOIN tblSalaryPayment sp
            ON s.SalaryId = sp.SalaryId

        ORDER BY sp.PaymentDate DESC

    END TRY
    BEGIN CATCH
        SELECT
            ERROR_MESSAGE() AS Message;
    END CATCH
END;
GO

-------------------------------------------------------
  --SP: spGetEmployeeSalaryPaymentDetailsByEmployeeId--
-------------------------------------------------------
CREATE PROC spGetEmployeeSalaryPaymentDetailsByEmployeeId
    @EmployeeId INT 
AS
BEGIN
    BEGIN TRY
        SET NOCOUNT ON;

        IF @EmployeeId IS NULL
        BEGIN
            SELECT 
                'EmployeeId is required' AS Message;
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM tblEmployee WHERE EmployeeId = @EmployeeId)
        BEGIN
            SELECT 
                'EmployeeId does not exist' AS Message;
            RETURN;
        END

        SELECT
            e.EmployeeId,
            TRIM(
                e.FirstName + ' ' +
                ISNULL(e.MiddleName + ' ', '') +
                e.LastName
            ) AS FullName,
            ert.Role AS RoleName,
            e.PhoneNo,
            e.EmailId,
            s.Amount AS SalaryAmount,
            sp.PaymentMode,
            sp.PaymentMonth,
            sp.PaymentYear,
            sp.PaymentDate,
            sp.PaymentStatus

        FROM tblEmployee e
        INNER JOIN tblEmployeeRoleType ert
            ON e.RoleId = ert.RoleId
        INNER JOIN tblSalary s
            ON e.EmployeeId = s.EmployeeId
        INNER JOIN tblSalaryPayment sp
            ON s.SalaryId = sp.SalaryId
        WHERE e.EmployeeId = @EmployeeId
        ORDER BY sp.PaymentYear, sp.PaymentMonth;

    END TRY
    BEGIN CATCH
        SELECT
            ERROR_MESSAGE() AS Message;
    END CATCH
END;
GO

-------------------------------------------------
  --SP: spGetEmployeeSalaryPaymentDetailsByYear--
-------------------------------------------------
CREATE PROC spGetEmployeeSalaryPaymentDetailsByYear
    @PaymentYear INT 
AS
BEGIN
    BEGIN TRY
        SET NOCOUNT ON;

        IF @PaymentYear IS NULL
        BEGIN
            SELECT
                'PaymentYear is required' AS Message;
            RETURN;
        END
        
        IF @PaymentYear < 2000 OR @PaymentYear > DATEPART(YEAR, GETDATE())
        BEGIN
            SELECT 
                'Invalid PaymentYear. Year must be between 2000 and ' + 
                CAST(DATEPART(YEAR, GETDATE()) AS VARCHAR) AS Message;
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM tblSalaryPayment WHERE PaymentYear = @PaymentYear)
        BEGIN
            SELECT 
                'No payment records found for year ' + 
                CAST(@PaymentYear AS VARCHAR) AS Message;
            RETURN;
        END

        SELECT
            e.EmployeeId,
            TRIM(
                e.FirstName + ' ' +
                ISNULL(e.MiddleName + ' ', '') +
                e.LastName
            ) AS FullName,
            ert.Role AS RoleName,
            e.PhoneNo,
            e.EmailId,
            s.Amount AS SalaryAmount,
            sp.PaymentMode,
            sp.PaymentMonth,
            sp.PaymentYear,
            sp.PaymentDate,
            sp.PaymentStatus

        FROM tblEmployee e
        INNER JOIN tblEmployeeRoleType ert
            ON e.RoleId = ert.RoleId
        INNER JOIN tblSalary s
            ON e.EmployeeId = s.EmployeeId
        INNER JOIN tblSalaryPayment sp
            ON s.SalaryId = sp.SalaryId
        WHERE sp.PaymentYear = @PaymentYear
        ORDER BY e.EmployeeId, sp.PaymentMonth;

    END TRY
    BEGIN CATCH
        SELECT
            ERROR_MESSAGE() AS Message;
    END CATCH
END;
GO

------------------------------------------
  --SP: spGetTotalPaidSalaryAmountByYear--
------------------------------------------
CREATE PROC spGetTotalSalaryPaidAmountByYear 
    @PaymentYear INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        SUM(s.Amount) AS TotalSalaryPaid
    FROM tblSalaryPayment sp
    INNER JOIN tblSalary s
        ON s.SalaryId = sp.SalaryId
    WHERE sp.PaymentYear   = @PaymentYear
      AND sp.PaymentStatus = 'Paid'
    GROUP BY sp.PaymentYear;
END;

GO

---------------------------------------------------
  --SP: spGetSalaryPaymentDetailsBetweenDateRange--
---------------------------------------------------
CREATE PROC spGetSalaryPaymentDetailsBetweenDateRange 
    @StartDate DATE,
    @EndDate   DATE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        IF @StartDate IS NULL OR @EndDate IS NULL
        BEGIN
            SELECT 'Both StartDate and EndDate are required.' AS Message
            RETURN;
        END
        
        IF @StartDate > @EndDate
        BEGIN
            SELECT 'StartDate cannot be later than EndDate.' AS Message;
            RETURN;
        END

        SELECT
    e.EmployeeId,
    (e.FirstName 
        + CASE 
            WHEN e.MiddleName IS NULL OR e.MiddleName = '' 
                THEN '' 
            ELSE ' ' + e.MiddleName 
        END
        + ' ' + e.LastName) AS FullName,
    e.PhoneNo,
    e.EmailId,
    e.BankAccountNo,
    r.Role AS RoleName,
    s.SalaryId,
    s.Amount AS SalaryAmount,
    sp.PaymentId,
    sp.PaymentMode,
    sp.PaymentMonth,
    sp.PaymentYear,
    sp.PaymentDate,
    sp.PaymentStatus
        FROM tblSalaryPayment sp
        INNER JOIN tblSalary s
            ON sp.SalaryId = s.SalaryId
        INNER JOIN tblEmployee e
            ON s.EmployeeId = e.EmployeeId
        INNER JOIN tblEmployeeRoleType r
            ON e.RoleId = r.RoleId
        WHERE 
            sp.PaymentDate >= @StartDate
            AND sp.PaymentDate < DATEADD(DAY, 1, @EndDate)
        ORDER BY 
            sp.PaymentDate ASC;

    END TRY
    BEGIN CATCH
        SELECT
            ERROR_MESSAGE()   AS Message;
    END CATCH
END
GO

----------------------------------------------------
  --SP: spGetTotalPaidSalaryAmountBetweenDateRange--
----------------------------------------------------
CREATE PROC spGetTotalPaidSalaryAmountBetweenDateRange 
    @StartDate DATE,
    @EndDate   DATE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        IF @StartDate IS NULL OR @EndDate IS NULL
        BEGIN
            SELECT 'Both StartDate and EndDate are required.' AS Message
            RETURN;
        END
        
        IF @StartDate > @EndDate
        BEGIN
            SELECT 'StartDate cannot be later than EndDate.' AS Message;
            RETURN;
        END

        SELECT
            SUM(s.Amount)       AS GrandTotalAmountPaid
        FROM tblSalaryPayment sp
        INNER JOIN tblSalary s
            ON sp.SalaryId = s.SalaryId
        WHERE 
            sp.PaymentDate >= @StartDate
            AND sp.PaymentDate < DATEADD(DAY, 1, @EndDate)
            AND sp.PaymentStatus = 'Paid';

    END TRY
    BEGIN CATCH
        SELECT 
            ERROR_MESSAGE() AS Message
    END CATCH
END
GO

-------------------------------------------------
  --SP: spGetEmployeeSalaryPaymentDetailsByMonth--
-------------------------------------------------
CREATE PROC spGetEmployeeSalaryPaymentDetailsByMonth
    @PaymentMonth INT ,
    @PaymentYear  INT
AS
BEGIN
    BEGIN TRY
        SET NOCOUNT ON;

        IF @PaymentMonth IS NULL
        BEGIN
            SELECT 
                'PaymentMonth is required' AS Message;
            RETURN;
        END

        IF @PaymentMonth NOT BETWEEN 1 AND 12
        BEGIN
            SELECT 
                'Invalid PaymentMonth. Allowed values are: 1 to 12 (1 = January, 12 = December)' AS Message;
            RETURN;
        END

        IF @PaymentYear IS NULL
        BEGIN
            SELECT 
                'PaymentYear is required' AS Message;
            RETURN;
        END

        IF @PaymentYear NOT BETWEEN 2000 AND YEAR(GETDATE())
        BEGIN
            SELECT 
                'Invalid PaymentYear. Please provide a valid 4-digit year.' AS Message;
            RETURN;
        END

        DECLARE @MonthName VARCHAR(20);
        SET @MonthName = FORMAT(DATEFROMPARTS(2000, @PaymentMonth, 1), 'MMMM', 'en-US');

        IF NOT EXISTS (
            SELECT 1 
            FROM tblSalaryPayment 
            WHERE PaymentMonth = @MonthName 
              AND PaymentYear = @PaymentYear
        )
        BEGIN
            SELECT 
                'No payment records found for ' + @MonthName + ' ' + CAST(@PaymentYear AS VARCHAR(4)) AS Message;
            RETURN;
        END

        SELECT
            e.EmployeeId,
            CONCAT(e.FirstName, ' ', ISNULL(e.MiddleName + ' ', ''), e.LastName) AS FullName,
            ert.Role AS RoleName,
            e.PhoneNo,
            e.EmailId,
            s.Amount AS SalaryAmount,
            sp.PaymentMode,
            sp.PaymentMonth,
            sp.PaymentYear,
            sp.PaymentDate,
            sp.PaymentStatus
        FROM tblEmployee e
        INNER JOIN tblEmployeeRoleType ert
            ON e.RoleId = ert.RoleId
        INNER JOIN tblSalary s
            ON e.EmployeeId = s.EmployeeId
        INNER JOIN tblSalaryPayment sp
            ON s.SalaryId = sp.SalaryId
        WHERE sp.PaymentMonth = @MonthName
          AND sp.PaymentYear = @PaymentYear
        ORDER BY e.EmployeeId ASC;

    END TRY
    BEGIN CATCH
        SELECT
            ERROR_MESSAGE() AS Message;
    END CATCH
END;
GO
------------------------------------------
  --SP: spGetTotalPaidSalaryAmountByMonth--
------------------------------------------
CREATE PROC spGetTotalPaidSalaryAmountByMonth
    @PaymentMonth INT ,
    @PaymentYear  INT 
AS
BEGIN
    BEGIN TRY
        SET NOCOUNT ON;

        IF @PaymentMonth IS NULL
        BEGIN
            SELECT 'PaymentMonth is required' AS Message;
            RETURN;
        END

        IF @PaymentMonth NOT BETWEEN 1 AND 12
        BEGIN
            SELECT 'Invalid PaymentMonth. Allowed values are: 1 to 12 (1 = January, 12 = December)' AS Message;
            RETURN;
        END

        IF @PaymentYear IS NULL
        BEGIN
            SELECT 'PaymentYear is required' AS Message;
            RETURN;
        END

        IF @PaymentYear NOT BETWEEN 2000 AND YEAR(GETDATE())
        BEGIN
            SELECT 'Invalid PaymentYear. Please provide a valid 4-digit year.' AS Message;
            RETURN;
        END

        DECLARE @MonthName VARCHAR(20);
        SET @MonthName = FORMAT(DATEFROMPARTS(2000, @PaymentMonth, 1), 'MMMM', 'en-US');

        IF NOT EXISTS (
            SELECT 1 
            FROM tblSalaryPayment 
            WHERE PaymentMonth = @MonthName 
              AND PaymentYear = @PaymentYear
              AND PaymentStatus = 'Paid'
        )
        BEGIN
            SELECT 'No paid salary records found for ' + @MonthName + ' ' + CAST(@PaymentYear AS VARCHAR(4)) AS Message;
            RETURN;
        END

        SELECT
            SUM(s.Amount) AS TotalSalaryPaid
        FROM tblSalaryPayment sp
        INNER JOIN tblSalary s
            ON s.SalaryId = sp.SalaryId
        WHERE sp.PaymentMonth = @MonthName
          AND sp.PaymentYear  = @PaymentYear
          AND sp.PaymentStatus = 'Paid';

    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message;
    END CATCH
END;
GO

-------------------------------------------------------------------------------
                   -- WorkoutScheduleManagement SPs --
-------------------------------------------------------------------------------

-------------------------------------------
  --SP: spRetrieveRecordsOfExercisesTable--
-------------------------------------------
CREATE PROC spRetrieveRecordsOfExercisesTable
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        ExerciseId,
        ExerciseName,
        MuscleType
    FROM tblExercises
END
GO

-----------------------------------------------
  --SP: spRetrieveRecordsOfWorkoutPlanTable--
-----------------------------------------------
CREATE PROC spRetrieveRecordsOfWorkoutPlanTable
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        WorkoutPlanId,
        WorkoutName,
        Description
    FROM tblWorkoutPlans
END
GO

-------------------------------------------------
  --SP: spRetrieveRecordsOfWorkoutScheduleTable--
-------------------------------------------------
CREATE PROC spRetrieveRecordsOfWorkoutScheduleTable
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        ws.WorkoutScheduleId,
        wp.WorkoutPlanId,
        wp.WorkoutName,
        e.ExerciseId,
        e.ExerciseName,
        ws.WorkoutDay
    FROM tblWorkoutSchedule ws
    INNER JOIN tblExercises e 
        ON ws.ExerciseId = e.ExerciseId
    INNER JOIN tblWorkoutPlans wp 
        ON ws.WorkoutPlanId = wp.WorkoutPlanId
    ORDER BY 
        wp.WorkoutName, 
        e.ExerciseName;
END
GO

----------------------------------
  --SP: spInsertDataIntoExercise--
----------------------------------
CREATE PROC spInsertDataIntoExercise 
    @ExerciseName VARCHAR(100),
    @MuscleType VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
   
        IF @ExerciseName IS NULL OR LTRIM(RTRIM(@ExerciseName)) = ''
        BEGIN
            SELECT 
                'ExerciseName cannot be NULL or empty.' AS Message
            RETURN;
        END

        IF @MuscleType IS NULL OR LTRIM(RTRIM(@MuscleType)) = ''
        BEGIN
            SELECT 
                'MuscleType cannot be NULL or empty.' AS Message
            RETURN;
        END

        IF LEN(@ExerciseName) > 100
        BEGIN
            SELECT
                'ExerciseName cannot exceed 100 characters.' AS Message
            RETURN;
        END

        IF LEN(@MuscleType) > 100
        BEGIN
            SELECT 
                'MuscleType cannot exceed 100 characters.' AS Message
            RETURN;
        END

        IF EXISTS (
            SELECT 1 FROM tblExercises
            WHERE ExerciseName = @ExerciseName
        )
        BEGIN
            SELECT
                'An exercise with this name already exists.' AS Message
            RETURN;
        END

            INSERT INTO tblExercises (ExerciseName, MuscleType)
            VALUES (LTRIM(RTRIM(@ExerciseName)), LTRIM(RTRIM(@MuscleType)));
            
            SELECT 
                'Record inserted successfuly' AS Message
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message
    END CATCH
END
GO

------------------------------------------
  --SP: spInsertDataIntoWorkoutPlanTable--
------------------------------------------
CREATE PROC spInsertDataIntoWorkoutPlanTable
    @WorkoutName VARCHAR(100),
    @Description VARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
      
        SET @WorkoutName = LTRIM(RTRIM(@WorkoutName));
        SET @Description = ISNULL(LTRIM(RTRIM(@Description)), '');

        IF @WorkoutName IS NULL OR @WorkoutName = ''
        BEGIN
            SELECT
                'WorkoutName cannot be NULL or empty.' AS Message
            RETURN;
        END

        IF LEN(@WorkoutName) > 100
        BEGIN
            SELECT
                'WorkoutName cannot exceed 100 characters.' AS Message
            RETURN;
        END

        IF @Description IS NULL OR @Description = ''
        BEGIN
            SELECT
                'Description cannot be NULL or empty.' AS Message
            RETURN;
        END


        IF @WorkoutName LIKE '%[^a-zA-Z0-9 ,''&/-]%'
        BEGIN
            SELECT
                'WorkoutName contains invalid characters.' AS Message
            RETURN;
        END

        IF EXISTS (SELECT 1 FROM tblWorkoutPlans WHERE WorkoutName = @WorkoutName)
        BEGIN
            SELECT 
                'A workout plan with this name already exists.' AS Message
            RETURN;
        END

        INSERT INTO tblWorkoutPlans (WorkoutName, Description)
        VALUES (@WorkoutName, @Description);

        SELECT 
            'Record inserted successfuly' AS Message

    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message
    END CATCH
END
GO

----------------------------------------------
  --SP: spInsertDataIntoWorkoutScheduleTable--
----------------------------------------------
CREATE PROC spInsertDataIntoWorkoutScheduleTable 
    @WorkoutPlanId INT,
    @ExerciseId    INT,
    @WorkoutDay    VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        
        IF @WorkoutPlanId IS NULL OR @ExerciseId IS NULL OR LTRIM(RTRIM(ISNULL(@WorkoutDay, ''))) = ''
        BEGIN
            SELECT 
                'WorkoutPlanId, ExerciseId and WorkoutDay are required.' AS Message
            RETURN;
        END

        SET @WorkoutDay = LTRIM(RTRIM(@WorkoutDay));
        SET @WorkoutDay = UPPER(LEFT(@WorkoutDay, 1)) + LOWER(SUBSTRING(@WorkoutDay, 2, LEN(@WorkoutDay) - 1));

        IF @WorkoutDay NOT IN ('Monday','Tuesday','Wednesday','Thursday','Friday','Saturday','Sunday')
        BEGIN
            SELECT
                'WorkoutDay must be a valid day name (Monday-Sunday).' AS Message
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM tblWorkoutPlans WHERE WorkoutPlanId = @WorkoutPlanId)
        BEGIN
            SELECT
                'Invalid WorkoutPlanId: no matching WorkoutPlan found.' AS Message
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM tblExercises WHERE ExerciseId = @ExerciseId)
        BEGIN
            SELECT
                'Invalid ExerciseId: no matching Exercise found.' AS Message
            RETURN;
        END

        IF EXISTS (
            SELECT 1 FROM tblWorkoutSchedule
            WHERE WorkoutPlanId = @WorkoutPlanId
              AND ExerciseId = @ExerciseId
              AND WorkoutDay = @WorkoutDay
        )
        BEGIN
            SELECT
                'This exercise is already scheduled for this day in the selected workout plan.' AS Message
            RETURN;
        END

        INSERT INTO tblWorkoutSchedule (WorkoutPlanId, ExerciseId, WorkoutDay)
        VALUES (@WorkoutPlanId, @ExerciseId, @WorkoutDay);

        SELECT
            'Record inserted successfuly' AS Message

    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message
    END CATCH
END
GO

------------------------------------------------------
  --SP: spRetrieveWorkoutScheduleRecordsByWorkoutDay--
------------------------------------------------------
CREATE PROC spRetrieveWorkoutScheduleRecordsByWorkoutDay
    @WorkoutDay VARCHAR
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        SET @WorkoutDay = LTRIM(RTRIM(@WorkoutDay));
        SET @WorkoutDay = UPPER(LEFT(@WorkoutDay, 1)) + LOWER(SUBSTRING(@WorkoutDay, 2, LEN(@WorkoutDay) - 1));

        SELECT 
            ws.WorkoutScheduleId,
            wp.WorkoutName,
            e.ExerciseName,
            ws.WorkoutDay
        FROM tblWorkoutSchedule ws
        INNER JOIN tblExercises e ON ws.ExerciseId = e.ExerciseId
        INNER JOIN tblWorkoutPlans wp ON ws.WorkoutPlanId = wp.WorkoutPlanId
        WHERE (@WorkoutDay IS NULL OR ws.WorkoutDay = @WorkoutDay)
        ORDER BY ws.WorkoutDay, ws.WorkoutScheduleId;

    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message
    END CATCH
END
GO

------------------------------------------------------
  --SP: spRetrieveWorkoutScheduleRecordsByWorkoutDay--
------------------------------------------------------
CREATE PROC spRemoveWorkoutScheduleByWorkoutScheduleId 
    @WorkoutScheduleId INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM tblWorkoutSchedule WHERE WorkoutScheduleId = @WorkoutScheduleId)
        BEGIN
            SELECT
                'Invalid WorkoutScheduleId: no matching record found.' AS Message
            RETURN;
        END

        IF EXISTS (
            SELECT 1 FROM tblWorkoutSchedule 
            WHERE WorkoutScheduleId = @WorkoutScheduleId AND WorkoutDay IS NULL
        )
        BEGIN
            SELECT 
                'This schedule has already been removed.' AS Message
            RETURN;
        END

        DELETE FROM tblWorkoutSchedule
        WHERE WorkoutScheduleId = @WorkoutScheduleId;

        SELECT 
            'Workout Schedule record deleted successfully' AS Message

    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message
    END CATCH
END
GO

---------------------------------------
  --SP: spRetrieveSpecificWorkoutPlan--
---------------------------------------
CREATE PROCEDURE spRetrieveSpecificWorkoutPlan  
    @WorkoutPlanId INT  
AS  
BEGIN  
    SET NOCOUNT ON;  
  
    SELECT  
        WorkoutPlanId,  
        WorkoutName,  
        Description  
    FROM tblWorkoutPlans  
    WHERE WorkoutPlanId = @WorkoutPlanId;  
END
GO
---------------------------------------
  --SP: spRetrieveSpecificExercise--
---------------------------------------
CREATE PROC spRetrieveSpecificExercise
(
    @ExerciseId INT
)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        ExerciseId,
        ExerciseName,
        MuscleType
    FROM tblExercises
    WHERE ExerciseId = @ExerciseId;
END
GO
-------------------------------------------------------------------------------
                   -- DietPlanManagement SPs --
-------------------------------------------------------------------------------

-------------------------------
  --SP: spDisplayAllDietPlans--
-------------------------------
CREATE PROCEDURE spRetrieveDietPlanDetails
AS
BEGIN
	BEGIN TRY
		SELECT 
		tblDietPlans.DietPlanId,
		tblDietPlans.CaloriesPerDay,
		tblDietPlans.DietPlanDocument,
		tblDietPlans.ConditionStatus
		FROM tblDietPlans
	END TRY
	BEGIN CATCH
		SELECT ERROR_MESSAGE() AS Message
	END CATCH
END
GO

------------------------------------
  --SP: spGetMemberCurrentDietPlan--
------------------------------------
CREATE PROC spRetrieveMemberCurrentDietPlan
(
    @MemberId INT
)
AS
BEGIN
BEGIN TRY

    SET NOCOUNT ON;
    IF @MemberId IS NULL
    BEGIN
        SELECT 'Member Id is Required.' AS Message;
        RETURN;
    END

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMember
        WHERE MemberId = @MemberId
    )
    BEGIN
        SELECT 'Invalid Member Id.' AS Message;
        RETURN;
    END
    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMemberDietAssignment
        WHERE MemberId = @MemberId
          AND IsActive = 1
    )
    BEGIN
        SELECT 'No Active Diet Plan Found for This Member.' AS Message;
        RETURN;
    END
    SELECT
        MDA.DietAssignmentId,
        M.MemberId,
        M.FirstName,
        M.LastName,
        DP.DietPlanId,
        DP.CaloriesPerDay,
        DP.ConditionStatus,
        MDA.AssignDate,
        MDA.IsActive
    FROM tblMemberDietAssignment MDA
    INNER JOIN tblMember M
        ON MDA.MemberId = M.MemberId
    INNER JOIN tblDietPlans DP
        ON MDA.DietPlanId = DP.DietPlanId
    WHERE MDA.MemberId = @MemberId
      AND MDA.IsActive = 1;

END TRY

BEGIN CATCH

    SELECT
        ERROR_MESSAGE() AS Message;

END CATCH
END;
GO

-----------------------------
  --SP: spInsertNewDietPlan--
-----------------------------
CREATE PROC spInsertNewDietPlan  
(
    @CaloriesPerDay INT,
    @DietPlanDocument VARBINARY(MAX) = NULL,
    @ConditionStatus VARCHAR(MAX)
)
AS
BEGIN
BEGIN TRY

    SET NOCOUNT ON;

    -- Trim not applicable for INT/VARBINARY, only text
    SET @ConditionStatus = LTRIM(RTRIM(@ConditionStatus));

    -- Calories validation
    IF @CaloriesPerDay IS NULL
    BEGIN
        SELECT 'Calories Per Day is Required.' AS Message;
        RETURN;
    END

    IF @CaloriesPerDay <= 0
    BEGIN
        SELECT 'Calories Per Day Must Be Greater Than 0.' AS Message;
        RETURN;
    END

    -- Condition Status validation
    IF @ConditionStatus IS NULL OR @ConditionStatus = ''
    BEGIN
        SELECT 'Condition Status is Required.' AS Message;
        RETURN;
    END

    IF LEN(@ConditionStatus) < 3
    BEGIN
        SELECT 'Condition Status is Too Short.' AS Message;
        RETURN;
    END

    -- Insert Diet Plan
    INSERT INTO tblDietPlans
    (
        CaloriesPerDay,
        DietPlanDocument,
        ConditionStatus
    )
    VALUES
    (
        @CaloriesPerDay,
        @DietPlanDocument,
        @ConditionStatus
    );

    SELECT 'Diet Plan Inserted Successfully.' AS Message;

END TRY

BEGIN CATCH

    SELECT
        ERROR_MESSAGE() AS Message;

END CATCH
END;
GO

--------------------------------
  --SP: spRemoveMemberDietPlan--
--------------------------------
CREATE PROC spDeactivateMemberDietPlan
(
    @MemberId INT
)
AS
BEGIN
BEGIN TRY

    SET NOCOUNT ON;

    ----------------------------
    -- Member validation
    ----------------------------
    IF @MemberId IS NULL
    BEGIN
        SELECT 'Member Id is Required.' AS Message;
        RETURN;
    END

    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMember
        WHERE MemberId = @MemberId
    )
    BEGIN
        SELECT 'Invalid Member Id.' AS Message;
        RETURN;
    END

    ----------------------------
    -- Check active diet plan exists
    ----------------------------
    IF NOT EXISTS
    (
        SELECT 1
        FROM tblMemberDietAssignment
        WHERE MemberId = @MemberId
          AND IsActive = 1
    )
    BEGIN
        SELECT 'No Active Diet Plan Found for This Member.' AS Message;
        RETURN;
    END

    ----------------------------
    -- Deactivate current diet plan
    ----------------------------
    UPDATE tblMemberDietAssignment
    SET IsActive = 0
    WHERE MemberId = @MemberId
      AND IsActive = 1;

    SELECT 'Member Diet Plan Removed Successfully.' AS Message;

END TRY

BEGIN CATCH

    SELECT
        ERROR_MESSAGE() AS Message;

END CATCH
END;
GO

--------------------------------
  --SP: spUpdateDietPlanDetails--
--------------------------------
CREATE PROC spUpdateDietPlanDetails
(
    @DietPlanId INT,
    @CaloriesPerDay INT,
    @DietPlanDocument VARBINARY(MAX) = NULL,
    @ConditionStatus VARCHAR(MAX)
)
AS
BEGIN
BEGIN TRY

    SET NOCOUNT ON;

    SET @ConditionStatus = LTRIM(RTRIM(@ConditionStatus));
    IF @DietPlanId IS NULL
    BEGIN
        SELECT 'Diet Plan Id is Required.' AS Message;
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
    IF @CaloriesPerDay IS NULL
    BEGIN
        SELECT 'Calories Per Day is Required.' AS Message;
        RETURN;
    END

    IF @CaloriesPerDay <= 0
    BEGIN
        SELECT 'Calories Per Day Must Be Greater Than 0.' AS Message;
        RETURN;
    END
    IF @ConditionStatus IS NULL OR @ConditionStatus = ''
    BEGIN
        SELECT 'Condition Status is Required.' AS Message;
        RETURN;
    END

    IF LEN(@ConditionStatus) < 3
    BEGIN
        SELECT 'Condition Status is Too Short.' AS Message;
        RETURN;
    END
    UPDATE tblDietPlans
    SET
        CaloriesPerDay = @CaloriesPerDay,
        ConditionStatus = @ConditionStatus,
        DietPlanDocument = CASE
              WHEN @DietPlanDocument IS NULL THEN DietPlanDocument
              ELSE @DietPlanDocument
           END
    WHERE DietPlanId = @DietPlanId;

    SELECT 'Diet Plan Updated Successfully.' AS Message;

END TRY

BEGIN CATCH

    SELECT
        ERROR_MESSAGE() AS Message;

END CATCH
END;
GO
---------------------------------
	--spRetrieveGenderDetails--
---------------------------------
CREATE PROCEDURE spRetrieveGenderDetails
AS
BEGIN
    BEGIN TRY

        SELECT
            GenderId,
            GenderName
        FROM tblGender
        ORDER BY GenderName;

    END TRY

    BEGIN CATCH

        SELECT ERROR_MESSAGE() AS Message;

    END CATCH
END
GO

-----------------------------------------
	--spRetrieveMembershipPlanTypes--
-----------------------------------------
CREATE PROCEDURE spRetrieveMembershipPlanTypes
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        SELECT
            PlanTypeId,
            PlanType
        FROM tblMembershipPlanType
        ORDER BY PlanType ASC;
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message;
    END CATCH
END;
GO
----------------------------------------------------------------------

-----------------------------------------
	--spGetCurrentShift--
-----------------------------------------
CREATE PROC spGetCurrentShift  
AS  
BEGIN  
    SET NOCOUNT ON;  
  
    BEGIN TRY  
  
        DECLARE @CurrentTime TIME = CAST(GETDATE() AS TIME);  
  
        SELECT  
            ShiftId,  
            ShiftName,  
            FORMAT(CAST(StartTime AS DATETIME), 'hh:mm tt') AS StartTime,  
            FORMAT(CAST(EndTime AS DATETIME), 'hh:mm tt') AS EndTime  
        FROM tblShift  
        WHERE @CurrentTime BETWEEN StartTime AND EndTime;  
  
    END TRY  
    BEGIN CATCH  
  
        SELECT ERROR_MESSAGE() AS Message;  
  
    END CATCH  
END;  
GO

-----------------------------------------
	--pRetrieveEmployeeRoleTypes--
-----------------------------------------
CREATE PROC pRetrieveEmployeeRoleTypes    
AS    
BEGIN    
    SET NOCOUNT ON;    
    
    SELECT    
        RoleId,    
        Role    
    FROM tblEmployeeRoleType    
    ORDER BY RoleId;    
END
-----------------------------------------
	--spGetActiveMemberCount--
-----------------------------------------
CREATE PROC spGetActiveMemberCount  
AS  
BEGIN  
    SET NOCOUNT ON;  
  
   SELECT COUNT(*) FROM tblMember WHERE IsActive = 1;  
END
GO

 -----------------------------------------
	--spGetActiveMembershipPlanCount--
-----------------------------------------
CREATE PROC spGetActiveMembershipPlanCount  
AS  
BEGIN  
    SET NOCOUNT ON;  
  
    SELECT COUNT(*) AS ActiveMembershipPlanCount  
    FROM tblMembershipPlans  
    WHERE IsActive = 1;  
END


 -----------------------------------------
	--spGetActiveTrainerCount--
-----------------------------------------
 CREATE PROC spGetActiveTrainerCount    
AS    
BEGIN    
    SET NOCOUNT ON;    
    
    SELECT COUNT(*) AS ActiveTrainerCount    
    FROM tblTrainer T    
    INNER JOIN tblEmployee E    
        ON T.EmployeeId = E.EmployeeId    
    WHERE E.IsActive = 1;    
END
 -----------------------------------------
	--spRetrieveCurrentMonthNewMembers--
-----------------------------------------
CREATE PROC spRetrieveCurrentMonthNewMembers  
AS  
BEGIN  
    SET NOCOUNT ON;  
  
    BEGIN TRY  
  
        DECLARE @StartOfMonth DATE =  
            DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1);  
  
        DECLARE @StartOfNextMonth DATE =  
            DATEADD(MONTH, 1, @StartOfMonth);  
  
        SELECT  
            COUNT(*) AS NewMembers  
        FROM tblMember  
        WHERE JoiningDate >= @StartOfMonth  
          AND JoiningDate < @StartOfNextMonth;  
  
    END TRY  
  
    BEGIN CATCH  
  
        SELECT  
            ERROR_MESSAGE() AS Message;  
  
    END CATCH  
END

 -----------------------------------------
	--spGetActiveEmployeeCount--
-----------------------------------------
CREATE PROC spGetActiveEmployeeCount  
AS  
BEGIN  
    SET NOCOUNT ON;  
  
    SELECT   
        COUNT(*) AS ActiveEmployeeCount  
    FROM tblEmployee  
    WHERE IsActive = 1;  
END;  
GO
 -----------------------------------------
	--spGetCurrentShiftPersonalTrainerCount--
-----------------------------------------
CREATE PROC spGetCurrentShiftPersonalTrainerCount  
AS  
BEGIN  
    SET NOCOUNT ON;  
  
    SELECT COUNT(DISTINCT T.TrainerId) AS CurrentShiftPersonalTrainerCount  
    FROM tblTrainer T  
    INNER JOIN tblEmployee E  
        ON T.EmployeeId = E.EmployeeId  
    INNER JOIN tblTrainerShift TS  
        ON T.TrainerId = TS.TrainerId  
    INNER JOIN tblShift S  
        ON TS.ShiftId = S.ShiftId  
    WHERE T.TrainerType = 'Personal'  
      AND E.IsActive = 1  
      AND TS.IsActive = 1  
      AND CAST(GETDATE() AS TIME) >= S.StartTime  
      AND CAST(GETDATE() AS TIME) < S.EndTime;  
END  