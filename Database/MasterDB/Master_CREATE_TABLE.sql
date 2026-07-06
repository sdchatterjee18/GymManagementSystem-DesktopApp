CREATE DATABASE dbGymManagementSystem
GO

USE dbGymManagementSystem
GO

               ------------------------
               ---Independent tables---
               ------------------------

CREATE TABLE tblSuperAdmin
(
    SuperAdminId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
    UserName VARCHAR(100) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    EmailId VARCHAR(150) NOT NULL UNIQUE,
    PhoneNumber VARCHAR(20) NULL,
    LastLogin DATETIME NULL,
    IsActive BIT NOT NULL DEFAULT(0),
    CreatedAt DATETIME NOT NULL DEFAULT(GETDATE())
);
GO

CREATE TABLE tblGender
(
    GenderId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
    GenderName VARCHAR(20) UNIQUE NOT NULL
);
GO

CREATE TABLE tblEmployeeRoleType
(
    RoleId INT PRIMARY KEY IDENTITY(1,1),
    Role VARCHAR(100) NOT NULL UNIQUE
);
GO


CREATE TABLE tblDietPlans(
       DietPlanId INT PRIMARY KEY  NOT NULL IDENTITY(1,1),
       CaloriesPerDay INT CHECK(CaloriesPerDay > 0) NOT NULL,
       DietPlanDocument VARBINARY(MAX) NULL,
       ConditionStatus VARCHAR(MAX) NOT NULL
);
GO

CREATE TABLE tblExercises
(
    ExerciseId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
    ExerciseName VARCHAR(100) NOT NULL UNIQUE,
    MuscleType VARCHAR(100) NOT NULL
);
GO

CREATE TABLE tblExpensesCategories
(
    ExpenseCategoryID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
    CategoryName VARCHAR(100) UNIQUE NOT NULL,
    Category VARCHAR(100) NOT NULL
);
GO

CREATE TABLE tblLocker
(
    LockerId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
    LockerNo VARCHAR(20) UNIQUE NOT NULL,
    LockerStatus VARCHAR(50) NOT NULL DEFAULT('Available')
);
GO

CREATE TABLE tblMembershipPlanType
(
    PlanTypeId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
    PlanType VARCHAR(50) NOT NULL UNIQUE
);
GO


CREATE TABLE tblRegistrationFees(
       RegistrationFeesId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
       FeeAmount DECIMAL(10,2) CHECK(FeeAmount >= 0) NOT NULL,
       IsActive BIT DEFAULT(1) NOT NULL,
       CreatedAt DATETIME 	DEFAULT(GETDATE()) NOT NULL
)
GO

CREATE TABLE tblShift(
    ShiftId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
    ShiftName VARCHAR(100) UNIQUE NOT NULL,
    StartTime TIME NOT NULL,
    EndTime TIME NOT NULL
)
GO

CREATE TABLE tblWorkoutPlans(
       WorkoutPlanId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
       WorkoutName VARCHAR(100) UNIQUE NOT NULL,
       Description VARCHAR(MAX) NULL,
)
GO

CREATE TABLE tblShiftCapacity
(
    CapacityId INT IDENTITY(1,1) PRIMARY KEY,
    MaxCapacity INT NOT NULL
);
GO
               ----------------------
               ---Dependent tables---
               ----------------------

CREATE TABLE tblEmployee
(
    EmployeeId INT PRIMARY KEY NOT NULL IDENTITY(1,1) ,
    FirstName VARCHAR(150) NOT NULL,
    MiddleName VARCHAR(50) NULL,
    LastName VARCHAR(50) NOT NULL,
    GenderId INT NOT NULL,
    RoleId INT NOT NULL,
    PhoneNo VARCHAR(20) UNIQUE NOT NULL,
    EmailId VARCHAR(150) UNIQUE NOT NULL,
    JoiningDate DATE NOT NULL DEFAULT(GETDATE()),
    IsActive BIT NOT NULL DEFAULT(1),
    BankAccountNo VARCHAR(50) UNIQUE NOT NULL,
    CONSTRAINT FK_tblEmployee_GenderIdtblGender
        FOREIGN KEY (GenderId)
        REFERENCES tblGender(GenderId),
   CONSTRAINT FK_tblEmployee_RoleIdtblEmployeeRoleType
       FOREIGN KEY (RoleId)
	   REFERENCES tblEmployeeRoleType(RoleId)
);
GO

CREATE TABLE tblSalary
(
    SalaryId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
    EmployeeId INT NOT NULL,
    Amount DECIMAL(10,2) NOT NULL 
        CHECK (Amount >= 0),

    CONSTRAINT FK_tblSalary_EmployeeIdtblEmployee
        FOREIGN KEY (EmployeeId)
        REFERENCES tblEmployee(EmployeeId)
)
GO

