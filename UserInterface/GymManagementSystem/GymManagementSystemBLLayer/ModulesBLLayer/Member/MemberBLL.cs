using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemDALayer.ModulesDALayer.Member;
using GymManagementSystemBLLayer.Common;


namespace GymManagementSystemBLLayer.ModulesBLLayer.Member
{
   public class MemberBLL
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

        // Retrieve all member details

        public DataTable RetrieveAllMemberDetailsBLL()
        {
            MemberDAL memberDAL = new MemberDAL();
            DataTable dataTable =
                memberDAL.RetrieveAllMemberDetailsDAL();
            return dataTable;
        }
        public string UpdateMemberContactInfoBLL(int memberId,string phoneNo,string emailId)
        {
            MemberDAL memberDAL = new MemberDAL();

            return memberDAL.UpdateMemberContactInfoDAL(
                memberId,
                phoneNo,
                emailId);
        }
        public string DeactivateMemberBLL(int memberId)
        {
            MemberDAL memberDAL = new MemberDAL();

            return memberDAL.DeactivateMemberDAL(memberId);
        }
        public DataTable RetrieveMembersByPhoneNumberAndNameBLL(string search)
        {
            MemberDAL memberDAL = new MemberDAL();

            return memberDAL.RetrieveMembersByPhoneNumberAndNameDAL(search);
        }
    }
}
