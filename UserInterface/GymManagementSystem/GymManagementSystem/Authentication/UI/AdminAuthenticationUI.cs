using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymManagementSystemBLLayer.ModulesBLLayer.Authentication;

namespace GymManagementSystem.Authentication.UI
{
    class AdminAuthenticationUI
    {
        private AdminAuthenticationBLL
            adminAuthenticationBLL =
            new AdminAuthenticationBLL();


        // ==========================================
        // ADMIN LOGIN
        // ==========================================

        public string AdminLoginUI(string userName,string password)
        {
            return adminAuthenticationBLL.AdminLoginBLL(userName,password);
        }
    }
}