CREATE TABLE tblSalaryPayment
(
    PaymentId INT  PRIMARY KEY NOT NULL IDENTITY(1,1),
    SalaryId INT NOT NULL,
    PaymentMode VARCHAR(50) NOT NULL,
    PaymentMonth VARCHAR(10) NOT NULL,
    PaymentYear INT NOT NULL,
    PaymentDate DATETIME NOT NULL
        DEFAULT(GETDATE()),
    PaymentStatus VARCHAR(50) NOT NULL,

    CONSTRAINT FK_tblSalaryPayment_SalaryIdtblSalary
        FOREIGN KEY (SalaryId)
        REFERENCES tblSalary(SalaryId)
);

CREATE TABLE tblAdmin(
    AdminId INT  PRIMARY KEY IDENTITY(1,1) NOT NULL,
    EmployeeId INT NOT NULL,
    SuperAdminID INT NOT NULL,
    UserName VARCHAR(100) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    LastLogin DATETIME  NULL ,
    CONSTRAINT FK_tblAdmin_EmployeeIdtblEmployee 
		FOREIGN KEY (EmployeeId)
		REFERENCES tblEmployee(EmployeeId),
    CONSTRAINT FK_tblAdmin_SuperAdminIDtblSuperAdmin
		FOREIGN KEY (SuperAdminID)
		REFERENCES tblSuperAdmin(SuperAdminID)
);
GO 

CREATE TABLE tblTrainer
(
	TrainerId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	EmployeeId INT NOT NULL,
	TrainerType VARCHAR(100) NOT NULL,
	Specialization VARCHAR(200),
	JoiningDate DATE DEFAULT(GETDATE()) NOT NULL,
	IsActive BIT Default(1)

	CONSTRAINT FK_tblTrainer_EmployeeIdtblEmployee
	FOREIGN KEY(EmployeeId)
	REFERENCES tblEmployee(EmployeeId) 
);
GO

CREATE TABLE tblCertificateDocument
(
	DocumentId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	TrainerId INT NOT NULL,
	Document VARBINARY(MAX) NULL,
	CONSTRAINT FK_tblCertificateDocument_TrainerIdtblTrainer
	FOREIGN KEY (TrainerId)
	REFERENCES tblTrainer(TrainerId)
);
GO

CREATE TABLE tblTrainerShift
(
	TrainerShiftId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	TrainerId INT NOT NULL,
	ShiftId INT NOT NULL,
	IsActive BIT DEFAULT(1) NOT NULL,

	CONSTRAINT FK_tblTrainerShift_TrainerIdtblTrainer
	FOREIGN KEY(TrainerId)
	REFERENCES tblTrainer(TrainerId),
	CONSTRAINT FK_tblTrainerShift_ShiftIdtblShift
	FOREIGN KEY (ShiftId)
	REFERENCES tblShift(ShiftId)
);
GO

CREATE TABLE tblMember (
    MemberId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    MiddleName VARCHAR(50) NULL,
    LastName VARCHAR(50) NOT NULL,
    GenderId INT NOT NULL,
    PhoneNo VARCHAR(20) NOT NULL UNIQUE,
    EmailId VARCHAR(150) NULL UNIQUE,
    City VARCHAR(100) NOT NULL,
    District VARCHAR(100) NOT NULL,
    State VARCHAR(100) NOT NULL,
    EmergencyContact VARCHAR(20) NULL,
    ProfilePhoto VARBINARY(MAX) NULL,
    JoiningDate DATETIME NOT NULL DEFAULT(GETDATE()),
    IsActive BIT NOT NULL DEFAULT(1),
    UpdatedAt DATETIME NULL,
    CONSTRAINT FK_tblMember_GenderIdtblGender
		FOREIGN KEY (GenderId) 
		REFERENCES tblGender(GenderId)
);
GO

Create Table tblMemberDietAssignment(
	DietAssignmentId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	MemberId INT NOT NULL,
	DietPlanId INT NOT NULL,
	AssignDate Date NOT NULL DEFAULT(GETDATE()),
	IsActive BIT NOT NULL DEFAULT(1),
	CONSTRAINT FK_tblMemberDietAssignment_MemberIdtblMember
		FOREIGN KEY (MemberId) 
		REFERENCES tblMember(MemberId),
	CONSTRAINT FK_tblMemberDietAssignment_DietPlanIdtblDietPlans
		FOREIGN KEY (DietPlanId) 
		REFERENCES tblDietPlans(DietPlanId)
);
GO

CREATE TABLE tblMemberShift
(
	MemberShiftId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	MemberId INT NOT NULL,  
	ShiftId INT NOT NULL,
	IsActive BIT DEFAULT(1),

	CONSTRAINT FK_tblMemberShift_MemberIdtblMember 
	  FOREIGN KEY(MemberId) 
	  REFERENCES tblMember(MemberId) ,
	CONSTRAINT FK_tblMemberShift_ShiftIdtblShift
	  FOREIGN KEY(ShiftId)
	  REFERENCES tblShift(ShiftId) 
);

GO

CREATE TABLE tblLockerAllocation
(
    LockerAllocationId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    LockerId INT NOT NULL,
    MemberId INT NOT NULL,

    CONSTRAINT FK_tblLockerAllocation_LockerIdtblLocker
        FOREIGN KEY (LockerId)
        REFERENCES tblLocker(LockerId),

    CONSTRAINT FK_tblLockerAllocation_MemberIdtblMember
        FOREIGN KEY (MemberId)
        REFERENCES tblMember(MemberId)
);
GO

