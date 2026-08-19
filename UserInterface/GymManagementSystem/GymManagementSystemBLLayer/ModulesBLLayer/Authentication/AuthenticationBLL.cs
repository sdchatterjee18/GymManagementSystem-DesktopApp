using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymManagementSystemDALayer.ModulesDALayer.Authentication;
using GymManagementSystemBLLayer.Common;

namespace GymManagementSystemBLLayer.ModulesBLLayer.Authentication
{
    public class AuthenticationBLL
    {
        public int SuperAdminId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }

        private AuthenticationDAL authenticationDAL = new AuthenticationDAL();
        public string AdminLoginBLL(string userName, string password)
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

            bool loginResult = authenticationDAL.AdminLoginDAL(userName, passwordHash);


            // ==========================================
            // LOGIN RESULT
            // ==========================================

            if (loginResult)
            {
                return "Login Successful.";
            }

            return "Invalid Username and Password.";
        }
        public string RegisterNewSuperAdminBLL(string userName, string password, string emailId, string phoneNumber)
        {
            ValidationBll.CommonValidationMessage result;

            // ==========================================
            // USERNAME VALIDATION
            // ==========================================
            result = ValidationBll.ValidateUserName(userName);
            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }
            // ==========================================
            // PASSWORD VALIDATION
            // ==========================================
            result = ValidationBll.ValidatePassword(password);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }
            // ==========================================
            // EMAIL VALIDATION
            // ==========================================
            result = ValidationBll.ValidateEmail(emailId);
            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }

            // ==========================================
            // PHONE NUMBER VALIDATION
            // ==========================================

            result = ValidationBll.ValidatePhoneNumber(phoneNumber);
            if (result !=
                ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }

            // ==========================================
            // CONVERT HASH PASSWORD
            // ==========================================

            string passwordHash = PasswordHelperBLL.HashPassword(password);

            // ==========================================
            // BLL → DAL
            // ==========================================

            return authenticationDAL.RegisterNewSuperAdminDAL(userName, passwordHash, emailId, phoneNumber);
        }
        public bool SuperAdminLoginBLL(string userName, string password)
        {
            ValidationBll.CommonValidationMessage result;
            // ==========================================
            // HASH PASSWORD
            // ==========================================

            string passwordHash = PasswordHelperBLL.HashPassword(password);
            return authenticationDAL.SuperAdminLoginDAL(userName, passwordHash);
        }
        public string SuperAdminLogoutBLL()
        {
            // ==========================================
            // BLL → DAL
            // ==========================================

            bool logoutResult =
                authenticationDAL.SuperAdminLogoutDAL();


            // ==========================================
            // LOGOUT RESULT
            // ==========================================

            if (logoutResult)
            {
                return "Logout Successful.";
            }
            else
            {
                return "Logout Failed.";
            }
        }
        public string ChangeSuperAdminPasswordBLL(string userName, string currentPassword, string newPassword)
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
            // CURRENT PASSWORD VALIDATION
            // ==========================================

            result =
                ValidationBll.ValidatePassword(currentPassword);

            if (result !=
                ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }


            // ==========================================
            // NEW PASSWORD VALIDATION
            // ==========================================

            result =
                ValidationBll.ValidatePassword(newPassword);

            if (result !=
                ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }


            // ==========================================
            // HASH CURRENT PASSWORD
            // ==========================================

            string currentPasswordHash =
                PasswordHelperBLL.HashPassword(
                    currentPassword);


            // ==========================================
            // HASH NEW PASSWORD
            // ==========================================

            string newPasswordHash =
                PasswordHelperBLL.HashPassword(
                    newPassword);


            // ==========================================
            // BLL → DAL
            // ==========================================

            bool changePasswordResult =
                authenticationDAL.ChangeSuperAdminPasswordDAL(
                    userName,
                    currentPasswordHash,
                    newPasswordHash);


            // ==========================================
            // RESULT
            // ==========================================

            if (changePasswordResult)
            {
                return "Password Changed Successfully.";
            }

            return "Password Change Failed.";
        }
        public string ChangeAdminPasswordBLL(string userName,string currentPassword,string newPassword)
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
            // CURRENT PASSWORD VALIDATION
            // ==========================================

            result =
                ValidationBll.ValidatePassword(currentPassword);

            if (result !=
                ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }


            // ==========================================
            // NEW PASSWORD VALIDATION
            // ==========================================

            result =
                ValidationBll.ValidatePassword(newPassword);

            if (result !=
                ValidationBll.CommonValidationMessage.Valid)
            {
                return ValidationBll.GetValidationMessage(result);
            }


            // ==========================================
            // HASH CURRENT PASSWORD
            // ==========================================

            string currentPasswordHash =
                PasswordHelperBLL.HashPassword(
                    currentPassword);


            // ==========================================
            // HASH NEW PASSWORD
            // ==========================================

            string newPasswordHash =
                PasswordHelperBLL.HashPassword(
                    newPassword);


            // ==========================================
            // BLL → DAL
            // ==========================================

            bool changeResult =
                authenticationDAL.ChangeAdminPasswordDAL(
                    userName,
                    currentPasswordHash,
                    newPasswordHash);


            // ==========================================
            // RESULT
            // ==========================================

            if (changeResult)
            {
                return "Password Changed Successfully.";
            }

            return "Password Change Failed.";
        }
    }

}
