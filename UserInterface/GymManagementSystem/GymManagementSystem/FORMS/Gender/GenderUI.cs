using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymManagementSystemBLLayer.ModulesBLLayer.Gender;
using System.Data;

namespace GymManagementSystem.FORMS.Gender
{
    public class GenderUI
    {
        public static DataTable GetGenderDetailsForComboBox()
        {
            DataTable dataTable = GenderBLL.GetGenderDetailsForComboBox();
            return dataTable;
        }
    }
}
