using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using GymManagementSystemDALayer.Common;

namespace GymManagementSystemDALayer.ModulesDALayer.Attendance
{
    public class AttendanceDAL
    {
        //properties
        public int ShiftId { get; set; }
        public int MemberId { get; set; }
        public string PhoneNo { get; set; }
        public int MonthNo { get; set; }
        public int Year { get; set; }
        public string RetrieveShiftSPName { get; set; }
        public string RetrieveCurrentShiftAbsentMemberSPName { get; set; }
        public string RetrieveAbsentMembersOnCurrentDateByShiftSPName { get; set; }
        public string RetrieveAbsentMembersOnCurrentDateCurrentShiftByPhoneNoSPName { get; set; }
        public string MarkAttendanceSPName { get; set; }
        public string RetrieveCurrentMonthAllPresentAttendanceSPName { get; set; }
        public string RetrieveMemberAttendanceByPhoneMonthYearSPName { get; set; }



        public AttendanceDAL()
        {
            RetrieveShiftSPName = "spRetrieveShiftTimeTable";
            RetrieveCurrentShiftAbsentMemberSPName = "spRetrieveAbsentMembersOnCurrentDateCurrentShift";
            RetrieveAbsentMembersOnCurrentDateByShiftSPName = "spRetrieveAbsentMembersOnCurrentDateByShift";
            RetrieveAbsentMembersOnCurrentDateCurrentShiftByPhoneNoSPName = "spRetrieveAbsentMembersOnCurrentDateCurrentShiftByPhoneNo";
            MarkAttendanceSPName = "spMarkMemberAttendance";
            RetrieveCurrentMonthAllPresentAttendanceSPName = "spRetrieveCurrentMonthAllPresentAttendance";
            RetrieveMemberAttendanceByPhoneMonthYearSPName = "spRetrieveMemberAttendanceByPhoneMonthYear";
        }

        //Retrieve Shift data For combobox
        public DataTable RetrieveShiftDAL()
        {
            DataTable ShiftData = null;
            try
            {
                ShiftData = LookupDAL.GetComboBoxDetails(RetrieveShiftSPName);
                return ShiftData;
            }
            catch (Exception ex)
            {
                return ShiftData;
            }
        }

        //Retrieve Current shift Data
        public DataTable RetrieveCurrentShiftDataDAL()
        {
            DataTable CurrentShiftData = null;
            try
            {
                CurrentShiftData = LookupDAL.RetrieveSpecificItem(RetrieveCurrentShiftAbsentMemberSPName);
                return CurrentShiftData;
            }
            catch (Exception ex)
            {
                return CurrentShiftData;
            }
        }

        //Retrieve Shift wise Member Data
        public DataTable RetrieveShiftWiseMemberAttendanceDAL(int shiftId)
        {
            ShiftId = shiftId;
            DataTable ShiftWiseMemberAttendanceData = null;
            try
            {
                SqlParameter[] SqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@ShiftId",ShiftId)
                };
                ShiftWiseMemberAttendanceData = LookupDAL.RetrieveSpecificDetails(RetrieveAbsentMembersOnCurrentDateByShiftSPName, SqlParameters);
                return ShiftWiseMemberAttendanceData;
            }
            catch (Exception ex)
            {
                return ShiftWiseMemberAttendanceData;
            }
        }

        //Retrieve Not Present Member in Current Shift By PhoneNO
        public DataTable RetrieveAbsentMemberOnCurrentShiftByPhoneNoDAL(string phoneNo)
        {
            DataTable AbsentMemberOnCurrentShift = null;
            try
            {
                PhoneNo = phoneNo;
                SqlParameter[] sqlParameter = new SqlParameter[]
                {
                    new SqlParameter("@PhoneNo",PhoneNo)
                };
                AbsentMemberOnCurrentShift = LookupDAL.RetrieveSpecificDetails(RetrieveAbsentMembersOnCurrentDateCurrentShiftByPhoneNoSPName,sqlParameter);
                return AbsentMemberOnCurrentShift;
            }
            catch (Exception ex)
            {
                return AbsentMemberOnCurrentShift;
            }
        }

        //Mark Attendance by MemberId And ShiftId
        public string MarkAttendanceDAL(int memberId, int shiftId)
        {
            string AttendanceMessage = null;
            try
            {
                MemberId = memberId;
                ShiftId = shiftId;
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@MemberId",MemberId),
                    new SqlParameter("@ShiftId",ShiftId)
                };
                AttendanceMessage = LookupDAL.InsertSpecificItem(MarkAttendanceSPName,sqlParameters);
                return AttendanceMessage;
            }
            catch (Exception ex)
            {
                return AttendanceMessage;
            }
        }

        //Retrieve Current Month All Present Attendance 
        public DataTable CurrentMonthAllPresentAttendaceDAL()
        {
            DataTable AllAttendence = null;
            try
            {
                AllAttendence = LookupDAL.RetrieveSpecificItem(RetrieveCurrentMonthAllPresentAttendanceSPName);
                return AllAttendence;
            }
            catch (Exception ex)
            {
                return AllAttendence;
            }

        }

        //Retrieve Specific Member Attendance Details
        public DataTable RetrieveSpecificMemberAttendanceDetailsDAL(string phoneNo,int monthNo,int year)
        {
            DataTable GetMemberAttendanceDetails = null;
            try
            {
                PhoneNo = phoneNo;
                MonthNo = monthNo;
                Year = year;

                SqlParameter[] Parameters = new SqlParameter[]
                {
                    new SqlParameter("@PhoneNo",PhoneNo),
                    new SqlParameter("@MonthNumber",MonthNo),
                    new SqlParameter("@Year",Year)
                };

                GetMemberAttendanceDetails = LookupDAL.RetrieveSpecificDetails(RetrieveMemberAttendanceByPhoneMonthYearSPName,Parameters);
                return GetMemberAttendanceDetails;
            }
            catch (Exception ex)
            {
                return GetMemberAttendanceDetails;
            }
        }

    }
}
