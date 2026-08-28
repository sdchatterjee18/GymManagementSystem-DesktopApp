using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.ModulesBLLayer.Member;

namespace GymManagementSystem.FORMS.Member.UI
{
    public class MemberUI
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

        private MemberBLL memberBLL = new MemberBLL();

        public DataTable RetrieveAllMemberDetailsUI()
        {
            DataTable dataTable =
                memberBLL.RetrieveAllMemberDetailsBLL();

            return dataTable;
        }
        public string UpdateMemberContactInfoUI(int memberId,string phoneNo,string emailId)
        {
            return memberBLL.UpdateMemberContactInfoBLL(
                memberId,
                phoneNo,
                emailId);
        }
        public string DeactivateMemberUI(int memberId)
        {
            MemberBLL memberBLL = new MemberBLL();

            return memberBLL.DeactivateMemberBLL(memberId);
        }
        public DataTable RetrieveMembersByPhoneNumberAndNameUI(string search)
        {
            MemberBLL memberBLL = new MemberBLL();

            return memberBLL.RetrieveMembersByPhoneNumberAndNameBLL(search);
        }

    }
}
