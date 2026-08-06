using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemDALayer.Common;

namespace GymManagementSystemDALayer.ModulesDALayer.Gender
{
    public class GenderDAL
    {
        public static DataTable GetGenderDetailsForComboBox()
        {
            DataTable dataTable = LookupDAL.GetComboBoxDetails("spRetrieveGenderDetails");
            return dataTable;
        }
    }
}
