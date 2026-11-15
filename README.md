# 🏋️ Gym Management System (Desktop Application)

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Language](https://img.shields.io/badge/Language-C%23-239120?logo=csharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![UI Platform](https://img.shields.io/badge/Platform-Windows%20Forms-0078D6?logo=windows&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/)
[![Database](https://img.shields.io/badge/Database-Microsoft%20SQL%20Server-CC292B?logo=microsoftsqlserver&logoColor=white)](https://www.microsoft.com/en-us/sql-server/)
[![Architecture](https://img.shields.io/badge/Architecture-3--Tier%20Architecture-brightgreen)](#-architecture-overview)
[![License](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

> A comprehensive, feature-rich desktop application engineered to automate and streamline daily gym operations, member registrations, personal training, scheduling, billing, lockers, and financial accounting.

---

## 📖 Table of Contents

- [About The Project](#-about-the-project)
- [Architecture Overview](#-architecture-overview)
- [Key Features & Modules](#-key-features--modules)
  - [Dual-Tier Administration & Security](#1-dual-tier-administration--security)
  - [Member Lifecycle & Profile Management](#2-member-lifecycle--profile-management)
  - [Membership Plans & Renewals](#3-membership-plans--renewals)
  - [Trainer & Employee Management](#4-trainer--employee-management)
  - [Shift & Attendance Tracking](#5-shift--attendance-tracking)
  - [Workout & Exercise Scheduling](#6-workout--exercise-scheduling)
  - [Diet & Nutrition Planner](#7-diet--nutrition-planner)
  - [Locker Allocation System](#8-locker-allocation-system)
  - [Billing, Payments & Expense Tracking](#9-billing-payments--expense-tracking)
  - [Analytics, Reports & Data Export](#10-analytics-reports--data-export)
- [Database & Stored Procedures](#-database--stored-procedures)
- [Technology Stack](#-technology-stack)
- [Project Directory Structure](#-project-directory-structure)
- [Installation & Getting Started](#-installation--getting-started)
  - [Prerequisites](#prerequisites)
  - [Database Setup](#1-database-setup)
  - [Connection String Configuration](#2-connection-string-configuration)
  - [Build and Run](#3-build-and-run)
- [Team Members](#-team-members)
- [Future Roadmap](#-future-roadmap)
- [Contributing](#-contributing)
- [License](#-license)

---

## 🎯 About The Project

Managing a modern fitness center involves handling numerous operational challenges: tracking subscriptions, renewing memberships, managing shifts, allocating personal trainers, assigning lockers, tracking member attendance, and maintaining accurate accounts.

The **Gym Management System Desktop App** provides a reliable, all-in-one solution designed with a **3-Tier Architecture** (Presentation, Business Logic, and Data Access) and backed by **Microsoft SQL Server**. It minimizes manual paperwork, eliminates administrative overhead, enforces data integrity through database constraints and validation, and delivers actionable financial intelligence for gym administrators and fitness facility managers.

---

## 🏛️ Architecture Overview

The application is designed using a 3-Tier Architecture to guarantee maintainability, testability, separation of concerns, and scalability:

```text
┌─────────────────────────────────────────────────────────────┐
│                 PRESENTATION LAYER (UI)                     │
│   Windows Forms (WinForms) | Modern Dashboard Controls      │
│   Data Visualization Charts | Image Cropping & Dialogs      │
└──────────────────────────────┬──────────────────────────────┘
                               │ Calls
                               ▼
┌─────────────────────────────────────────────────────────────┐
│               BUSINESS LOGIC LAYER (BLL)                    │
│   GymManagementSystemBLLayer                                │
│   Validation Rules | Calculations | Business Workflows      │
└──────────────────────────────┬──────────────────────────────┘
                               │ Invokes
                               ▼
┌─────────────────────────────────────────────────────────────┐
│                 DATA ACCESS LAYER (DAL)                     │
│   GymManagementSystemDALayer (ADO.NET)                      │
│   SqlHelper | DBConnection | Parameterized Stored Procs    │
└──────────────────────────────┬──────────────────────────────┘
                               │ Queries / Executes
                               ▼
┌─────────────────────────────────────────────────────────────┐
│                    DATABASE LAYER                           │
│   Microsoft SQL Server (dbGymManagementSystem)              │
│   Relational Normalized Tables | Master Stored Procedures   │
└─────────────────────────────────────────────────────────────┘
```

---

## 🚀 Key Features & Modules

### 1. Dual-Tier Administration & Security
* **Super Admin Portal:** Full administrative authority over the entire gym business, employee management, salary disbursements, financial auditing, and profit/loss reporting.
* **Admin Portal:** Day-to-day operations handling member check-ins, fee collections, plan renewals, workout schedules, and shift allocations.
* **Security & Auth:** Secure credential handling, password recovery (`FrmForgotPassword`), role selection (`FrmUserRoleSelection`), and admin credential management.

### 2. Member Lifecycle & Profile Management
* **Comprehensive Registration:** Capture personal data, emergency contacts, blood group, medical considerations, and contact details.
* **Integrated Photo Crop:** Built-in photo capture and image cropper (`FrmCropImage`) to store standardized profile photos directly into the database.
* **Comprehensive Member Profile:** Interactive member cards showcasing active plan details, assigned trainer, locker number, assigned shift, and attendance history.

### 3. Membership Plans & Renewals
* **Custom Plan Engine:** Create and configure flexible plans (Monthly, Quarterly, Semi-Annual, Annual, VIP) with specific durations, features, and pricing.
* **Subscription Management:** Automated calculation of plan start dates, expiry dates, grace periods, and renewal statuses.
* **Registration Fee Management:** Configurable one-time enrollment charges and fee structures.

### 4. Trainer & Employee Management
* **Trainer Profiles:** Track trainer qualifications, certifications (`tblCertificateDocument`), specializations, and shifts.
* **Member-Trainer Mapping:** Seamless assignment and reassignment of trainers to members (`FrmMemberTrainerAssignment`, `FrmChangeTrainer`).
* **Staff & Payroll Management:** Super Admin module for managing gym staff, attendance-based salary calculations, and payment tracking (`tblSalaryPayment`).

### 5. Shift & Attendance Tracking
* **Flexible Shifts:** Morning, Afternoon, Evening, and Custom time blocks for members and trainers.
* **Member Attendance:** Daily check-in logging (`FrmMarkAttendance`), attendance lookup by date/month, and absence history tracking (`FrmAttendanceHistory`).
* **Shift Reallocation:** Facility to switch member shifts based on preference or capacity limits.

### 6. Workout & Exercise Scheduling
* **Exercise Library:** Categorized database of exercises grouped by muscle group, difficulty level, and equipment requirements.
* **Custom Workout Plans:** Create workout templates (e.g., Weight Loss, Muscle Building, Endurance, HIIT).
* **Weekly Schedules:** Day-by-day workout scheduling customized for individual members.
* **Fitness Assessments:** Record and track fitness test results and progress over time (`FrmFitnessTest`).

### 7. Diet & Nutrition Planner
* **Nutritional Meal Plans:** Create dietary templates with calorie goals, macronutrient splits (carbs, proteins, fats), and meal timings.
* **Member Diet Assignment:** Assign or customize diet charts based on a member's fitness objectives.

### 8. Locker Allocation System
* **Locker Inventory:** Track numbered lockers, status (Vacant, Occupied, Under Maintenance).
* **Locker Assignment:** Issue lockers to members for the duration of active memberships with automated expiry management.

### 9. Billing, Payments & Expense Tracking
* **Point-of-Sale Billing:** Record payments for subscription fees, registration charges, and personal training.
* **Expense Management:** Categorized logging of operational expenditures (Equipment Maintenance, Utilities, Rent, Salaries, Supplies).
* **Payment History:** Searchable payment logs with status filters and transaction dates.

### 10. Analytics, Reports & Data Export
* **Executive Dashboard:** Visual KPIs displaying total active members, monthly revenue, pending renewals, today's attendance, and net profit.
* **Charting & Trends:** Integrated `System.Windows.Forms.DataVisualization` charts for revenue trends and member influx.
* **Office Integration:** Export financial statements, member directories, and attendance reports directly into **Microsoft Excel** and **Microsoft Word**.

---

## 🗄️ Database & Stored Procedures

The database schema is normalized and optimized for high-throughput relational data operations:

* **Tables:** Over 28 interconnected tables enforcing strict referential integrity (`tblSuperAdmin`, `tblAdmin`, `tblMember`, `tblMembershipPlans`, `tblMembershipSubscription`, `tblMemberAttendance`, `tblTrainer`, `tblExpenses`, `tblSalary`, `tblWorkoutPlans`, etc.).
* **Stored Procedures:** 100% of data operations are managed through robust, parameterized SQL Server Stored Procedures (`Master_StoreProcedures.sql`) to prevent SQL Injection and optimize execution plans.
* **Documentation:** Full entity-relationship schema specifications and dictionary can be viewed at [`Documentation/DatabaseSchema.md`](Documentation/DatabaseSchema.md).

---

## 💻 Technology Stack

| Layer | Technology | Details |
| :--- | :--- | :--- |
| **Language** | C# | Object-Oriented Programming (OOP) principles |
| **Framework** | .NET Framework 4.8 | Windows desktop application runtime |
| **UI Framework** | Windows Forms (WinForms) | Custom-styled layouts, dialogs, and responsive UI |
| **Architecture** | 3-Tier Layered Architecture | Presentation Layer, Business Logic Layer, Data Access Layer |
| **Database** | Microsoft SQL Server | Relational DB, Constraints, Stored Procedures, Transactions |
| **Data Access** | ADO.NET (`System.Data.SqlClient`) | Parameterized commands, connection pooling, and SqlHelper |
| **Visualizations** | MS Chart Controls | `System.Windows.Forms.DataVisualization` |
| **Document Export** | Microsoft Office Interop | Excel (`Microsoft.Office.Interop.Excel`) & Word Interop |

---

## 📁 Project Directory Structure

```text
GymManagementSystem-DesktopApp/
│
├── Database/
│   ├── InitialQueries/            # Incremental table creation, test queries & seed data
│   │   ├── CREATE_TABLE/
│   │   ├── Initial_DB/
│   │   ├── INSERT_DATA/
│   │   ├── SP_Testing/
│   │   └── Store_Procedures/
│   └── MasterDB/
│       ├── Master_CREATE_TABLE.sql       # Master schema definition script
│       └── Master_StoreProcedures.sql    # Complete collection of stored procedures
│
├── Documentation/
│   └── DatabaseSchema.md          # Comprehensive data dictionary & table schema docs
│
├── UserInterface/
│   └── GymManagementSystem/
│       ├── GymManagementSystem.sln       # Visual Studio Solution File
│       ├── GymManagementSystem/          # Presentation Layer (WinForms UI)
│       │   ├── Authentication/           # Login, Registration & Auth forms
│       │   ├── Common/                   # UI Helpers, Lookups & Field Validations
│       │   ├── FORMS/                    # Feature Modules (Member, Attendance, Workout, etc.)
│       │   ├── FormsSuperAdmin/          # Super Admin exclusive modules (Payroll, Financials)
│       │   ├── App.config                # Database connection string configuration
│       │   └── Program.cs                # Application bootstrap entry point
│       │
│       ├── GymManagementSystemBLLayer/   # Business Logic Layer (BLL)
│       │   └── ModulesBLLayer/           # Domain workflows, business rules & validations
│       │
│       ├── GymManagementSystemDALayer/   # Data Access Layer (DAL)
│       │   ├── ModulesDALayer/           # ADO.NET CRUD operations
│       │   └── SqlHelper/                # Database connection factory & command dispatchers
│       │
│       └── packages/                     # NuGet packages (Interop references)
│
└── README.md                      # Project documentation
```

---

## ⚙️ Installation & Getting Started

### Prerequisites

Ensure you have the following installed on your machine:
* **Operating System:** Windows 10 / 11 or Windows Server
* **IDE:** [Visual Studio 2019 or Visual Studio 2022](https://visualstudio.microsoft.com/) (with *.NET desktop development* workload enabled)
* **SDK:** [.NET Framework 4.8 Developer Pack](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48)
* **Database:** [Microsoft SQL Server 2016+](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
* **Database Management Tool:** [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)

---

### 1. Database Setup

1. Open **SQL Server Management Studio (SSMS)** and connect to your local SQL Server instance.
2. Create a new database named `dbGymManagementSystem`:
   ```sql
   CREATE DATABASE dbGymManagementSystem;
   GO
   ```
3. Open and execute the master table script:
   * File: `Database/MasterDB/Master_CREATE_TABLE.sql`
4. Open and execute the stored procedures script:
   * File: `Database/MasterDB/Master_StoreProcedures.sql`
5. Verify that all tables, foreign keys, and stored procedures have been created successfully.

---

### 2. Connection String Configuration

1. Navigate to:
   ```text
   UserInterface/GymManagementSystem/GymManagementSystem/App.config
   ```
2. Update the `DBCS` connection string to point to your SQL Server instance:
   ```xml
   <connectionStrings>
     <add name="DBCS" 
          connectionString="data source=.\SQLEXPRESS;database=dbGymManagementSystem;integrated security=SSPI" 
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```
   *(Replace `.\SQLEXPRESS` with your SQL Server server name if using a standard named instance or SQL Server Authentication credentials).*

---

### 3. Build and Run

1. Open `UserInterface/GymManagementSystem/GymManagementSystem.sln` in **Visual Studio**.
2. Right-click the Solution and select **Restore NuGet Packages**.
3. Set the build configuration to `Debug` or `Release` and architecture to `x86` / `Any CPU`.
4. Right-click the `GymManagementSystem` project and select **Set as Startup Project**.
5. Press `F5` or click **Start** to build and launch the application.
6. On initial startup, register the **Super Admin** account via `FrmSuperAdminRegistration` to initialize administrative credentials.

---

## 👥 Team Members

This project was developed through the collaborative effort of our dedicated team:

| Name | Role | Responsibilities |
| :--- | :--- | :--- |
| **Soumadip Chatterjee** | 👑 **Project Manager** | Architecture Design, Project Coordination, Database Modeling & Integration |
| **Priya Chowdhury** | 💻 **Team Member** | Business Logic Implementation, UI/UX Forms & Workflows |
| **Santanu Khaskel** | 💻 **Team Member** | Database Stored Procedures, Data Access Layer & Testing |
| **Deepjyoti Das** | 💻 **Team Member** | Member Management, Profile Processing & Image Cropping |
| **Arindam Sahoo** | 💻 **Team Member** | Shift Scheduling, Attendance Tracking & Locker Allocation |
| **Angshu Dagun** | 💻 **Team Member** | Workout/Diet Module, Reporting & Document Interop Exports |

---

## 🔮 Future Roadmap

- [ ] **Biometric & RFID Integration:** Integration with fingerprint readers and RFID cards for automated member check-in.
- [ ] **SMS & Email Alerts:** Automated notifications for subscription expiry, workout reminders, and receipts via Twilio / SendGrid.
- [ ] **Online Payment Gateway:** QR code and card payment gateway integration (Stripe / Razorpay).
- [ ] **Mobile Companion App:** Cross-platform mobile portal (MAUI / Flutter) for members to track workout progress and diet plans.
- [ ] **Cloud Database Synchronization:** Support for Azure SQL Database deployment for multi-branch gym chains.

---

## 🤝 Contributing

Contributions make the open-source community an incredible place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

---

## 📄 License

Distributed under the **MIT License**. See `LICENSE` for more information.

