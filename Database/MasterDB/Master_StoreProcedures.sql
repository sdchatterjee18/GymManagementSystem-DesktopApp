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
CREATE PROC spGetAvailableTrainerCountByShift
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        s.ShiftID,
        s.ShiftName,
        COUNT(ts.TrainerId) AS AvailableTrainerCount
    FROM tblShift s
    LEFT JOIN tblTrainerShift ts
        ON s.ShiftId = ts.ShiftId
        AND ts.IsActive = 1
    GROUP BY
        s.ShiftId,
        s.ShiftName
    ORDER BY
        s.ShiftID;
END
GO

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
		CONCAT(E.FirstName,' ',E.MiddleName,' ',E.LastName) AS TrainerName,
		T.Specialization,
		E.PhoneNo,
		G.GenderName
		FROM tblTrainer T
		INNER JOIN tblEmployee E
		ON T.EmployeeId=E.EmployeeId
		INNER JOIN tblGender G 
		ON E.GenderId = G.GenderId 
		WHERE T.TrainerType='General' 
		AND E.IsActive=1;
	END TRY
	BEGIN CATCH
		SELECT ERROR_MESSAGE() AS Message;
	END CATCH
END
GO

-------------------------------
-- SP: DisplayPersonalTrainers
-------------------------------
Create PROCEDURE DisplayPersonalTrainers
AS
BEGIN
	BEGIN TRY
		SELECT 
		CONCAT(E.FirstName,' ',E.MiddleName,' ',E.LastName) AS TrainerName,
		T.Specialization,
		E.PhoneNo,
		G.GenderName
		FROM tblTrainer T
		INNER JOIN tblEmployee E
		ON T.EmployeeId=E.EmployeeId
		INNER JOIN tblGender G 
		ON E.GenderId = G.GenderId 
		WHERE T.TrainerType='Personal' 
		AND E.IsActive=1;
	END TRY
	BEGIN CATCH	
		SELECT ERROR_MESSAGE() AS Message;
	END CATCH
END
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
        ON mp.PlanTypeId = mpt.PlanTypeId;
END;
GO

---------------------------------------------
--SP: spRetrieveMembershipPlanDetailsByName--
---------------------------------------------
CREATE PROC spRetrieveMembershipPlanDetailsByName 
(
    @MembershipPlanName VARCHAR(100)
)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        SET @MembershipPlanName = LTRIM(RTRIM(@MembershipPlanName));

        IF @MembershipPlanName = ''
        BEGIN
            SELECT 'Membership Plan Name is required.' AS Message;
            RETURN;
        END;
        IF NOT EXISTS
        (
            SELECT 1
            FROM tblMembershipPlans
            WHERE MembershipPlanName = @MembershipPlanName
        )
        BEGIN
            SELECT 'Membership Plan not found.' AS Message;
            RETURN;
        END;
        SELECT
            MP.MembershipPlanId,
            MP.MembershipPlanName,
            MPT.PlanType,
            MP.DurationInDays,
            MP.Price,
            MP.Description,
            MP.IsActive
        FROM tblMembershipPlans AS MP
        INNER JOIN tblMembershipPlanType AS MPT
            ON MP.PlanTypeId = MPT.PlanTypeId
        WHERE MP.MembershipPlanName = @MembershipPlanName;
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message;
    END CATCH
END;
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

    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message
    END CATCH
END
GO


-------------------------------------------------------------------
                   -- ExpenseManagement SPs --
-------------------------------------------------------------------
------------------------
--SP: spGetAllExpenses--
------------------------
CREATE PROC spRetrieveAllExpenseStatement
AS
BEGIN
BEGIN TRY

    SELECT
        E.ExpenseId,
        C.CategoryName,
        C.Category,
        E.ExpenseAmount,
        E.ExpenseDate,
        E.Notes
    FROM tblExpense E
    INNER JOIN tblExpensesCategories C
        ON E.ExpenseCategoryId = C.ExpenseCategoryID
    ORDER BY E.ExpenseDate DESC;

END TRY
BEGIN CATCH
    SELECT ERROR_MESSAGE() AS Message;
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
    @ExpenseDate DATE,
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
        WHERE ExpenseCategoryID = @ExpenseCategoryId
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

    IF @ExpenseDate IS NULL
    BEGIN
        SELECT 'Expense Date is Required.' AS Message;
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
        @ExpenseDate,
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
    ORDER BY RegistrationFeesId ASC;
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
--SP: spInsertDataIntoMembershipSubscriptionTableWhileReneweal--
----------------------------------------------------------------
CREATE PROC spInsertDataIntoMembershipSubscriptionTableWhileReneweal @MemberId=3,@MembershipPlanId=4,@PaymentMethod='card'
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