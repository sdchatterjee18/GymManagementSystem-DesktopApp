using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymManagementSystemBLLayer.ModulesBLLayer.Authentication;

namespace GymManagementSystem.Authentication.UI
{
   public class AuthenticationUI
    {
        public int SuperAdminId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmedPassword { get; set; }

        private AuthenticationBLL authenticationBLL =new AuthenticationBLL();
        // ==========================================
        // ADMIN LOGIN
        // ==========================================

        public bool AdminLoginUI(string userName,string password)
        {
            return authenticationBLL.AdminLoginBLL(userName, password);
        }

        // ==========================================
        // REGISTER NEW SUPER ADMIN
        // ==========================================

        public string RegisterNewSuperAdminUI(string userName,string password,string emailId,string phoneNumber)
        {
            string result =
                authenticationBLL.RegisterNewSuperAdminBLL(
                    userName,
                    password,
                    emailId,
                    phoneNumber);

            return result;
        }

        // ==========================================
        //  SUPERADMIN LOGIN
        // ==========================================

        public bool SuperAdminLoginUI(string userName,string password)
        {
            return authenticationBLL.SuperAdminLoginBLL(
                userName,
                password);
        }
        // ==========================================
        //  SUPERADMIN LOGOUT
        // ==========================================
        public bool SuperAdminLogoutUI()
        {
            return authenticationBLL.SuperAdminLogoutBLL();
        }


        public string MatchEmailIdFromDatabaseUI()
        {
            AuthenticationBLL authenticationBLL = new AuthenticationBLL();
            authenticationBLL.EmailId = this.EmailId;
            string Message = null;
            try
            {
                Message = authenticationBLL.MatchEmailIdFromDatabaseBLL();
                return Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ChangePasswordByEmailIdUI()
        {
            AuthenticationBLL authenticationBLL = new AuthenticationBLL();
            authenticationBLL.EmailId = this.EmailId;
            string Message = null;
            authenticationBLL.NewPassword = this.NewPassword;
            authenticationBLL.ConfirmedPassword = this.ConfirmedPassword;
                try
                {
                    Message = authenticationBLL.ChangePasswordByEmailIdBLL();
                    return Message;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
        }
    }
}
