using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using GymManagementSystemDALayer.Common;

namespace GymManagementSystemDALayer.ModulesDALayer.Member
{
    public class MemberDAL
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public int GenderId { get; set; }
        public string GenderName { get; set; }
        public string PhoneNo { get; set; }
        public string EmailId { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string EmergencyContact { get; set; }
        public byte[] ProfilePhoto { get; set; }
        public DateTime JoiningDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public DataTable RetrieveAllMemberDetailsDAL()
        {
            DataTable dataTable =
                LookupDAL.RetrieveSpecificItem("spRetrieveAllMemberDetails");

            return dataTable;
        }
        public string UpdateMemberContactInfoDAL(int memberId,string phoneNo,string emailId)
        {
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@MemberId", memberId),

                new SqlParameter("@PhoneNo", phoneNo),

                new SqlParameter(
                    "@EmailId",
                    string.IsNullOrWhiteSpace(emailId)
                        ? (object)DBNull.Value
                        : emailId)
            };

            DataTable dataTable =
                LookupDAL.RetrieveSpecificDetails(
                    "spUpdateMemberContactInfo",
                    sqlParameters);

            if (dataTable != null &&
                dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0]["Message"].ToString();
            }

            return null;
        }
        public string DeactivateMemberDAL(int memberId)
        {
            SqlParameter[] sqlParameters =
                {
                    new SqlParameter("@MemberId", memberId)
                };

            DataTable dataTable =
                LookupDAL.RetrieveSpecificDetails(
                    "spDeactivateMember",
                    sqlParameters);

            if (dataTable != null &&
                dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0]["Message"].ToString();
            }

            return null;
        }
        public DataTable RetrieveMembersByPhoneNumberAndNameDAL(string search)
        {
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Search", search)
            };

            DataTable dataTable =
                LookupDAL.RetrieveSpecificDetails(
                    "spRetrieveMembersByPhoneNumberAndName",
                    sqlParameters);

            return dataTable;
        }
    }
}
