# 🏋️ Gym Management System

![Database](https://img.shields.io/badge/Database-SQL%20Server-blue)
![Architecture](https://img.shields.io/badge/Architecture-3--Tier-green)

## 📊 Database Schema Overview

The Gym Management System database is designed using a relational database model to efficiently manage gym operations, member activities, staff management, workout planning, diet planning, attendance tracking, payments, and expense management.

The database follows normalization principles to minimize data redundancy, improve consistency, and maintain scalability. Foreign key relationships are used throughout the schema to enforce referential integrity and ensure reliable data management across all modules of the Gym Management System.

---

<details>
<summary><b>🔐 tblSuperAdmin</b></summary>

#### Table: `tblSuperAdmin`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| SuperAdminId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the Super Admin. |
| UserName | VARCHAR(100) | UNIQUE | ❌ No | Login username of the Super Admin. |
| PasswordHash | VARCHAR(255) | - | ❌ No | Encrypted password used for authentication. |
| Email_Id | VARCHAR(150) | UNIQUE | ❌ No | Email address of the Super Admin. |
| PhoneNumber | VARCHAR(20) | - | ✅ Yes | Contact number of the Super Admin. |
| LastLogin | DATETIME | - | ✅ Yes | Stores the last login date and time. |
| IsActive | BIT | DEFAULT(1) | ❌ No | Indicates whether the account is active or inactive. |
| CreatedAt | DATETIME | DEFAULT(GETDATE()) | ❌ No | Stores the account creation date and time. |

</details>

---

<details>
<summary><b>👨‍💼 tblAdmin</b></summary>

#### Table: `tblAdmin`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| AdminId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the Admin. |
| EmployeeId | INT | FOREIGN KEY | ❌ No | References the employee associated with the admin account. |
| SuperAdminID | INT | FOREIGN KEY | ❌ No | References the Super Admin who manages the Admin. |
| UserName | VARCHAR(100) | UNIQUE | ❌ No | Login username of the Admin. |
| PasswordHash | VARCHAR(255) | - | ❌ No | Encrypted password used for authentication. |
| LastLogin | DATETIME | - | ✅ Yes | Stores the last login date and time. |

</details>

---

<details>
<summary><b>📋 tblMembershipPlans</b></summary>

#### Table: `tblMembershipPlans`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| MembershipPlanId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the membership plan. |
| MembershipPlanName | VARCHAR(100) | - | ❌ No | Name of the membership plan. |
| PlanType | VARCHAR(50) | - | ❌ No | Type of membership plan (Monthly, Quarterly, Yearly, etc.). |
| DurationInDays | INT | CHECK(DurationInDays > 0) | ❌ No | Total duration of the plan in days. |
| Price | DECIMAL(10,2) | CHECK(Price >= 0) | ❌ No | Cost of the membership plan. |
| Description | VARCHAR(MAX) | - | ✅ Yes | Detailed information about the membership plan. |
| IsActive | BIT | DEFAULT(1) | ❌ No | Indicates whether the plan is currently available. |

</details>

---

<details>
<summary><b>👤 tblMember</b></summary>

#### Table: `tblMember`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| MemberId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the member. |
| FirstName | VARCHAR(50) | - | ❌ No | Member's first name. |
| MiddleName | VARCHAR(50) | - | ✅ Yes | Member's middle name. |
| LastName | VARCHAR(50) | - | ❌ No | Member's last name. |
| Gender | VARCHAR(20) | CHECK(Gender IN ('Male','Female','Other')) | ❌ No | Member's gender. |
| DOB | DATE | - | ❌ No | Member's date of birth. |
| PhoneNo | VARCHAR(20) | UNIQUE | ❌ No | Contact number of the member. |
| Email_Id | VARCHAR(150) | UNIQUE | ✅ Yes | Email address of the member. |
| Address | VARCHAR(300) | - | ❌ No | Residential address of the member. |
| City | VARCHAR(100) | - | ❌ No | City of residence. |
| District | VARCHAR(100) | - | ❌ No | District of residence. |
| State | VARCHAR(100) | - | ❌ No | State of residence. |
| EmergencyContact | VARCHAR(20) | - | ✅ Yes | Emergency contact number. |
| ProfilePhoto | VARBINARY(MAX) | - | ✅ Yes | Stores the member's profile photo. |
| JoiningDate | DATETIME | DEFAULT(GETDATE()) | ❌ No | Date when the member joined the gym. |
| IsActive | BIT | DEFAULT(1) | ❌ No | Indicates whether the membership is active. |
| UpdatedAt | DATETIME | - | ✅ Yes | Stores the last modification date and time. |

</details>

---

<details>
<summary><b>💳 tblMembershipSubscription</b></summary>

| Column Name | Data Type |
|------------|------------|
| MemberSubscriptionId | INT PRIMARY KEY IDENTITY(1,1) |
| MemberId | INT FOREIGN KEY |
| MembershipPlanId | INT FOREIGN KEY |
| StartDate | DATE |
| ExpiryDate | DATE |
| IsActive | BIT |

</details>

---

<details>
<summary><b>⏰ tblShift</b></summary>

| Column Name | Data Type |
|------------|------------|
| ShiftId | INT PRIMARY KEY IDENTITY(1,1) |
| ShiftName | VARCHAR(100) |
| StartTime | TIME |
| EndTime | TIME |

</details>

---

<details>
<summary><b>🏃 tblMemberShift</b></summary>

| Column Name | Data Type |
|------------|------------|
| MemberShiftId | INT PRIMARY KEY IDENTITY(1,1) |
| MemberId | INT FOREIGN KEY |
| ShiftId | INT FOREIGN KEY |
| IsActive | BIT |

</details>

---

<details>
<summary><b>📅 tblMemberAttendance</b></summary>

| Column Name | Data Type |
|------------|------------|
| AttendanceId | INT PRIMARY KEY IDENTITY(1,1) |
| MemberId | INT FOREIGN KEY |
| ShiftId | INT FOREIGN KEY |
| AttendanceDate | DATETIME |

</details>

---

<details>
<summary><b>🔒 tblLocker</b></summary>

| Column Name | Data Type |
|------------|------------|
| LockerId | INT PRIMARY KEY IDENTITY(1,1) |
| LockerNo | VARCHAR(20) |
| LockerStatus | VARCHAR(50) |

</details>

---

<details>
<summary><b>🗄️ tblLockerAllocation</b></summary>

| Column Name | Data Type |
|------------|------------|
| LockerAllocationId | INT PRIMARY KEY IDENTITY(1,1) |
| LockerId | INT FOREIGN KEY |
| MemberId | INT FOREIGN KEY |
| ExpiryDate | DATE |

</details>

---

<details>
<summary><b>🏋️ tblTrainer</b></summary>

#### Table: tblTrainer

| Column Name    | Data Type                     |
| -------------- | ----------------------------- |
| TrainerId      | INT PRIMARY KEY IDENTITY(1,1) |
| EmployeeId     | INT FOREIGN KEY               |
| TrainerType    | NVARCHAR(100)                 |
| Specialization | NVARCHAR(200)                 |
| JoiningDate    | DATE                          |
| IsActive       | BIT                           |

</details>

---

<details>
<summary><b>⏰ tblTrainerShift</b></summary>

#### Table: tblTrainerShift

| Column Name    | Data Type                     |
| -------------- | ----------------------------- |
| TrainerShiftId | INT PRIMARY KEY IDENTITY(1,1) |
| TrainerId      | INT FOREIGN KEY               |
| ShiftId        | INT FOREIGN KEY               |
| IsActive       | BIT                           |

</details>

---

<details>
<summary><b>🤝 tblMemberTrainerAssignment</b></summary>

#### Table: tblMemberTrainerAssignment

| Column Name               | Data Type                     |
| ------------------------- | ----------------------------- |
| MemberTrainerAssignmentId | INT PRIMARY KEY IDENTITY(1,1) |
| MemberId                  | INT FOREIGN KEY               |
| TrainerId                 | INT FOREIGN KEY               |
| AssignedDate              | DATE                          |
| IsActive                  | BIT                           |

</details>

---

<details>
<summary><b>💰 tblRegistrationFees</b></summary>

#### Table: tblRegistrationFees

| Column Name        | Data Type                     |
| ------------------ | ----------------------------- |
| RegistrationFeesId | INT PRIMARY KEY IDENTITY(1,1) |
| FeeAmount          | DECIMAL(10,2)                 |
| IsActive           | BIT                           |
| CreatedAt          | GETDATE()                     |

</details>

---

<details>
<summary><b>💳 tblSubscriptionPayment</b></summary>

#### Table: tblSubscriptionPayment

| Column Name        | Data Type                     |
| ------------------ | ----------------------------- |
| PaymentId          | INT PRIMARY KEY IDENTITY(1,1) |
| MemberId           | INT FOREIGN KEY               |
| MembershipPlanId   | INT FOREIGN KEY               |
| PaymentDate        | DATETIME                      |
| PaymentMethod      | VARCHAR(50)                   |
| Amount             | DECIMAL(10,2)                 |
| FeesType           | VARCHAR(50)                   |
| TransactionId      | VARCHAR(100)                  |

</details>

---

<details>
<summary><b>📂 tblExpensesCategories</b></summary>

#### Table: tblExpensesCategories

| Column Name       | Data Type                     |
| ----------------- | ----------------------------- |
| ExpenseCategoryID | INT PRIMARY KEY IDENTITY(1,1) |
| CategoryName      | VARCHAR(100)                  |
| Category          | VARCHAR(100)                  |

</details>

---

<details>
<summary><b>📉 tblExpenses</b></summary>

#### Table: tblExpenses

| Column Name       | Data Type                     |
| ----------------- | ----------------------------- |
| ExpenseId         | INT PRIMARY KEY IDENTITY(1,1) |
| ExpenseCategoryId | INT FOREIGN KEY               |
| ExpenseAmount     | DECIMAL(10,2)                 |
| ExpenseDate       | DATE                          |
| Notes             | VARCHAR(MAX)                  |

</details>

---

<details>
<summary><b>👨‍💼 tblEmployee</b></summary>

#### Table: `tblEmployee`

| Column Name   | Data Type                     |
| ------------- | ----------------------------- |
| EmployeeId    | INT PRIMARY KEY IDENTITY(1,1) |
| MiddleName    | VARCHAR(50)                   |
| LastName      | VARCHAR(50)                   |
| FullName      | VARCHAR(150)                  |
| PhoneNo       | VARCHAR(20)                   |
| EmailId       | VARCHAR(150)                  |
| JoiningDate   | DATE                          |
| IsActive      | BIT                           |
| RoleName      | VARCHAR(100)                  |
| BankAccountNo | VARCHAR(50)                   |

</details>

---

<details>
<summary><b>💵 tblSalary</b></summary>

#### Table: `tblSalary`

| Column Name | Data Type                     |
| ----------- | ----------------------------- |
| SalaryId    | INT PRIMARY KEY IDENTITY(1,1) |
| EmployeeId  | INT FOREIGN KEY               |
| Amount      | DECIMAL(10,2)                 |

</details>

---

<details>
<summary><b>💸 tblSalaryPayment</b></summary>

#### Table: `tblSalaryPayment`

| Column Name   | Data Type                     |
| ------------- | ----------------------------- |
| PaymentId     | INT PRIMARY KEY IDENTITY(1,1) |
| SalaryId      | INT FOREIGN KEY               |
| PaymentMode   | VARCHAR(50)                   |
| PaymentMonth  | VARCHAR(10)                   |
| PaymentYear   | INT                           |
| PaymentDate   | DATE                          |
| PaymentStatus | VARCHAR(50)                   |

</details>

---

<details>
<summary><b>🏋️‍♂️ tblWorkoutPlans</b></summary>

#### Table: `tblWorkoutPlans`

| Column Name   | Data Type                     |
| ------------- | ----------------------------- |
| WorkoutPlanId | INT PRIMARY KEY IDENTITY(1,1) |
| WorkoutName   | VARCHAR(100)                  |
| Description   | VARCHAR(MAX)                  |

</details>

---

<details>
<summary><b>🏃 tblExercises</b></summary>

#### Table: `tblExercises`

| Column Name  | Data Type                     |
| ------------ | ----------------------------- |
| ExerciseId   | INT PRIMARY KEY IDENTITY(1,1) |
| ExerciseName | VARCHAR(100)                  |
| MuscletType  | VARCHAR(100)                  |

</details>

---

<details>
<summary><b>📅 tblWorkoutSchedule</b></summary>

#### Table: `tblWorkoutSchedule`

| Column Name       | Data Type                     |
| ----------------- | ----------------------------- |
| WorkoutScheduleId | INT PRIMARY KEY IDENTITY(1,1) |
| WorkoutPlanId     | INT FOREIGN KEY               |
| ExerciseId        | INT FOREIGN KEY               |
| WorkoutDay        | VARCHAR(20)                   |

</details>

---

<details>
<summary><b>🥗 tblDietPlans</b></summary>

#### Table: `tblDietPlans`

| Column Name      | Data Type                     |
| ---------------- | ----------------------------- |
| DietPlanId       | INT PRIMARY KEY IDENTITY(1,1) |
| CaloriesPerDay   | INT                           |
| DietPlanDocument | VARCHAR(255)                  |
| ConditionStatus  | VARCHAR(100)                  |

</details>

---

<details>
<summary><b>🍎 tblMemberDietAssignment</b></summary>

#### Table: `tblMemberDietAssignment`

| Column Name      | Data Type                     |
| ---------------- | ----------------------------- |
| DietAssignmentId | INT PRIMARY KEY IDENTITY(1,1) |
| MemberId         | INT FOREIGN KEY               |
| DietPlanId       | INT FOREIGN KEY               |
| AssignDate       | DATE                          |
| IsActive         | BIT                           |

</details>

---

## 🔗 Foreign Key Relationships

| Parent Table          | Child Table                | Foreign Key       | Relationship Type |
| --------------------- | -------------------------- | ----------------- | ----------------- |
| tblEmployee           | tblAdmin                   | EmployeeId        | One-to-One (1:1)  |
| tblSuperAdmin         | tblAdmin                   | SuperAdminID      | One-to-Many (1:N) |
| tblMember             | tblMembershipSubscription  | MemberId          | One-to-Many (1:N) |
| tblMembershipPlans    | tblMembershipSubscription  | MembershipPlanId  | One-to-Many (1:N) |
| tblMember             | tblMemberShift             | MemberId          | One-to-Many (1:N) |
| tblShift              | tblMemberShift             | ShiftId           | One-to-Many (1:N) |
| tblMember             | tblMemberAttendance        | MemberId          | One-to-Many (1:N) |
| tblShift              | tblMemberAttendance        | ShiftId           | One-to-Many (1:N) |
| tblLocker             | tblLockerAllocation        | LockerId          | One-to-Many (1:N) |
| tblMember             | tblLockerAllocation        | MemberId          | One-to-Many (1:N) |
| tblEmployee           | tblTrainer                 | EmployeeId        | One-to-One (1:1)  |
| tblTrainer            | tblTrainerShift            | TrainerId         | One-to-Many (1:N) |
| tblShift              | tblTrainerShift            | ShiftId           | One-to-Many (1:N) |
| tblMember             | tblMemberTrainerAssignment | MemberId          | One-to-Many (1:N) |
| tblTrainer            | tblMemberTrainerAssignment | TrainerId         | One-to-Many (1:N) |
| tblMember             | tblSubscriptionPayment     | MemberId          | One-to-Many (1:N) |
| tblMembershipPlans    | tblSubscriptionPayment     | MembershipPlanId  | One-to-Many (1:N) |
| tblExpensesCategories | tblExpenses                | ExpenseCategoryId | One-to-Many (1:N) |
| tblEmployee           | tblSalary                  | EmployeeId        | One-to-One (1:1)  |
| tblSalary             | tblSalaryPayment           | SalaryId          | One-to-Many (1:N) |
| tblWorkoutPlans       | tblWorkoutSchedule         | WorkoutPlanId     | One-to-Many (1:N) |
| tblExercises          | tblWorkoutSchedule         | ExerciseId        | One-to-Many (1:N) |
| tblMember             | tblMemberDietAssignment    | MemberId          | One-to-Many (1:1) |
| tblDietPlans          | tblMemberDietAssignment    | DietPlanId        | One-to-Many (1:N) |

---

### 📌 Master Tables

The following tables act as master/parent tables:

* 🔐 tblSuperAdmin
* 📋 tblMembershipPlans
* ⏰ tblShift
* 🔒 tblLocker
* 💰 tblRegistrationFees
* 📂 tblExpensesCategories
* 👨‍💼 tblEmployee
* 🏋️‍♂️ tblWorkoutPlans
* 🏃 tblExercises
* 🥗 tblDietPlans

---

### 📊 Junction / Mapping Tables

These tables are used to connect two entities:

* 🏃 tblMemberShift
* ⏰ tblTrainerShift
* 🤝 tblMemberTrainerAssignment
* 🗄️ tblLockerAllocation
* 🍎 tblMemberDietAssignment
* 📅 tblWorkoutSchedule
