using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymManagementSystem.FORMS.Member.UI
{
    public class MemberUI
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public int GenderId { get; set; }
        public int GenderName { get; set; }
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

    }
}
