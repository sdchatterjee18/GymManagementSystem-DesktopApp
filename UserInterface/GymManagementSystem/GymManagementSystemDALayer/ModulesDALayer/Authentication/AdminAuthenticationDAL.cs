using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using GymManagementSystemDALayer.Common;

namespace GymManagementSystemDALayer.ModulesDALayer.Authentication
{
    public class AdminAuthenticationDAL
    {
        public bool AdminLoginDAL(string userName, string passwordHash)
        {
            try
            {
                SqlParameter[] sqlParameters =
                {
                    new SqlParameter("@UserName", userName),
                    new SqlParameter("@PasswordHash", passwordHash)
                };

                object result = LookupDAL.GetSingleData(
                    "spAdminLogin",
                    sqlParameters
                );

                if (result != null)
                {
                    return Convert.ToInt32(result) == 1;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
