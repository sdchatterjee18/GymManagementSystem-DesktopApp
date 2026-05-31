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
| GenderId | INT | FOREIGN KEY | ❌ No | References member Gender from gender table |
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

#### Table: `tblMembershipSubscription`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| MemberSubscriptionId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the membership subscription. |
| MemberId | INT | FOREIGN KEY | ❌ No | References the member who purchased the subscription. |
| MembershipPlanId | INT | FOREIGN KEY | ❌ No | References the selected membership plan. |
| StartDate | DATE | - | ❌ No | Subscription start date. |
| ExpiryDate | DATE | - | ❌ No | Subscription expiration date. |
| IsActive | BIT | DEFAULT(1) | ❌ No | Indicates whether the subscription is currently active. |

</details>

---

<details>
<summary><b>⏰ tblShift</b></summary>

#### Table: `tblShift`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| ShiftId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the shift. |
| ShiftName | VARCHAR(100) | UNIQUE | ❌ No | Name of the shift (Morning, Evening, etc.). |
| StartTime | TIME | - | ❌ No | Shift start time. |
| EndTime | TIME | - | ❌ No | Shift end time. |

</details>

---

<details>
<summary><b>🏃 tblMemberShift</b></summary>

#### Table: `tblMemberShift`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| MemberShiftId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the member-shift assignment. |
| MemberId | INT | FOREIGN KEY | ❌ No | References the assigned member. |
| ShiftId | INT | FOREIGN KEY | ❌ No | References the assigned shift. |
| IsActive | BIT | DEFAULT(1) | ❌ No | Indicates whether the shift assignment is active. |

</details>

---

<details>
<summary><b>📅 tblMemberAttendance</b></summary>

#### Table: `tblMemberAttendance`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| AttendanceId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the attendance record. |
| MemberId | INT | FOREIGN KEY | ❌ No | References the member whose attendance is recorded. |
| ShiftId | INT | FOREIGN KEY | ❌ No | References the shift attended by the member. |
| AttendanceDate | DATETIME | DEFAULT(GETDATE()) | ❌ No | Date and time when attendance was marked. |

</details>

---

<details>
<summary><b>🔒 tblLocker</b></summary>

#### Table: `tblLocker`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| LockerId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the locker. |
| LockerNo | VARCHAR(20) | UNIQUE | ❌ No | Unique locker number assigned within the gym. |
| LockerStatus | VARCHAR(50) | DEFAULT('Available') | ❌ No | Current status of the locker (Available, Occupied, Maintenance, etc.). |

</details>

---

<details>
<summary><b>🗄️ tblLockerAllocation</b></summary>

#### Table: `tblLockerAllocation`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| LockerAllocationId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the locker allocation record. |
| LockerId | INT | FOREIGN KEY | ❌ No | References the locker assigned to a member. |
| MemberId | INT | FOREIGN KEY | ❌ No | References the member who is assigned the locker. |
| ExpiryDate | DATE | - | ❌ No | Date when the locker allocation expires. |

</details>

---

<details>
<summary><b>🏋️ tblTrainer</b></summary>

#### Table: `tblTrainer`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| TrainerId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the trainer. |
| EmployeeId | INT | FOREIGN KEY | ❌ No | References the employee record associated with the trainer. |
| TrainerType | VARCHAR(100) | - | ❌ No | Type of trainer (Personal Trainer, Fitness Coach, Yoga Instructor, etc.). |
| Specialization | VARCHAR(200) | - | ✅ Yes | Trainer's area of expertise or specialization. |
| JoiningDate | DATE | DEFAULT(GETDATE()) | ❌ No | Date when the trainer joined the gym. |
| IsActive | BIT | DEFAULT(1) | ❌ No | Indicates whether the trainer is currently active. |

</details>

---

<details>
<summary><b>⏰ tblTrainerShift</b></summary>

#### Table: `tblTrainerShift`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| TrainerShiftId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the trainer shift assignment. |
| TrainerId | INT | FOREIGN KEY | ❌ No | References the assigned trainer. |
| ShiftId | INT | FOREIGN KEY | ❌ No | References the assigned shift. |
| IsActive | BIT | DEFAULT(1) | ❌ No | Indicates whether the trainer shift assignment is active. |

</details>

---

<details>
<summary><b>🤝 tblMemberTrainerAssignment</b></summary>

