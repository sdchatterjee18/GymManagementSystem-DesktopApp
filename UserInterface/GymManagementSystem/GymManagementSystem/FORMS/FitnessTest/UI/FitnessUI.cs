using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystem.FORMS.Gender;
using GymManagementSystemBLLayer.ModulesBLLayer.FitnessTest;

namespace GymManagementSystem.FORMS.FitnessTest.UI
{
    public class FitnessUI
    {
        public string GenderName { set; get; }
        public decimal Hight { set; get; }
        public decimal Wight { set; get; }
        public int Age { set; get; }
        public string Activity { set; get; }
        public string Goal { set; get; }


        // =========================================================
        // Gender
        // =========================================================

        public DataTable Gender()
        {
            return GenderUI.GetGenderDetailsForComboBox();
        }


        // =========================================================
        // Activity
        // =========================================================

        public static DataTable GetActivityDetailsUI()
        {
            return FitnessTestBLL.GetActivityDetailsBLL();
        }


        // =========================================================
        // Goal
        // =========================================================

        public static DataTable GetGoalDetailsUI()
        {
            return FitnessTestBLL.GetGoalDetailsBLL();
        }
        // =========================================================
        // Get FitnessTestBLL Object
        // =========================================================

        private FitnessTestBLL GetFitnessTestBLL()
        {
            FitnessTestBLL fitnessTestBLL =
                new FitnessTestBLL();

            fitnessTestBLL.GenderName = GenderName;
            fitnessTestBLL.Hight = Hight;
            fitnessTestBLL.Wight = Wight;
            fitnessTestBLL.Age = Age;
            fitnessTestBLL.Activity = Activity;
            fitnessTestBLL.Goal = Goal;

            return fitnessTestBLL;
        }


        // =========================================================
        // Validation
        // =========================================================

        public string ValidateFitnessTestUI()
        {
            FitnessTestBLL fitnessTestBLL =
                GetFitnessTestBLL();

            return fitnessTestBLL.ValidateFitnessTestBLL();
        }


        // =========================================================
        // BMI Calculation
        // =========================================================

        public decimal CalculateBMIUI()
        {
            FitnessTestBLL fitnessTestBLL =
                GetFitnessTestBLL();

            return fitnessTestBLL.CalculateBMIBLL();
        }


        // =========================================================
        // BMR Calculation
        // =========================================================

        public decimal CalculateBMRUI()
        {
            FitnessTestBLL fitnessTestBLL =
                GetFitnessTestBLL();

            return fitnessTestBLL.CalculateBMRBLL();
        }


        // =========================================================
        // IBW Calculation
        // =========================================================

        public decimal CalculateIBWUI()
        {
            FitnessTestBLL fitnessTestBLL =
                GetFitnessTestBLL();

            return fitnessTestBLL.CalculateIBWBLL();
        }


        // =========================================================
        // TDEE Calculation
        // =========================================================

        public decimal CalculateTDEEUI()
        {
            FitnessTestBLL fitnessTestBLL =
                GetFitnessTestBLL();

            return fitnessTestBLL.CalculateTDEEBLL();
        }


        // =========================================================
        // Goal Based Calorie Calculation
        // =========================================================

        public decimal CalculateGoalCaloriesUI()
        {
            FitnessTestBLL fitnessTestBLL =
                GetFitnessTestBLL();

            return fitnessTestBLL.CalculateGoalCaloriesBLL();
        }

    }
}