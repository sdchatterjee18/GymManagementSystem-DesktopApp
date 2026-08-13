using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymManagementSystem.FormsSuperAdmin.Employee.UI;
using GymManagementSystemBLLayer.ModulesBLLayer.Employee;
using System.Data;

namespace GymManagementSystem.FormsSuperAdmin.Employee.UI
{
    public class EmployeeUI
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int GenderId { get; set; }
        public int RoleId { get; set; }
        public string PhoneNo { get; set; }
        public string EmailId { get; set; }
        public DateTime JoiningDate { get; set; }
        public bool IsActive { get; set; }
        public string BankAccountNo { get; set; }
        public decimal Amount { get; set; }

        public int AdminId { get; set; }
        public int SuperAdminID { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public DateTime LastLogin { get; set; }

        public int TrainerId { get; set; }
        public string TrainerType { get; set; }
        public string Specialization { get; set; }
        public byte[] Document { get; set; }

        public EmployeeUI()
        {
            UserName = null;
            TrainerType = null;
        }

        public DataTable LoadEmployeeRoles()
        {
            EmployeeBLL employeeBLL = new EmployeeBLL();

            DataTable dataTable =
                employeeBLL.RetrieveEmployeeRoleTypesBLL();
            return dataTable;
        }
        public List<string> LoadTrainerTypes()
        {
            TrainerBLL trainerBLL = new TrainerBLL();

            return trainerBLL.GetTrainerTypesBLL();
        }

       
        public string InsertEmployeeUI()
        {
            try
            {
                // =========================
                // Trainer - RoleId = 1
                // =========================
                if (RoleId == 1)
                {
                    TrainerBLL trainerBLL = new TrainerBLL();

                    // Employee Information
                    trainerBLL.FirstName = FirstName;
                    trainerBLL.MiddleName = MiddleName;
                    trainerBLL.LastName = LastName;
                    trainerBLL.GenderId = GenderId;
                    trainerBLL.RoleId = RoleId;
                    trainerBLL.PhoneNo = PhoneNo;
                    trainerBLL.EmailId = EmailId;
                    trainerBLL.BankAccountNo = BankAccountNo;
                    trainerBLL.Amount = Amount;

                    // Trainer Information
                    trainerBLL.TrainerId = TrainerId;
                    trainerBLL.TrainerType = TrainerType;
                    trainerBLL.Specialization = Specialization;
                    trainerBLL.Document = Document;

                    return trainerBLL.InsertTrainerBLL();
                }

                // =========================
                // Admin - RoleId = 2
                // =========================
                else if (RoleId == 2)
                {
                    AdminBLL adminBLL = new AdminBLL();

                    // Employee Information
                    adminBLL.FirstName = FirstName;
                    adminBLL.MiddleName = MiddleName;
                    adminBLL.LastName = LastName;
                    adminBLL.GenderId = GenderId;
                    adminBLL.RoleId = RoleId;
                    adminBLL.PhoneNo = PhoneNo;
                    adminBLL.EmailId = EmailId;
                    adminBLL.BankAccountNo = BankAccountNo;
                    adminBLL.Amount = Amount;

                    // Admin Information
                    adminBLL.AdminId = AdminId;
                    adminBLL.SuperAdminID = SuperAdminID;
                    adminBLL.UserName = UserName;
                    adminBLL.PasswordHash = PasswordHash;
                    adminBLL.LastLogin = LastLogin;

                    return adminBLL.InsertAdminBLL();
                }

                // =========================
                // Staff - RoleId = 3
                // =========================
                else if (RoleId == 3)
                {
                    EmployeeBLL employeeBLL = new EmployeeBLL();

                    employeeBLL.FirstName = FirstName;
                    employeeBLL.MiddleName = MiddleName;
                    employeeBLL.LastName = LastName;
                    employeeBLL.GenderId = GenderId;
                    employeeBLL.RoleId = RoleId;
                    employeeBLL.PhoneNo = PhoneNo;
                    employeeBLL.EmailId = EmailId;
                    employeeBLL.BankAccountNo = BankAccountNo;
                    employeeBLL.Amount = Amount;

                    return employeeBLL.InsertEmployeeBLL();
                }

                return "Invalid Employee Role.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        }
    }

