using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemDALayer.ModulesDALayer.Salary;
using GymManagementSystemBLLayer.Common;

namespace GymManagementSystemBLLayer.ModulesBLLayer.Salary
{
    public class SalaryBLL
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

        private SalaryDAL salaryDAL;

        public SalaryBLL()
        {
            salaryDAL = new SalaryDAL();
        }


        // Retrieve salary details
        public DataTable GetEmployeeSalaryDetailsBLL()
        {
            return salaryDAL.GetEmployeeSalaryDetailsDAL();
        }


        // Pay salary
        public string PaySalaryBLL(int employeeId,string paymentMode)
        {
            return salaryDAL.PaySalaryDAL(employeeId,paymentMode);
        }

        // Payment Modes
        public List<string> GetPaymentMethodsBLL()
        {
            return LookupBLL.GetPaymentMethods();
        }

        // Retrieve employee salary details by name or phone
        public DataTable RetrieveEmployeeSalaryDetailsByPhoneNumberAndNameBLL(string search)
        {
            return salaryDAL
                .RetrieveEmployeeSalaryDetailsByPhoneNumberAndNameDAL(search);
        }
    }
}
