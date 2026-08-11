using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemDALayer.Common;
using System.Data.SqlClient;

namespace GymManagementSystemDALayer.ModulesDALayer.Locker
{
    public class LockerDAL
    {
        // Properties
        public string LockerNo { get; set; }
        public string MemberName { get; set; }
        public string Status { get; set; }

        // Retrieves all Locker details for display.
        public DataTable RetrieveLockersDAL()
        {
            DataTable dataTable = LookupDAL.RetrieveSpecificItem("spGetLockerDetails");
            return dataTable;
        }

        // Adding New Locker
        public string AddNewLockerDAL(string lockerNo)
        {
            try
            {
                SqlParameter[] sqlParameter =
                    {
                        new SqlParameter("@LockerNo", lockerNo),
                    };

                return LookupDAL.InsertSpecificItem("spInsertDataIntoLockerTable", sqlParameter);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
