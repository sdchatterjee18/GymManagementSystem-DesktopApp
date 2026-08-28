using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymManagementSystemBLLayer.ModulesBLLayer.Authentication;


namespace GymManagementSystem.FormsSuperAdmin.Settings.UI
{
    public class SuperAdminChangePasswordUI
    {
        public int SuperAdminId { get; set; }
        public string UserName { get; set; }
        public string CurrentPasswordHash { get; set; }
        public string NewPasswordHash { get; set; }

        private AuthenticationBLL authenticationBLL = new AuthenticationBLL();
        // ==========================================
        // CHANGE SUPER ADMIN PASSWORD
        // ==========================================
        public bool ChangeSuperAdminPasswordUI(string userName,string currentPassword,string newPassword,string confirmPassword,out string message)
        {
            bool result =
                authenticationBLL.ChangeSuperAdminPasswordBLL(
                    userName,
                    currentPassword,
                    newPassword,
                    confirmPassword);

            message = authenticationBLL.Message;

            return result;
        }
    }
}
