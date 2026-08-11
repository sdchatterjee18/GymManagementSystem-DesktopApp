using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GymManagementSystemDALayer.ModulesDALayer.Trainer;


namespace GymManagementSystemBLLayer.ModulesBLLayer.Trainer
{
    public class TrainerBLL
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

        public DataTable RetrieveAllTrainerBLL()
        {
            DataTable RetrieveAllTrainers = null;
            try
            {
                TrainerDAL TrainerDAL = new TrainerDAL();
                RetrieveAllTrainers = TrainerDAL.RetrieveAllTrainerDAL();
                return RetrieveAllTrainers;
            }
            catch (Exception ex)
            {
                return RetrieveAllTrainers;
            }

        }

        public DataTable RetrieveTrainerByPhoneNoBLL(string phoneNo)
        {
            TrainerPhoneNo = phoneNo;
            DataTable RetireveTrainerByPhoneNo = null;
            try
            {
                TrainerDAL TrainerDAL = new TrainerDAL();
                RetireveTrainerByPhoneNo = TrainerDAL.RetrieveTrainerByPhoneNoDAL(TrainerPhoneNo);
                return RetireveTrainerByPhoneNo;
            }
            catch (Exception ex)
            {
                return RetireveTrainerByPhoneNo;
            }

        }


        public DataTable RetrieveGeneralTrainerBLL()
        {
            DataTable RetrieveGeneralTrainers = null;
            try
            {
                TrainerDAL TrainerDAL = new TrainerDAL();
                RetrieveGeneralTrainers = TrainerDAL.RetrieveGeneralTrainerDAL();
                return RetrieveGeneralTrainers;
            }
            catch (Exception ex)
            {
                return RetrieveGeneralTrainers;
            }

        }


        public DataTable RetrievePersonalTrainerBLL()
        {
            DataTable RetrievePersonalTrainers = null;
            try
            {
                TrainerDAL TrainerDAL = new TrainerDAL();
                RetrievePersonalTrainers = TrainerDAL.RetrievePersonalTrainerDAL();
                return RetrievePersonalTrainers;
            }
            catch (Exception ex)
            {
                return RetrievePersonalTrainers;
            }

        }

    }
}