#### Table: `tblMemberTrainerAssignment`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| MemberTrainerAssignmentId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the member-trainer assignment. |
| MemberId | INT | FOREIGN KEY | ❌ No | References the member assigned to the trainer. |
| TrainerId | INT | FOREIGN KEY | ❌ No | References the assigned trainer. |
| AssignedDate | DATE | DEFAULT(GETDATE()) | ❌ No | Date when the trainer was assigned to the member. |
| IsActive | BIT | DEFAULT(1) | ❌ No | Indicates whether the assignment is currently active. |

</details>

---

<details>
<summary><b>💰 tblRegistrationFees</b></summary>

#### Table: `tblRegistrationFees`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| RegistrationFeesId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the registration fee record. |
| FeeAmount | DECIMAL(10,2) | CHECK(FeeAmount >= 0) | ❌ No | Registration fee amount charged to new members. |
| IsActive | BIT | DEFAULT(1) | ❌ No | Indicates whether the registration fee is currently active. |
| CreatedAt | DATETIME | DEFAULT(GETDATE()) | ❌ No | Stores the date and time when the record was created. |

</details>

---

<details>
<summary><b>💳 tblSubscriptionPayment</b></summary>

#### Table: `tblSubscriptionPayment`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| PaymentId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the payment transaction. |
| MemberId | INT | FOREIGN KEY | ❌ No | References the member who made the payment. |
| MembershipPlanId | INT | FOREIGN KEY | ❌ No | References the membership plan purchased. |
| PaymentDate | DATETIME | DEFAULT(GETDATE()) | ❌ No | Date and time when the payment was made. |
| PaymentMethod | VARCHAR(50) | - | ❌ No | Method used for payment (Cash, UPI, Card, Bank Transfer, etc.). |
| Amount | DECIMAL(10,2) | CHECK(Amount >= 0) | ❌ No | Total amount paid by the member. |
| FeesType | VARCHAR(50) | - | ❌ No | Type of fee being paid (Registration, Renewal, Subscription, etc.). |
| TransactionId | VARCHAR(100) | UNIQUE | ✅ Yes | External transaction reference number for digital payments. |

</details>

---

<details>
<summary><b>📂 tblExpensesCategories</b></summary>

#### Table: `tblExpensesCategories`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| ExpenseCategoryID | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the expense category. |
| CategoryName | VARCHAR(100) | UNIQUE | ❌ No | Name of the expense category. |
| Category | VARCHAR(100) | - | ❌ No | General classification of the expense. |

</details>

---

<details>
<summary><b>📉 tblExpenses</b></summary>

#### Table: `tblExpenses`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| ExpenseId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the expense record. |
| ExpenseCategoryId | INT | FOREIGN KEY | ❌ No | References the expense category. |
| ExpenseAmount | DECIMAL(10,2) | CHECK(ExpenseAmount >= 0) | ❌ No | Amount spent for the expense. |
| ExpenseDate | DATE | - | ❌ No | Date when the expense occurred. |
| Notes | VARCHAR(MAX) | - | ✅ Yes | Additional remarks or details about the expense. |

</details>

---

<details>
<summary><b>👨‍💼 tblEmployee</b></summary>

#### Table: `tblEmployee`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| EmployeeId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the employee. |
| FirstName | VARCHAR(150) | - | ❌ No | Employee's First name. |
| MiddleName | VARCHAR(50) | - | ✅ Yes | Employee's middle name. |
| LastName | VARCHAR(50) | - | ❌ No | Employee's last name. |
| GenderId | INT | FOREIGN KEY | ❌ No | References the Gender of the employee from GenderTable |
| PhoneNo | VARCHAR(20) | UNIQUE | ❌ No | Employee's contact number. |
| EmailId | VARCHAR(150) | UNIQUE | ❌ No | Employee's email address. |
| JoiningDate | DATE | DEFAULT(GETDATE()) | ❌ No | Date when the employee joined the organization. |
| IsActive | BIT | DEFAULT(1) | ❌ No | Indicates whether the employee is currently active. |
| RoleName | VARCHAR(100) | - | ❌ No | Designation or role of the employee. |
| BankAccountNo | VARCHAR(50) | UNIQUE | ❌ No | Employee's bank account number for salary processing. |

</details>

---

