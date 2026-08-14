using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.ModulesBLLayer.Salary;

namespace GymManagementSystem.FormsSuperAdmin.Salary.UI
{
    public class SalaryUI
    {
        // Employee Salary Details
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string PhoneNo { get; set; }
        public int SalaryId { get; set; }
        public decimal Salary { get; set; }
        public int IsPaid { get; set; }

        // Salary Payment
        public string PaymentMode { get; set; }

        private SalaryBLL salaryBLL;
        // Constructor
        public SalaryUI()
        {
            salaryBLL = new SalaryBLL();
        }

        public DataTable GetEmployeeSalaryDetailsUI()
        {
            return salaryBLL.GetEmployeeSalaryDetailsBLL();
        }


        // Pay salary
        public string PaySalaryUI(int employeeId,string paymentMode)
        {
            return salaryBLL.PaySalaryBLL(employeeId,paymentMode);
        }
        // Payment Modes
        public List<string> GetPaymentMethodsUI()
        {
            return salaryBLL.GetPaymentMethodsBLL();
        }
        // Search salary details
        public DataTable RetrieveEmployeeSalaryDetailsByPhoneNumberAndNameUI(string search)
        {
            return salaryBLL
                .RetrieveEmployeeSalaryDetailsByPhoneNumberAndNameBLL(search);
        }
    }
}
