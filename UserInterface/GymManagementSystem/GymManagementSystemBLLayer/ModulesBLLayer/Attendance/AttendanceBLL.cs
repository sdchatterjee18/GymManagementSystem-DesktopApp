using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemDALayer.ModulesDALayer.Attendance;

namespace GymManagementSystemBLLayer.ModulesBLLayer.Attendance
{
    public class AttendanceBLL
    {
        public int ShiftId { get; set; }
        public int MemberId { get; set; }
        public string PhoneNo { get; set; }
        public int MonthNo { get; set; }
        public int Year { get; set; }

        public DataTable RetrieveShiftBLL()
        {
            DataTable ShiftData = null;
            try
            {
                AttendanceDAL AttendanceDAL = new AttendanceDAL();
                ShiftData = AttendanceDAL.RetrieveShiftDAL();
                return ShiftData;
            }
            catch (Exception ex)
            {
                return ShiftData;
            }
        }

        public DataTable RetrieveCurrentShiftDataBLL()
        {
            DataTable CurrentShiftData = null;
            try
            {
                AttendanceDAL AttendanceDAL = new AttendanceDAL();
                CurrentShiftData = AttendanceDAL.RetrieveCurrentShiftDataDAL();
                return CurrentShiftData;
            }
            catch (Exception ex)
            {
                return CurrentShiftData;
            }
        }

        public DataTable RetrieveShiftWiseMemberAttendanceBLL(int shiftId)
        {
            ShiftId = shiftId;
            DataTable ShiftWiseMemberAttendanceData = null;
            try
            {
                AttendanceDAL AttendanceDAL = new AttendanceDAL();
                ShiftWiseMemberAttendanceData = AttendanceDAL.RetrieveShiftWiseMemberAttendanceDAL(ShiftId);
                return ShiftWiseMemberAttendanceData;
            }
            catch (Exception ex)
            {
                return ShiftWiseMemberAttendanceData;
            }
        }

        public DataTable SearchMembersByPhoneNoAndNameBLL(string phoneNo)
        {
            DataTable AbsentMemberOnCurrentShift = null;
            try
            {
                PhoneNo = phoneNo;
                AttendanceDAL AttendanceDAL = new AttendanceDAL();
                AbsentMemberOnCurrentShift = AttendanceDAL.SearchMembersByPhoneNoAndNameDAL(PhoneNo);
                return AbsentMemberOnCurrentShift;
            }
            catch (Exception ex)
            {
                return AbsentMemberOnCurrentShift;
            }
        }


        public string MarkAttendanceBLL(int memberId, int shiftId)
        {
            string AttendanceMessage = null;
            try
            {
                MemberId = memberId;
                ShiftId = shiftId;
                AttendanceDAL AttendanceDAL = new AttendanceDAL();
                AttendanceMessage = AttendanceDAL.MarkAttendanceDAL(MemberId, ShiftId);
                return AttendanceMessage;
            }
            catch (Exception ex)
            {
                return AttendanceMessage;
            }
        }

        //Retrieve Current Month All Present Attendance 
        public DataTable CurrentMonthAllPresentAttendaceBLL()
        {
            DataTable AllAttendence = null;
            try
            {
                AttendanceDAL AttendanceDAL = new AttendanceDAL();
                AllAttendence = AttendanceDAL.CurrentMonthAllPresentAttendaceDAL();
                return AllAttendence;
            }
            catch (Exception ex)
            {
                return AllAttendence;
            }

        }

        //Retrieve Specific Member Attendance Details
        public DataTable RetrieveSpecificMemberAttendanceDetailsBLL(string phoneNo, int monthNo, int year)
        {
            DataTable GetMemberAttendanceDetails = null;
            try
            {
                PhoneNo = phoneNo;
                MonthNo = monthNo;
                Year = year;
                AttendanceDAL AttendanceDAL = new AttendanceDAL();
                GetMemberAttendanceDetails = AttendanceDAL.RetrieveSpecificMemberAttendanceDetailsDAL(PhoneNo, MonthNo, Year);
                return GetMemberAttendanceDetails;
            }
            catch (Exception ex)
            {
                return GetMemberAttendanceDetails;
            }
        }
    }
}
