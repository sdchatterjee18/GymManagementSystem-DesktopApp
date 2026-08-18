using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymManagementSystemBLLayer.ModulesBLLayer.Authentication;

namespace GymManagementSystem.FORMS.Settings.UI
{
    class AdminChangePasswordUI
    {
        public int AdminId { get; set; }
        public string UserName { get; set; }
        public string CurrentPasswordHash { get; set; }
        public string NewPasswordHash { get; set; }

        private AuthenticationBLL authenticationBLL = new AuthenticationBLL();

        public string ChangeAdminPasswordUI(string userName,string currentPassword,string newPassword)
        {
            return authenticationBLL.ChangeAdminPasswordBLL(
                userName,
                currentPassword,
                newPassword);
        }
    }
}
