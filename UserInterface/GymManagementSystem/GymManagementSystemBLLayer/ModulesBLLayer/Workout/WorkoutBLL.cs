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
        public DataTable RetrieveSpecificExerciseBLL(string Search)
        {
            WorkoutDAL workoutDAL = new WorkoutDAL();
            return workoutDAL.RetrieveSpecificExerciseDAL(Search);
        }
        // Insert Exercise
        public ValidationResult InsertExerciseBLL()
        {
            ValidationBll.CommonValidationMessage result;

            // Exercise Name
            result = ValidationBll.ValidateOnlyLettersAndSpaces(this.ExerciseName);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "ExerciseName",
                    Result = result,
                    Message = "Exercise Name " +ValidationBll.GetValidationMessage(result)
                };
            }

            // Muscle Type
            result = ValidationBll.ValidateOnlyLettersAndSpaces(this.MuscleType);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "MuscleType",
                    Result = result,
                    Message = "Muscle Type " + ValidationBll.GetValidationMessage(result)
                };
            }

            // Insert
            WorkoutDAL workoutDAL = new WorkoutDAL();

            string message = workoutDAL.InsertExerciseDAL(
                this.ExerciseName,
                this.MuscleType);

            return new ValidationResult
            {
                FieldName = "",
                Result = ValidationBll.CommonValidationMessage.Valid,
                Message = message
            };
        }

        // Retrieves all workout plan records.
        public DataTable RetrieveWorkoutPlansBLL()
        {
            WorkoutDAL workoutDAL = new WorkoutDAL();
            return workoutDAL.RetrieveWorkoutPlansDAL();
        }
        // Retrieves workout plans for ComboBox.
        public DataTable GetWorkoutPlansForComboBox()
        {
            WorkoutDAL workoutDAL = new WorkoutDAL();
            return workoutDAL.GetWorkoutPlansForComboBox();
        }
        // Retrieves specific workout plan details.
        public DataTable RetrieveSpecificWorkoutPlanBLL(string Search)
        {
            WorkoutDAL workoutDAL = new WorkoutDAL();
            return workoutDAL.RetrieveSpecificWorkoutPlanDAL(Search);
        }
        // Insert Workout Plan
        public ValidationResult InsertWorkoutPlanBLL()
        {
            ValidationBll.CommonValidationMessage result;

            // Workout Plan Name
            result = ValidationBll.ValidateOnlyLettersAndSpaces(
                this.WorkoutName);

            if (result != ValidationBll.CommonValidationMessage.Valid)
            {
                return new ValidationResult
                {
                    FieldName = "WorkoutPlanName",
                    Result = result,
                    Message = "Workout Plan Name " +
                              ValidationBll.GetValidationMessage(result)
                };
            }

            // Description
            // No BLL validation required

            // Insert
            WorkoutDAL workoutDAL = new WorkoutDAL();

            string message = workoutDAL.InsertWorkoutPlanDAL(
                this.WorkoutName,
                this.Description);

            return new ValidationResult
            {
                FieldName = "",
                Result = ValidationBll.CommonValidationMessage.Valid,
                Message = message
            };
        }

        // Retrieves all workout schedule records.
        public DataTable RetrieveWorkoutScheduleRecordsBLL()
        {
            WorkoutDAL workoutDAL = new WorkoutDAL();
            return workoutDAL.RetrieveWorkoutScheduleRecordsDAL();
        }

        // Retrieves workout days for ComboBox( From Application)
        public List<string> GetWorkoutDaysBLL()
        {
            List<string> workoutDays = new List<string>();

            workoutDays.Add("Monday");
            workoutDays.Add("Tuesday");
            workoutDays.Add("Wednesday");
            workoutDays.Add("Thursday");
            workoutDays.Add("Friday");
            workoutDays.Add("Saturday");
            workoutDays.Add("Sunday");

            return workoutDays;
        }
        // Retrieves Workout Schedule records by Workout Day
        public DataTable RetrieveWorkoutScheduleByDayBLL(string workoutDay)
        {
            try
            {
                WorkoutDAL workoutDAL = new WorkoutDAL();
                return workoutDAL.RetrieveWorkoutScheduleByDayDAL(workoutDay);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Insert workout shedule
        public string InsertWorkoutScheduleBLL(int workoutPlanId,int exerciseId,string workoutDay)
        {
            try
            {
                if (workoutPlanId <= 0)
                    return "Please select Workout Name.";

                if (exerciseId <= 0)
                    return "Please select Exercise Name.";

                if (string.IsNullOrWhiteSpace(workoutDay))
                    return "Please select Workout Day.";

                WorkoutDAL workoutDAL = new WorkoutDAL();

                return workoutDAL.InsertWorkoutScheduleDAL(
                    workoutPlanId,
                    exerciseId,
                    workoutDay);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //Delete workoutshedule
        public string RemoveWorkoutScheduleByIdBLL(int workoutScheduleId)
        {
            try
            {
                WorkoutDAL workoutDAL = new WorkoutDAL();

                return workoutDAL.RemoveWorkoutScheduleByIdDAL(
                    workoutScheduleId);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}