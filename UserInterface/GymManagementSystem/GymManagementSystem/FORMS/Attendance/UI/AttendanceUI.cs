using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.ModulesBLLayer.Attendance;
using GymManagementSystemBLLayer.Common;

namespace GymManagementSystem.FORMS.Attendance.UI
{
    public class AttendanceUI
    {
        public int ShiftId { get; set; }
        public int MemberId { get; set; }
        public string PhoneNo { get; set; }
        public int MonthNo { get; set; }
        public int Year { get; set; }

        public DataTable RetrieveShiftUI()
        {
            DataTable ShiftData = null;
            try
            {
                AttendanceBLL AttendanceBLL = new AttendanceBLL();
                ShiftData = AttendanceBLL.RetrieveShiftBLL();
                return ShiftData;
            }
            catch (Exception ex)
            {
                return ShiftData;
            }
        }

        public DataTable RetrieveCurrentShiftDataUI()
        {
            DataTable CurrentShiftData = null;
            try
            {
                AttendanceBLL AttendanceBLL = new AttendanceBLL();
                CurrentShiftData = AttendanceBLL.RetrieveCurrentShiftDataBLL();
                return CurrentShiftData;
            }
            catch (Exception ex)
            {
                return CurrentShiftData;
            }
        }

        public DataTable RetrieveShiftWiseMemberAttendanceUI(int shiftId)
        {
            ShiftId = shiftId;
            DataTable ShiftWiseMemberAttendanceData = null;
            try
            {
                AttendanceBLL AttendanceBLL = new AttendanceBLL();
                ShiftWiseMemberAttendanceData = AttendanceBLL.RetrieveShiftWiseMemberAttendanceBLL(ShiftId);
                return ShiftWiseMemberAttendanceData;
            }
            catch (Exception ex)
            {
                return ShiftWiseMemberAttendanceData;
            }
        }

        public DataTable RetrieveAbsentMemberOnCurrentShiftByPhoneNoUI(string phoneNo)
        {
            DataTable AbsentMemberOnCurrentShift = null;
            try
            {
                PhoneNo = phoneNo;
                AttendanceBLL AttendanceBLL = new AttendanceBLL();
                AbsentMemberOnCurrentShift = AttendanceBLL.RetrieveAbsentMemberOnCurrentShiftByPhoneNoBLL(PhoneNo);
                return AbsentMemberOnCurrentShift;
            }
            catch (Exception ex)
            {
                return AbsentMemberOnCurrentShift;
            }
        }

        public string MarkAttendanceUI(int memberId, int shiftId)
        {
            string AttendanceMessage = null;
            try
            {
                MemberId = memberId;
                ShiftId = shiftId;
                AttendanceBLL AttendanceBLL = new AttendanceBLL();
                AttendanceMessage = AttendanceBLL.MarkAttendanceBLL(MemberId, ShiftId);
                return AttendanceMessage;
            }
            catch (Exception ex)
            {
                return AttendanceMessage;
            }
        }

        //Retrieve Current Month All Present Attendance 
        public DataTable CurrentMonthAllPresentAttendaceUI()
        {
            DataTable AllAttendence = null;
            try
            {
                AttendanceBLL AttendanceBLL = new AttendanceBLL();
                AllAttendence = AttendanceBLL.CurrentMonthAllPresentAttendaceBLL();
                return AllAttendence;
            }
            catch (Exception ex)
            {
                return AllAttendence;
            }

        }

        //Get Months from Lookup BLL
        public DataTable GetMonthsUI()
        {

            DataTable dataTable = null;
            try
            {
                dataTable = LookupBLL.GetMonths();
                return dataTable;
            }
            catch (Exception ex)
            {
                return dataTable;
            }
        }

        //Retrieve Specific Member Attendance Details
        public DataTable RetrieveSpecificMemberAttendanceDetailsUI(string phoneNo, int monthNo, int year)
        {
            DataTable GetMemberAttendanceDetails = null;
            try
            {
                PhoneNo = phoneNo;
                MonthNo = monthNo;
                Year = year;
                AttendanceBLL AttendanceBLL = new AttendanceBLL();
                GetMemberAttendanceDetails = AttendanceBLL.RetrieveSpecificMemberAttendanceDetailsBLL(PhoneNo, MonthNo, Year);
                return GetMemberAttendanceDetails;
            }
            catch (Exception ex)
            {
                return GetMemberAttendanceDetails;
            }
        }
    }
}
