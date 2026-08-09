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
        public DataTable RetrieveSpecificExerciseUI(int exerciseId)
        {
            WorkoutBLL workoutBLL = new WorkoutBLL();
            return workoutBLL.RetrieveSpecificExerciseBLL(exerciseId);
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
    }
}