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
        public bool Success { get; set; }
        public string Message { get; set; }

        private AuthenticationDAL authenticationDAL = new AuthenticationDAL();
        public bool AdminLoginBLL(string userName, string password)
        {

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
            return loginResult;
         
        }
        public string RegisterNewSuperAdminBLL(string userName,string password,string emailId,string phoneNumber)
        {
            ValidationBll.CommonValidationMessage result;

            // ==========================================
            // USERNAME VALIDATION
            // ==========================================
            result = ValidationBll.ValidateUserName(userName);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                Message = ValidationBll.GetValidationMessage(result);
                return Message;
            }

            // ==========================================
            // PASSWORD VALIDATION
            // ==========================================
            result = ValidationBll.ValidatePassword(password);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                Message = ValidationBll.GetValidationMessage(result);
                return Message;
            }

            // ==========================================
            // EMAIL VALIDATION
            // ==========================================
            result = ValidationBll.ValidateEmail(emailId);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                Message = ValidationBll.GetValidationMessage(result);
                return Message;
            }

            // ==========================================
            // PHONE NUMBER VALIDATION
            // ==========================================
            result = ValidationBll.ValidatePhoneNumber(phoneNumber);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                Message = ValidationBll.GetValidationMessage(result);
                return Message;
            }

            // ==========================================
            // HASH PASSWORD
            // ==========================================
            string passwordHash =
                PasswordHelperBLL.HashPassword(password);

            // ==========================================
            // BLL → DAL
            // ==========================================
            string registerResult =
                authenticationDAL.RegisterNewSuperAdminDAL(
                    userName,
                    passwordHash,
                    emailId,
                    phoneNumber);

            // ==========================================
            // REGISTRATION RESULT
            // ==========================================
            Message = registerResult;

            return registerResult;
        }
        public bool SuperAdminLoginBLL(string userName, string password)
        {
            // ==========================================
            // HASH PASSWORD
            // ==========================================

            string passwordHash = PasswordHelperBLL.HashPassword(password);
            return authenticationDAL.SuperAdminLoginDAL(userName, passwordHash);
        }
        public bool SuperAdminLogoutBLL()
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
                Message = "Logout Successful.";
                return true;
            }

            Message = "Logout Failed.";
            return false;
        }
        public bool ChangeSuperAdminPasswordBLL(string userName,string currentPassword,string newPassword,string confirmPassword)
        {
            ValidationBll.CommonValidationMessage result;

            // USERNAME VALIDATION
            result = ValidationBll.ValidateUserName(userName);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                Message = ValidationBll.GetValidationMessage(result);
                return false;
            }

            // CURRENT PASSWORD VALIDATION
            result = ValidationBll.ValidatePassword(currentPassword);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                Message = ValidationBll.GetValidationMessage(result);
                return false;
            }

            // NEW PASSWORD VALIDATION
            result = ValidationBll.ValidatePassword(newPassword);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                Message = ValidationBll.GetValidationMessage(result);
                return false;
            }

            // CURRENT AND NEW PASSWORD MUST BE DIFFERENT
            if (currentPassword == newPassword)
            {
                Message = "Current Password and New Password cannot be the same.";
                return false;
            }

            // NEW PASSWORD AND CONFIRM PASSWORD MUST MATCH
            if (newPassword != confirmPassword)
            {
                Message = "New Password and Confirm Password do not match.";
                return false;
            }

            // HASH CURRENT PASSWORD
            string currentPasswordHash =
                PasswordHelperBLL.HashPassword(currentPassword);

            // HASH NEW PASSWORD
            string newPasswordHash =
                PasswordHelperBLL.HashPassword(newPassword);

            // BLL → DAL
            bool changePasswordResult =
                authenticationDAL.ChangeSuperAdminPasswordDAL(
                    userName,
                    currentPasswordHash,
                    newPasswordHash);

            if (changePasswordResult)
            {
                Message = "Password Changed Successfully.";
                return true;
            }

            Message = "Password Change Failed.";
            return false;
        }
        public bool ChangeAdminPasswordBLL(string userName,string currentPassword,string newPassword,string confirmPassword)
        {
            ValidationBll.CommonValidationMessage result;

            // ==========================================
            // USERNAME VALIDATION
            // ==========================================

            result = ValidationBll.ValidateUserName(userName);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                Message = ValidationBll.GetValidationMessage(result);
                return false;
            }

            // ==========================================
            // CURRENT PASSWORD VALIDATION
            // ==========================================

            result = ValidationBll.ValidatePassword(currentPassword);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                Message = ValidationBll.GetValidationMessage(result);
                return false;
            }

            // ==========================================
            // NEW PASSWORD VALIDATION
            // ==========================================

            result = ValidationBll.ValidatePassword(newPassword);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                Message = ValidationBll.GetValidationMessage(result);
                return false;
            }

            // ==========================================
            // CURRENT & NEW PASSWORD MUST BE DIFFERENT
            // ==========================================

            if (currentPassword == newPassword)
            {
                Message = "Current Password and New Password cannot be the same.";
                return false;
            }

            // ==========================================
            // NEW PASSWORD & CONFIRM PASSWORD MUST MATCH
            // ==========================================

            if (newPassword != confirmPassword)
            {
                Message = "New Password and Confirm Password do not match.";
                return false;
            }

            // ==========================================
            // HASH CURRENT PASSWORD
            // ==========================================

            string currentPasswordHash =
                PasswordHelperBLL.HashPassword(currentPassword);

            // ==========================================
            // HASH NEW PASSWORD
            // ==========================================

            string newPasswordHash =
                PasswordHelperBLL.HashPassword(newPassword);

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
                Message = "Password Changed Successfully.";
                return true;
            }

            Message = "Password Change Failed.";
            return false;
        }
    }

}
