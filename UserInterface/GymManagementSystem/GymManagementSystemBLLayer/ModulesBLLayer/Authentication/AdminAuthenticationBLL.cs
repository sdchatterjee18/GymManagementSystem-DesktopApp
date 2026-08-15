using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymManagementSystemDALayer.ModulesDALayer.Authentication;
using GymManagementSystemBLLayer.Common;

namespace GymManagementSystemBLLayer.ModulesBLLayer.Authentication
{
    public class AdminAuthenticationBLL
    {
        private AdminAuthenticationDAL
            adminAuthenticationDAL =
            new AdminAuthenticationDAL();


        public string AdminLoginBLL(string userName,string password)
        {
            ValidationBll.CommonValidationMessage result;


            // ==========================================
            // USERNAME VALIDATION
            // ==========================================

            result =
                ValidationBll.ValidateUserName(userName);

            if (result !=
                ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }


            // ==========================================
            // PASSWORD VALIDATION
            // ==========================================

            result =
                ValidationBll.ValidatePassword(password);

            if (result !=
                ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }


            // ==========================================
            // HASH PASSWORD
            // ==========================================

            string passwordHash =
                PasswordHelperBLL.HashPassword(password);


            // ==========================================
            // BLL → DAL
            // ==========================================

            bool loginResult =adminAuthenticationDAL.AdminLoginDAL(userName,passwordHash);


            // ==========================================
            // LOGIN RESULT
            // ==========================================

            if (loginResult)
            {
                return "Login Successful.";
            }

            return "Invalid Username and Password.";
        }
    }

}
