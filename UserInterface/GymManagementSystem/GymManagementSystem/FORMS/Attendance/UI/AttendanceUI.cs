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

        public DataTable SearchMembersByPhoneNoAndNameUI(string phoneNo)
        {
            DataTable AbsentMemberOnCurrentShift = null;
            try
            {
                PhoneNo = phoneNo;
                AttendanceBLL AttendanceBLL = new AttendanceBLL();
                AbsentMemberOnCurrentShift = AttendanceBLL.SearchMembersByPhoneNoAndNameBLL(PhoneNo);
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
        // Retrieve All Member Details With Shift
        public DataTable RetrieveAllMemberDetailsWithShiftUI()
        {
            DataTable AllMemberDetails = null;

            try
            {
                AttendanceBLL AttendanceBLL = new AttendanceBLL();

                AllMemberDetails =
                    AttendanceBLL.RetrieveAllMemberDetailsWithShiftBLL();

                return AllMemberDetails;
            }
            catch (Exception ex)
            {
                return AllMemberDetails;
            }
        }
        public DataTable SearchMemberDetailsWithShiftUI(string search)
        {
            DataTable MemberDetails = null;

            try
            {
                AttendanceBLL AttendanceBLL = new AttendanceBLL();

                MemberDetails =
                    AttendanceBLL.SearchMemberDetailsWithShiftBLL(search);

                return MemberDetails;
            }
            catch (Exception ex)
            {
                return MemberDetails;
            }
        }
        public DataTable RetrieveMemberAttendanceByDateRangeUI(int memberId,DateTime fromDate,DateTime toDate)
        {
            DataTable AttendanceDetails = null;

            try
            {
                AttendanceBLL AttendanceBLL = new AttendanceBLL();

                AttendanceDetails =
                    AttendanceBLL.RetrieveMemberAttendanceByDateRangeBLL(
                        memberId,
                        fromDate,
                        toDate
                    );

                return AttendanceDetails;
            }
            catch (Exception ex)
            {
                return AttendanceDetails;
            }
        }
        public DataTable RetrieveMemberTotalAttendanceByDateRangeUI(int memberId,DateTime fromDate,DateTime toDate)
        {
            DataTable TotalAttendanceData = null;

            try
            {
                AttendanceBLL AttendanceBLL = new AttendanceBLL();

                TotalAttendanceData =
                    AttendanceBLL.RetrieveMemberTotalAttendanceByDateRangeBLL(
                        memberId,
                        fromDate,
                        toDate
                    );

                return TotalAttendanceData;
            }
            catch (Exception ex)
            {
                return TotalAttendanceData;
            }
        }
        public DataTable RetrieveMemberAttendanceTillTodayUI(int memberId)
        {
            DataTable AttendanceData = null;

            try
            {
                AttendanceBLL AttendanceBLL =
                    new AttendanceBLL();

                AttendanceData =
                    AttendanceBLL.RetrieveMemberAttendanceTillTodayBLL(
                        memberId
                    );

                return AttendanceData;
            }
            catch (Exception ex)
            {
                return AttendanceData;
            }
        }
    }
}
