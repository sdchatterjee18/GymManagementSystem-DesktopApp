using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace GymManagementSystemBLLayer.ModulesBLLayer.FitnessTest
{
    public class FitnessTestBLL
    {
        public string GenderName { set; get; }
        public decimal Hight { set; get; }
        public decimal Wight { set; get; }
        public int Age { set; get; }
        public string Activity { set; get; }
        public string Goal { set; get; }


        // =========================================================
        // Get Activity Details
        // =========================================================

        public static DataTable GetActivityDetailsBLL()
        {
            DataTable dataTable = new DataTable();
            
            dataTable.Columns.Add("Activity");

            dataTable.Rows.Add(
                "Basal Metabolic Rate (BMR)");
            dataTable.Rows.Add(
                "Sedentary");

            dataTable.Rows.Add(
                "Light");

            dataTable.Rows.Add(
                "Moderate");

            dataTable.Rows.Add(
                "Active");

            dataTable.Rows.Add(
                "Very Active");

            dataTable.Rows.Add(
                "Extra Active");

            return dataTable;
        }


        // =========================================================
        // Get Goal Details
        // =========================================================

        public static DataTable GetGoalDetailsBLL()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Goal");

            dataTable.Rows.Add("Weight Loss");
            dataTable.Rows.Add("Weight Gain");
            dataTable.Rows.Add("Muscle Gain");
            dataTable.Rows.Add("Fat Loss");
            dataTable.Rows.Add("Maintain Weight");
            dataTable.Rows.Add("Improve Fitness");
            dataTable.Rows.Add("Improve Endurance");

            return dataTable;
        }


        // =========================================================
        // Validation
        // =========================================================

        public string ValidateFitnessTestBLL()
        {
            // Height
            if (Hight <= 0)
                return "Height must be greater than 0.";

            if (Hight < 50 || Hight > 250)
                return "Height must be between 50 cm and 250 cm.";


            // Weight
            if (Wight <= 0)
                return "Weight must be greater than 0.";

            if (Wight < 10 || Wight > 300)
                return "Weight must be between 10 kg and 300 kg.";


            // Age
            if (Age <= 0)
                return "Age must be greater than 0.";

            if (Age < 5 || Age > 100)
                return "Age must be between 5 and 100 years.";


            return "Valid";
        }


        // =========================================================
        // BMI Calculation
        // =========================================================

        public decimal CalculateBMIBLL()
        {
            if (Hight <= 0 || Wight <= 0)
                return 0m;

            decimal heightMeter =
                Hight / 100m;

            decimal bmi =
                Wight /
                (heightMeter * heightMeter);

            return Math.Round(bmi, 2);
        }


        // =========================================================
        // BMR Calculation
        // =========================================================

        public decimal CalculateBMRBLL()
        {
            decimal bmr = 0m;


            // Male
            if (GenderName == "Male")
            {
                bmr =
                    66.1m
                    + (13.75m * Wight)
                    + (5.003m * Hight)
                    - (6.775m * Age);
            }


            // Female
            else if (GenderName == "Female")
            {
                bmr =
                    655.1m
                    + (9.563m * Wight)
                    + (1.850m * Hight)
                    - (4.675m * Age);
            }


            // Others
            else if (GenderName == "Others")
            {
                decimal maleBMR =
                    66.1m
                    + (13.75m * Wight)
                    + (5.003m * Hight)
                    - (6.775m * Age);

                decimal femaleBMR =
                    655.1m
                    + (9.563m * Wight)
                    + (1.850m * Hight)
                    - (4.675m * Age);

                bmr =
                    (maleBMR + femaleBMR) / 2m;
            }


            else
            {
                return 0m;
            }


            return Math.Round(bmr, 2);
        }


        // =========================================================
        // IBW Calculation
        // =========================================================

        public decimal CalculateIBWBLL()
        {
            decimal heightInches =
                Hight / 2.54m;

            decimal inchesOverFiveFeet;


            if (heightInches <= 60m)
            {
                inchesOverFiveFeet = 0m;
            }
            else
            {
                inchesOverFiveFeet =
                    heightInches - 60m;
            }


            decimal ibw = 0m;


            // Male
            if (GenderName == "Male")
            {
                ibw =
                    52m +
                    (1.9m * inchesOverFiveFeet);
            }


            // Female
            else if (GenderName == "Female")
            {
                ibw =
                    49m +
                    (1.7m * inchesOverFiveFeet);
            }


            // Others
            else if (GenderName == "Others")
            {
                decimal maleIBW =
                    52m +
                    (1.9m * inchesOverFiveFeet);

                decimal femaleIBW =
                    49m +
                    (1.7m * inchesOverFiveFeet);

                ibw =
                    (maleIBW + femaleIBW) / 2m;
            }


            else
            {
                return 0m;
            }


            return Math.Round(ibw, 2);
        }


        // =========================================================
        // TDEE Calculation
        // =========================================================

        public decimal CalculateTDEEBLL()
        {
            decimal bmr =
                CalculateBMRBLL();


            if (bmr <= 0m)
            {
                return 0m;
            }


            decimal tdee = 0m;


            // BMR
            if (Activity ==
                "Basal Metabolic Rate (BMR)")
            {
                tdee =
                    bmr * 1.00m;
            }


            // Sedentary
            else if (Activity ==
                "Sedentary")
            {
                tdee =
                    bmr * 1.20m;
            }


            // Light
            else if (Activity ==
                "Light")
            {
                tdee =
                    bmr * 1.375m;
            }


            // Moderate
            else if (Activity ==
                "Moderate")
            {
                tdee =
                    bmr * 1.55m;
            }


            // Active
            else if (Activity ==
                "Active")
            {
                tdee =
                    bmr * 1.65m;
            }


            // Very Active
            else if (Activity ==
                "Very Active")
            {
                tdee =
                    bmr * 1.725m;
            }


            // Extra Active
            else if (Activity ==
                "Extra Active")
            {
                tdee =
                    bmr * 1.90m;
            }


            else
            {
                return 0m;
            }


            return Math.Round(tdee, 2);
        }


        // =========================================================
        // Goal Based Calorie Calculation
        // =========================================================

        public decimal CalculateGoalCaloriesBLL()
        {
            decimal tdee =
                CalculateTDEEBLL();


            if (tdee <= 0m)
            {
                return 0m;
            }


            decimal calories = 0m;


            // Weight Loss
            if (Goal == "Weight Loss")
            {
                calories =
                    tdee - 500m;
            }


            // Weight Gain
            else if (Goal == "Weight Gain")
            {
                calories =
                    tdee + 300m;
            }


            // Muscle Gain
            else if (Goal == "Muscle Gain")
            {
                calories =
                    tdee + 300m;
            }


            // Fat Loss
            else if (Goal == "Fat Loss")
            {
                calories =
                    tdee - 500m;
            }


            // Maintain Weight
            else if (Goal == "Maintain Weight")
            {
                calories =
                    tdee;
            }


            // Improve Fitness
            else if (Goal == "Improve Fitness")
            {
                calories =
                    tdee;
            }


            // Improve Endurance
            else if (Goal == "Improve Endurance")
            {
                calories =
                    tdee + 200m;
            }


            else
            {
                return 0m;
            }


            return Math.Round(calories, 2);
        }

    }
}