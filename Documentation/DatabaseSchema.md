# 🏋️ Gym Management System

![Database](https://img.shields.io/badge/Database-SQL%20Server-blue)
![Architecture](https://img.shields.io/badge/Architecture-3--Tier-green)

## 📊 Database Schema

This section contains the complete database schema for the Gym Management System.

---

<details>
<summary><b>🔐 tblSuperAdmin</b></summary>

| Column Name | Data Type |
|------------|------------|
| SuperAdminId | INT PRIMARY KEY IDENTITY(1,1) |
| UserName | VARCHAR(100) |
| PasswordHash | VARCHAR(255) |
| Email_Id | VARCHAR(150) |
| PhoneNumber | VARCHAR(20) |
| LastLogin | DATETIME |
| IsActive | BIT |
| CreatedAt | GETDATE() |

</details>

---

<details>
<summary><b>👨‍💼 tblAdmin</b></summary>

| Column Name | Data Type |
|------------|------------|
| AdminId | INT PRIMARY KEY IDENTITY(1,1) |
| SuperAdminID | INT FOREIGN KEY |
| UserName | VARCHAR(100) |
| PasswordHash | VARCHAR(255) |
| LastLogin | DATETIME |

</details>

---

<details>
<summary><b>📋 tblMembershipPlans</b></summary>

| Column Name | Data Type |
|------------|------------|
| MembershipPlanId | INT PRIMARY KEY IDENTITY(1,1) |
| MembershipPlanName | VARCHAR(100) |
| PlanType | VARCHAR(50) |
| DurationInDays | INT |
| Price | DECIMAL(10,2) |
| Description | VARCHAR(MAX) |
| IsActive | BIT |

</details>

---

<details>
<summary><b>👤 tblMember</b></summary>

| Column Name | Data Type |
|------------|------------|
| MemberId | INT PRIMARY KEY IDENTITY(1,1) |
| FullName | VARCHAR(50) |
| FirstName | VARCHAR(50) |
| MiddleName | VARCHAR(50) |
| LastName | VARCHAR(50) |
| Gender | VARCHAR(20) |
| DOB | DATE |
| PhoneNo | VARCHAR(20) |
| Email_Id | VARCHAR(150) |
| Address | VARCHAR(300) |
| City | VARCHAR(100) |
| District | VARCHAR(100) |
| State | VARCHAR(100) |
| EmergencyContact | VARCHAR(20) |
| ProfilePhoto | VARBINARY(255) |
| JoiningDate | GETDATE() |
| IsActive | BIT |
| UpdatedAt | DATETIME |

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
| Status | VARCHAR(50) |
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
| TrainerType    | NVARCHAR(100)                 |
| Specialization | NVARCHAR(200)                 |
| JoiningDate    | DATE                          |
| IsActive       | BIT                           |

</details>

---

<details>
<summary><b>🏋️ tblTrainer</b></summary>

#### Table: tblTrainerCertificateDocument

| Column Name    | Data Type                       |
| -------------- | --------------------------------|
| CertificateId  | INT PRIMARY KEY IDENTITY(1,1)   |
| TrainerId      | INT FOREIGN KEY                 |
| DOCUMENT       | VARBINARY(200)                  |

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