<details>
<summary><b>💵 tblSalary</b></summary>

#### Table: `tblSalary`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| SalaryId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the salary record. |
| EmployeeId | INT | FOREIGN KEY | ❌ No | References the employee receiving the salary. |
| Amount | DECIMAL(10,2) | CHECK(Amount >= 0) | ❌ No | Monthly salary amount assigned to the employee. |

</details>

---

<details>
<summary><b>💸 tblSalaryPayment</b></summary>

#### Table: `tblSalaryPayment`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| PaymentId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the salary payment. |
| SalaryId | INT | FOREIGN KEY | ❌ No | References the salary record being paid. |
| PaymentMode | VARCHAR(50) | - | ❌ No | Mode of salary payment (Cash, Bank Transfer, Cheque, etc.). |
| PaymentMonth | VARCHAR(10) | - | ❌ No | Month for which the salary is paid. |
| PaymentYear | INT | - | ❌ No | Year for which the salary is paid. |
| PaymentDate | DATE | DEFAULT(GETDATE()) | ❌ No | Actual date when the salary payment was processed. |
| PaymentStatus | VARCHAR(50) | DEFAULT('Pending') | ❌ No | Current payment status (Pending, Paid, Failed, etc.). |

</details>

---

<details>
<summary><b>🏋️‍♂️ tblWorkoutPlans</b></summary>

#### Table: `tblWorkoutPlans`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| WorkoutPlanId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the workout plan. |
| WorkoutName | VARCHAR(100) | UNIQUE | ❌ No | Name of the workout plan. |
| Description | VARCHAR(MAX) | - | ✅ Yes | Detailed description of the workout plan, exercises, and objectives. |

</details>

---

<details>
<summary><b>🏃 tblExercises</b></summary>

#### Table: `tblExercises`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| ExerciseId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the exercise. |
| ExerciseName | VARCHAR(100) | UNIQUE | ❌ No | Name of the exercise. |
| MuscletType | VARCHAR(100) | - | ❌ No | Target muscle group for the exercise (Chest, Back, Legs, etc.). |

</details>

---

<details>
<summary><b>📅 tblWorkoutSchedule</b></summary>

#### Table: `tblWorkoutSchedule`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| WorkoutScheduleId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the workout schedule. |
| WorkoutPlanId | INT | FOREIGN KEY | ❌ No | References the associated workout plan. |
| ExerciseId | INT | FOREIGN KEY | ❌ No | References the exercise included in the workout plan. |
| WorkoutDay | VARCHAR(20) | - | ❌ No | Scheduled day for performing the exercise. |

</details>

---

<details>
<summary><b>🥗 tblDietPlans</b></summary>

#### Table: `tblDietPlans`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| DietPlanId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the diet plan. |
| CaloriesPerDay | INT | CHECK(CaloriesPerDay > 0) | ❌ No | Recommended daily calorie intake. |
| DietPlanDocument | VARCHAR(255) | - | ✅ Yes | File path or document containing the detailed diet plan. |
| ConditionStatus | VARCHAR(100) | - | ❌ No | Intended condition or fitness goal (Weight Loss, Muscle Gain, Maintenance, etc.). |

</details>

---

<details>
<summary><b>🍎 tblMemberDietAssignment</b></summary>

#### Table: `tblMemberDietAssignment`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| DietAssignmentId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for the diet assignment. |
| MemberId | INT | FOREIGN KEY | ❌ No | References the member assigned to the diet plan. |
| DietPlanId | INT | FOREIGN KEY | ❌ No | References the assigned diet plan. |
| AssignDate | DATE | DEFAULT(GETDATE()) | ❌ No | Date when the diet plan was assigned. |
| IsActive | BIT | DEFAULT(1) | ❌ No | Indicates whether the diet plan assignment is currently active. |

</details>

---

<details>
<summary><b>🍎 tblGender</b></summary>

#### Table: `tblGender`

| Column Name | Data Type | Constraint | Null Allowed | Description |
|------------|------------|------------|------------|------------|
| GendreId | INT | PRIMARY KEY, IDENTITY(1,1) | ❌ No | Unique identifier for Genders |
| Gender | VARCHAR(15) | - | ❌ No | Name of the Gender |

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
| tblMember             | tblLockerAllocation        | MemberId          | One-to-Many (1:1) |
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
