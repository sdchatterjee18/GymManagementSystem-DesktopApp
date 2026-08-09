using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.Common;
using GymManagementSystemDALayer.ModulesDALayer.Workout;

namespace GymManagementSystemBLLayer.ModulesBLLayer.Workout
{
    public class WorkoutBLL
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
        public DataTable RetrieveExercisesBLL()
        {
            WorkoutDAL workoutDAL = new WorkoutDAL();
            return workoutDAL.RetrieveExercisesDAL();
        }
        // Retrieves exercise records for ComboBox.
        public DataTable GetExercisesForComboBox()
        {
            WorkoutDAL workoutDAL = new WorkoutDAL();
            return workoutDAL.GetExercisesForComboBox();
        }
        // Retrieves specific exercise details.
        public DataTable RetrieveSpecificExerciseBLL(int exerciseId)
        {
            WorkoutDAL workoutDAL = new WorkoutDAL();
            return workoutDAL.RetrieveSpecificExerciseDAL(exerciseId);
        }
        // Insert Exercise
        public string InsertExerciseBLL(string exerciseName,string muscleType)
        {
            try
            {
                // Exercise Name Validation
                ValidationBll.CommonValidationMessage validationMessage = ValidationBll.ValidateName(exerciseName);

                if (validationMessage != ValidationBll.CommonValidationMessage.Valid)
                {
                    return ValidationBll.GetValidationMessage(
                        validationMessage);
                }


                // Muscle Type Validation
                validationMessage =
                    ValidationBll.ValidateName(muscleType);

                if (validationMessage !=
                    ValidationBll.CommonValidationMessage.Valid)
                {
                    return ValidationBll.GetValidationMessage(
                        validationMessage);
                }


                // Insert
                WorkoutDAL workoutDAL = new WorkoutDAL();

                return workoutDAL.InsertExerciseDAL(
                    exerciseName,
                    muscleType);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}