CREATE TABLE tblMembershipPlans
(
    MembershipPlanId INT PRIMARY KEY IDENTITY(1,1),
    MembershipPlanName VARCHAR(100) NOT NULL,
    PlanTypeId INT NOT NULL,
    DurationInDays INT NOT NULL 
	  CHECK (DurationInDays > 0),
    Price DECIMAL(10,2) NOT NULL 
	  CHECK (Price >= 0),
    Description VARCHAR(MAX) NULL,
    IsActive BIT NOT NULL DEFAULT(1),
      
	CONSTRAINT FK_tblMembershipPlans_PlanTypeIdtblMembershipPlanType
        FOREIGN KEY (PlanTypeId)
        REFERENCES tblMembershipPlanType(PlanTypeId)
);
GO

CREATE TABLE tblMembershipSubscription (
    MemberSubscriptionId  INT PRIMARY KEY NOT NULL IDENTITY(1,1),
    MemberId INT NOT NULL,
    MembershipPlanId INT NOT NULL,
    StartDate DATE NOT NULL,
    ExpiryDate DATE NOT NULL,
    IsActive BIT NOT NULL DEFAULT(1),
    CONSTRAINT FK_tblMemberSubscription_MemberIdtblMember
		FOREIGN KEY (MemberId)
		REFERENCES tblMember(MemberId),
    CONSTRAINT FK_tblMemberSubscription_MembershipPlanIdtblMembershipPlans
		FOREIGN KEY (MembershipPlanId)
		REFERENCES tblMembershipPlans(MembershipPlanId)
);
GO

CREATE TABLE tblSubscriptionPayment(
	PaymentId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	MemberId INT NOT NULL,
	MembershipPlanId INT NOT NULL,
	PaymentDate Date NOT NULL DEFAULT(GETDATE()),
	PaymentMethod VARCHAR(50) NOT NULL,
	Amount DECIMAL(10,2) CHECK(Amount >= 0) NOT NULL,
	FeesType VARCHAR(50) NOT NULL,

	CONSTRAINT FK_tblSubscriptionPayment_MemberIdtblMember
		FOREIGN KEY (MemberId) 
		REFERENCES tblMember(MemberId),
	CONSTRAINT FK_tblSubscriptionPayment_MembershipPlanIdtblMembershipPlans
		FOREIGN KEY (MembershipPlanId) 
		REFERENCES tblMembershipPlans(MembershipPlanId)

);
GO

Create Table tblMemberTrainerAssignment(
	MemberTrainerAssignmentId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	MemberId INT NOT NULL,
	TrainerId INT NOT NULL,
	AssignedDate DATE NOT NULL DEFAULT(GETDATE()),
	IsActive BIT NOT NULL DEFAULT(1),

	CONSTRAINT FK_tblMemberTrainerAssignment_MemberIdtblMember
		FOREIGN KEY (MemberId) 
		REFERENCES tblMember(MemberId),
	CONSTRAINT FK_tblMemberTrainerAssignment_TrainerIdtblTrainer
		FOREIGN KEY (TrainerId) 
		REFERENCES tblTrainer(TrainerId) 
);
GO

CREATE TABLE tblMemberAttendance (
    AttendanceId INT  PRIMARY KEY NOT NULL IDENTITY(1,1),
    MemberId INT NOT NULL,
    ShiftId INT NOT NULL,
    AttendanceDate DATETIME NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT FK_tblMemberAttendance_MemberIdtblMember
		FOREIGN KEY (MemberId)
		REFERENCES tblMember(MemberId),
    CONSTRAINT FK_tblMemberAttendance_ShiftIdtblShift 
		FOREIGN KEY (ShiftId)
		REFERENCES tblShift(ShiftId)
);
GO

CREATE TABLE tblWorkoutSchedule(
	WorkoutScheduleId INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	WorkoutPlanId INT NOT NULL,
	ExerciseId INT NOT NULL,
	WorkoutDay VARCHAR(20) NOT NULL,

	CONSTRAINT FK_tblWorkoutSchedule_WorkoutPlanIdtblWorkoutPlans 
		FOREIGN KEY (WorkoutPlanId) 
		REFERENCES tblWorkoutPlans(WorkoutPlanId),
	CONSTRAINT FK_tblWorkoutSchedule_ExerciseIdtblExercises 
		FOREIGN KEY (ExerciseId) 
		REFERENCES tblExercises(ExerciseId) 
);
GO

CREATE TABLE tblExpense
(
    ExpenseId INT  PRIMARY KEY NOT NULL IDENTITY(1,1),
    ExpenseCategoryId INT NOT NULL,
    ExpenseAmount DECIMAL(10,2) NOT NULL
        CHECK (ExpenseAmount >= 0),
    ExpenseDate DATE NOT NULL,
    Notes VARCHAR(MAX) NULL,
    CONSTRAINT FK_tblExpense_ExpenseCategoryIdtblExpenseCategory
        FOREIGN KEY (ExpenseCategoryId)
        REFERENCES tblExpensesCategories(ExpenseCategoryId)
);
GO

