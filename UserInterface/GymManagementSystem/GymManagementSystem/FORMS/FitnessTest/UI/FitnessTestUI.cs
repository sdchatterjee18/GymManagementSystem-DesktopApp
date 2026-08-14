using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymManagementSystemBLLayer.ModulesBLLayer.FitnessTest;

namespace GymManagementSystem.FORMS.FitnessTest.UI
{
     public class FitnessTestUI
    {
         public static List<string> GetActivityLevels()
         {
             return FitnessTestBLL.GetActivityLevels();
         }
         public static List<string> GetGoalList()
         {
             return FitnessTestBLL.GetGoalList();
         }
    }
}
