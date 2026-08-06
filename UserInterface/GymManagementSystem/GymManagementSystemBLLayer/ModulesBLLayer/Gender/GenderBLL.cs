using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemDALayer.ModulesDALayer.Gender;

namespace GymManagementSystemBLLayer.ModulesBLLayer.Gender
{
    public class GenderBLL
    {
        public static DataTable GetGenderDetailsForComboBox()
        {
            DataTable dataTable = GenderDAL.GetGenderDetailsForComboBox();
            return dataTable;
        }
    }
}
