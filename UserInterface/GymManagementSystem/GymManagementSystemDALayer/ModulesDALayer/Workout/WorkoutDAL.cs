using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using GymManagementSystemDALayer.Common;

namespace GymManagementSystemDALayer.ModulesDALayer.Workout
{
    public class WorkoutDAL
    {
        // Data Property
        public int WorkoutPlanId { get; set; }
        public string WorkoutName { get; set; }
        public string Description { get; set; }
        public int ExerciseId { get; set; }
        public string ExerciseName { get; set; }
        public string MuscleType { get; set; }
        public int WorkoutScheduleId { get; set; }
        public string WorkoutDay { get; set; }

        // Retrieves all exercise records.
        public DataTable RetrieveExercisesDAL()
        {
            DataTable dataTable =LookupDAL.RetrieveSpecificItem("spRetrieveRecordsOfExercisesTable");
            return dataTable;
        }
        // Retrieves exercise records for ComboBox.
        public DataTable GetExercisesForComboBox()
        {
            DataTable dataTable = LookupDAL.RetrieveSpecificItem("spRetrieveRecordsOfExercisesTable");
            return dataTable;
        }
        // Retrieves specific exercise details by ExerciseId.
        public DataTable RetrieveSpecificExerciseDAL(int exerciseId)
        {
            DataTable dataTable = LookupDAL.RetrieveSpecificDetailsById("spRetrieveSpecificExercise",exerciseId,"@ExerciseId");
            return dataTable;
        }
        // Insert new exercise
        public string InsertExerciseDAL(string exerciseName,string muscleType)
        {
            try
            {
                SqlParameter[] sqlParameters =
                    {
                        new SqlParameter("@ExerciseName",exerciseName),
                        new SqlParameter("@MuscleType",muscleType)
                    };
                return LookupDAL.InsertSpecificItem("spInsertDataIntoExercise",sqlParameters);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
