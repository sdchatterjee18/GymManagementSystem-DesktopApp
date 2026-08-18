using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using GymManagementSystemDALayer.Common;

namespace GymManagementSystemDALayer.ModulesDALayer.Authentication
{
    public class AuthenticationDAL
    {
        public int SuperAdminId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }

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
        public string RegisterNewSuperAdminDAL(string userName,string passwordHash,string emailId,string phoneNumber)
        {
            try
            {
                        SqlParameter[] sqlParameters =
                {
                    new SqlParameter("@UserName", userName),
                    new SqlParameter("@PasswordHash", passwordHash),
                    new SqlParameter("@EmailId", emailId),
                    new SqlParameter("@PhoneNumber", phoneNumber)
                };

                object result =LookupDAL.GetSingleData("spRegisterNewSuperAdmin",sqlParameters);

                if (result != null)
                {
                    return result.ToString();
                }

                return "Unable to register Super Admin.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public bool SuperAdminLoginDAL(string userName,string passwordHash)
        {
            try
            {
                SqlParameter[] sqlParameters =
                {
                    new SqlParameter("@UserName", userName),
                    new SqlParameter("@PasswordHash", passwordHash)
                };

                object result =
                    LookupDAL.GetSingleData(
                        "spSuperAdminLogin",
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
        public bool SuperAdminLogoutDAL()
        {
            try
            {
                object result =
                    LookupDAL.GetSingleData(
                        "spSuperAdminLogout",
                        null
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
        public bool ChangeSuperAdminPasswordDAL(string userName, string currentPasswordHash, string newPasswordHash)
        {
            try
            {
                SqlParameter[] sqlParameters =
                {
                    new SqlParameter("@UserName", userName),
                    new SqlParameter("@CurrentPasswordHash", currentPasswordHash),
                    new SqlParameter("@NewPasswordHash", newPasswordHash)
                };

                object result = LookupDAL.GetSingleData(
                    "spChangeSuperAdminPassword",
                    sqlParameters);

                if (result == null || result == DBNull.Value)
                {
                    return false;
                }

                return Convert.ToInt32(result) == 1;
            }
            catch
            {
                return false;
            }
        }
        public bool ChangeAdminPasswordDAL(string userName,string currentPasswordHash,string newPasswordHash)
        {
            try
            {
                SqlParameter[] sqlParameters =
                {
                    new SqlParameter("@UserName", userName),
                    new SqlParameter("@CurrentPasswordHash", currentPasswordHash),
                    new SqlParameter("@NewPasswordHash", newPasswordHash)
                };

                object result =
                    LookupDAL.GetSingleData(
                        "spUpdateAdminPassword",
                        sqlParameters);

                if (result == null ||
                    result == DBNull.Value)
                {
                    return false;
                }

                return Convert.ToInt32(result) == 1;
            }
            catch
            {
                return false;
            }
        }
    }
}
