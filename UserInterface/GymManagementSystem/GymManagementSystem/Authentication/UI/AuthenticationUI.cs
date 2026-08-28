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
       
    }
}
