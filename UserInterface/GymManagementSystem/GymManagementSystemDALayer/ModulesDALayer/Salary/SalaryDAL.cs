using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using GymManagementSystemDALayer.Common;

namespace GymManagementSystemDALayer.ModulesDALayer.Salary
{
    public class SalaryDAL
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

            // Retrieve employee salary details
        public DataTable GetEmployeeSalaryDetailsDAL()
        {
            return LookupDAL.RetrieveSpecificItem(
                "spGetEmployeeSalaryDetailsByCurrentMonth"
            );
        }


        // Pay salary
        public string PaySalaryDAL(int employeeId, string paymentMode)
        {
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@EmployeeId", employeeId),
                new SqlParameter("@PaymentMode", paymentMode)
            };

            return LookupDAL.InsertSpecificItem(
                "spPaySalaryToEmployeeByEmployeeId",
                sqlParameters
            );
        }
        // Retrieve employee salary details by name or phone number
        public DataTable RetrieveEmployeeSalaryDetailsByPhoneNumberAndNameDAL(string search)
        {
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Search", search)
            };

            return LookupDAL.RetrieveSpecificDetails(
                "spRetrieveEmployeeSalaryDetailsByPhoneNumberAndName",
                sqlParameters);
        }
    }
}
