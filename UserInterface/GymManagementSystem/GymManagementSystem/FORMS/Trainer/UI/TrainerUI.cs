using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemBLLayer.ModulesBLLayer.Trainer;

namespace GymManagementSystem.FORMS.Trainer.UI
{
    public class TrainerUI
    {
        public int EmployeeId { get; set; }
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }
        public string Specialization { get; set; }
        public string TrainerType { get; set; }
        public byte Document { get; set; }
        public string PhoneNo { get; set; }
        public string Gender { get; set; }
        public string TrainerPhoneNo { get; set; }

        public DataTable RetrieveAllTrainerUI()
        {
            DataTable RetrieveAllTrainers = null;
            try
            {
                TrainerBLL TrainerBLL = new TrainerBLL();
                RetrieveAllTrainers = TrainerBLL.RetrieveAllTrainerBLL();
                return RetrieveAllTrainers;
            }
            catch (Exception ex)
            {
                return RetrieveAllTrainers;
            }
        }

        public DataTable RetrieveTrainerByPhoneNoUI(string phoneNo)
        {
            TrainerPhoneNo = phoneNo;
            DataTable RetireveTrainerByPhoneNo = null;
            try
            {
                TrainerBLL TrainerBLL = new TrainerBLL();
                RetireveTrainerByPhoneNo = TrainerBLL.RetrieveTrainerByPhoneNoBLL(TrainerPhoneNo);
                return RetireveTrainerByPhoneNo;
            }
            catch (Exception ex)
            {
                return RetireveTrainerByPhoneNo;
            }
        }

        public DataTable RetrieveGeneralTrainerUI()
        {
            DataTable RetrieveGeneralTrainers = null;
            try
            {
                TrainerBLL TrainerBLL = new TrainerBLL();
                RetrieveGeneralTrainers = TrainerBLL.RetrieveGeneralTrainerBLL();
                return RetrieveGeneralTrainers;
            }
            catch (Exception ex)
            {
                return RetrieveGeneralTrainers;
            }
        }

        public DataTable RetrievePersonalTrainerUI()
        {
            DataTable RetrievePersonalTrainers = null;
            try
            {
                TrainerBLL TrainerBLL = new TrainerBLL();
                RetrievePersonalTrainers = TrainerBLL.RetrievePersonalTrainerBLL();
                return RetrievePersonalTrainers;
            }
            catch (Exception ex)
            {
                return RetrievePersonalTrainers;
            }
        }
    }
}
