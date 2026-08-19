using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.ModulesBLLayer.Workout;

namespace GymManagementSystem.FORMS.Workout.UI
{
    public class WorkoutUI
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
        public DataTable RetrieveExercisesUI()
        {
            WorkoutBLL workoutBLL = new WorkoutBLL();
            return workoutBLL.RetrieveExercisesBLL();
        }
        // Retrieves exercise records for ComboBox.
        public DataTable GetExercisesForComboBox()
        {
            WorkoutBLL workoutBLL = new WorkoutBLL();
            return workoutBLL.GetExercisesForComboBox();
        }
        // Retrieves specific exercise details.
        public DataTable RetrieveSpecificExerciseUI(string Search)
        {
            WorkoutBLL workoutBLL = new WorkoutBLL();
            return workoutBLL.RetrieveSpecificExerciseBLL(Search);
        }
        //Insert Exercise
        public string InsertExerciseUI(string exerciseName,string muscleType)
        {
            try
            {
                WorkoutBLL workoutBLL = new WorkoutBLL();

                return workoutBLL.InsertExerciseBLL(
                    exerciseName,
                    muscleType);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Retrieves all workout plan records.
        public DataTable RetrieveWorkoutPlansUI()
        {
            WorkoutBLL workoutBLL = new WorkoutBLL();
            return workoutBLL.RetrieveWorkoutPlansBLL();
        }
        // Retrieves workout plans for ComboBox.
        public DataTable GetWorkoutPlansForComboBox()
        {
            WorkoutBLL workoutBLL = new WorkoutBLL();
            return workoutBLL.GetWorkoutPlansForComboBox();
        }
        // Retrieves specific workout plan details.
        public DataTable RetrieveSpecificWorkoutPlanUI(string Search)
        {
            WorkoutBLL workoutBLL = new WorkoutBLL();
            return workoutBLL.RetrieveSpecificWorkoutPlanBLL(Search);
        }
        // Insert Workout Plan
        public string InsertWorkoutPlanUI(string workoutName,string description)
        {
            try
            {
                WorkoutBLL workoutBLL =
                    new WorkoutBLL();

                return workoutBLL.InsertWorkoutPlanBLL(
                    workoutName,
                    description);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Retrieves all workout schedule records.
        public DataTable RetrieveWorkoutScheduleRecordsUI()
        {
            WorkoutBLL workoutBLL = new WorkoutBLL();
            return workoutBLL.RetrieveWorkoutScheduleRecordsBLL();
        }

        // Retrieves workout days for ComboBox
        public List<string> GetWorkoutDaysUI()
        {
            WorkoutBLL workoutBLL = new WorkoutBLL();
            return workoutBLL.GetWorkoutDaysBLL();
        }
        // Retrieves Workout Schedule records by Workout Day
        public DataTable RetrieveWorkoutScheduleByDayUI(string workoutDay)
        {
            try
            {
                WorkoutBLL workoutBLL = new WorkoutBLL();
                return workoutBLL.RetrieveWorkoutScheduleByDayBLL(workoutDay);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Insert workout shedule
        public string InsertWorkoutScheduleUI(int workoutPlanId,int exerciseId,string workoutDay)
        {
            try
            {
                WorkoutBLL workoutBLL = new WorkoutBLL();

                return workoutBLL.InsertWorkoutScheduleBLL(
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
        public string RemoveWorkoutScheduleByIdUI(int workoutScheduleId)
        {
            try
            {
                WorkoutBLL workoutBLL = new WorkoutBLL();

                return workoutBLL.RemoveWorkoutScheduleByIdBLL(
                    workoutScheduleId);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}