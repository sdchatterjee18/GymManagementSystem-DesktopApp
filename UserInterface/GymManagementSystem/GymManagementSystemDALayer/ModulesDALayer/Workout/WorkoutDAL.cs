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
            SqlParameter[] sqlParameters =
                {
                    new SqlParameter("@ExerciseId", exerciseId)
                };
            DataTable dataTable = LookupDAL.RetrieveSpecificDetails("spRetrieveSpecificExercise",sqlParameters);
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

        // Retrieves all workout plan records.
        public DataTable RetrieveWorkoutPlansDAL()
        {
            DataTable dataTable = LookupDAL.RetrieveSpecificItem("spRetrieveRecordsOfWorkoutPlanTable");
            return dataTable;
        }
        // Retrieves workout plans for ComboBox.
        public DataTable GetWorkoutPlansForComboBox()
        {
            DataTable dataTable = LookupDAL.RetrieveSpecificItem("spRetrieveRecordsOfWorkoutPlanTable");
            return dataTable;
        }
        // Retrieves specific workout plan details.
        public DataTable RetrieveSpecificWorkoutPlanDAL(int workoutPlanId)
        {
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@WorkoutPlanId", workoutPlanId)
            };
            DataTable dataTable = LookupDAL.RetrieveSpecificDetails( "spRetrieveSpecificWorkoutPlan", sqlParameters);
            return dataTable;
        }
        // Insert new workout plan
        public string InsertWorkoutPlanDAL(string workoutName,string description)
        {
            try
            {
                SqlParameter[] sqlParameters =
                {
                    new SqlParameter("@WorkoutName", workoutName),
                    new SqlParameter("@Description", description)
                };
                return LookupDAL.InsertSpecificItem("spInsertDataIntoWorkoutPlanTable", sqlParameters);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Retrieves all Workout Schedule records
        public DataTable RetrieveWorkoutScheduleRecordsDAL()
        {
            DataTable dataTable =
                LookupDAL.RetrieveSpecificItem("spRetrieveRecordsOfWorkoutScheduleTable");
            return dataTable;
        }
        // Retrieves Workout Schedule records by Workout Day
        public DataTable RetrieveWorkoutScheduleByDayDAL(string workoutDay)
        {
            try
            {
                SqlParameter[] sqlParameters =
                    {
                        new SqlParameter("@WorkoutDay", workoutDay)
                    };

                DataTable dataTable =LookupDAL.RetrieveSpecificDetails("spRetrieveWorkoutScheduleRecordsByWorkoutDay",sqlParameters);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Insert workout shedule
        public string InsertWorkoutScheduleDAL(int workoutPlanId,int exerciseId,string workoutDay)
        {
            try
            {
                SqlParameter[] sqlParameters =
                {
                    new SqlParameter("@WorkoutPlanId", workoutPlanId),
                    new SqlParameter("@ExerciseId", exerciseId),
                    new SqlParameter("@WorkoutDay", workoutDay)
                };

                return LookupDAL.InsertSpecificItem(
                    "spInsertDataIntoWorkoutScheduleTable",
                    sqlParameters);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //Delete workoutshedule
        public string RemoveWorkoutScheduleByIdDAL(int workoutScheduleId)
        {
            try
            {
                SqlParameter[] sqlParameters =
                {
                    new SqlParameter("@WorkoutScheduleId", workoutScheduleId)
                };

                return LookupDAL.UpdateSpecificItem(
                    "spRemoveWorkoutScheduleByWorkoutScheduleId",
                    sqlParameters);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
