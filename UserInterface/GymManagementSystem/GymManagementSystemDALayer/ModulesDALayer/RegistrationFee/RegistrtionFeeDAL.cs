using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using GymManagementSystemDALayer.Common;

namespace GymManagementSystemDALayer.ModulesDALayer.RegistrationFee
{
    public class RegistrtionFeeDAL
    {

        // Data property
        public int RegistrationFeesId { get; set; }
        public decimal FeeAmount { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public DataTable RetriveAllRegistrationFeesDAL()
        {
            DataTable dataTable = LookupDAL.RetrieveSpecificItem("spGetAllRegistrationFees");
            return dataTable;
        }

        public string InsertRegistrationFeeDAL()
        {
            SqlParameter[] sqlParameter =
            {
                new SqlParameter("@FeeAmount", FeeAmount),
                
            };
            return LookupDAL.InsertSpecificItem("spInsertDataIntoRegistrationFeesTable", sqlParameter);
        }

    }
}
