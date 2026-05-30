# 🏋️ Gym Management System

![Database](https://img.shields.io/badge/Database-SQL%20Server-blue)
![Architecture](https://img.shields.io/badge/Architecture-3--Tier-green)
![UI](https://img.shields.io/badge/UI-WinForms-orange)

## 📊 Database Schema

This section contains the complete database schema for the Gym Management System.

---

<details>
<summary><b>🔐 tblSuperAdmin</b></summary>

| Column Name | Data Type |
|------------|------------|
| SuperAdminId | INT PRIMARY KEY IDENTITY(1,1) |
| UserName | NVARCHAR(100) |
| PasswordHash | NVARCHAR(255) |
| Email_Id | NVARCHAR(150) |
| PhoneNumber | NVARCHAR(20) |
| LastLogin | DATETIME |
| IsActive | BIT |
| CreatedAt | DATETIME |

</details>

---

<details>
<summary><b>👨‍💼 tblAdmin</b></summary>

| Column Name | Data Type |
|------------|------------|
| AdminId | INT PRIMARY KEY IDENTITY(1,1) |
| SuperAdminID | INT FOREIGN KEY |
| UserName | NVARCHAR(100) |
| PasswordHash | NVARCHAR(255) |
| LastLogin | DATETIME |

</details>

---

<details>
<summary><b>📋 tblMembershipPlans</b></summary>

| Column Name | Data Type |
|------------|------------|
| MembershipPlanId | INT PRIMARY KEY IDENTITY(1,1) |
| MembershipPlanName | NVARCHAR(100) |
| PlanType | NVARCHAR(50) |
| DurationInDays | INT |
| Price | DECIMAL(10,2) |
| Description | NVARCHAR(MAX) |
| IsActive | BIT |

</details>

---

<details>
<summary><b>👤 tblMember</b></summary>

| Column Name | Data Type |
|------------|------------|
| MemberId | INT PRIMARY KEY IDENTITY(1,1) |
| FirstName | NVARCHAR(50) |
| MiddleName | NVARCHAR(50) |
| LastName | NVARCHAR(50) |
| FullName | NVARCHAR(150) |
| Gender | NVARCHAR(20) |
| DOB | DATE |
| Age | INT |
| PhoneNo | NVARCHAR(20) |
| Email_Id | NVARCHAR(150) |
| Address | NVARCHAR(300) |
| City | NVARCHAR(100) |
| District | NVARCHAR(100) |
| State | NVARCHAR(100) |
| EmergencyContact | NVARCHAR(20) |
| ProfilePhoto | NVARCHAR(255) |
| JoiningDate | DATE |
| IsActive | BIT |
| CreatedAt | DATETIME |
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
| Status | NVARCHAR(50) |
| IsActive | BIT |

</details>

---

<details>
<summary><b>⏰ tblShift</b></summary>

| Column Name | Data Type |
|------------|------------|
| ShiftId | INT PRIMARY KEY IDENTITY(1,1) |
| ShiftName | NVARCHAR(100) |
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
| LockerNo | NVARCHAR(20) |
| LockerStatus | NVARCHAR(50) |

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
