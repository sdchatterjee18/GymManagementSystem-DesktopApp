using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymManagementSystemBLLayer.ModulesBLLayer.FitnessTest
{
    public class FitnessTestBLL
    {
        public static List<string> GetActivityLevels()
        {
            List<string> activityLevels = new List<string>();

            activityLevels.Add("Sedentary");
            activityLevels.Add("Lightly Active");
            activityLevels.Add("Moderately Active");
            activityLevels.Add("Very Active");
            activityLevels.Add("Extra Active");

            return activityLevels;
        }
        // =========================
        // Goal List
        // =========================
        public static List<string> GetGoalList()
        {
            List<string> goalList = new List<string>();

            goalList.Add("Weight Loss");
            goalList.Add("Weight Gain");
            goalList.Add("Muscle Gain");
            goalList.Add("Maintain Weight");
            goalList.Add("Improve Fitness");

            return goalList;
        }
    }
}
