using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using GymManagementSystemDALayer.Common;

namespace GymManagementSystemDALayer.ModulesDALayer.Trainer
{
    public class TrainerDAL
    {
        public int EmployeeId { get; set; }
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }
        public string Specialization { get; set; }
        public string TrainerType { get; set; }
        public byte Document { get; set; }
        public string PhoneNo { get; set; }
        public string Gender { get; set; }
        public string ShowAllTrainerSPName { get; set; }
        public string ShowGeneralTrainerSPName { get; set; }
        public string ShowPersonalTrainerSPName { get; set; }
        public string SearchPhoneNoSPName { get; set; }

        public string TrainerPhoneNo { get; set; }

        public TrainerDAL()
        {
            ShowAllTrainerSPName = "spGetAllTrainerEmployeeDetails";
            SearchPhoneNoSPName = "spRetrieveTrainersByPhoneNumber";
            ShowGeneralTrainerSPName = "DisplayGeneralTrainers";
            ShowPersonalTrainerSPName = "DisplayPersonalTrainers";
        }

        //Retrieve all Trainers
        public DataTable RetrieveAllTrainerDAL()
        {
            DataTable RetrieveAllTrainers = null;
            try
            {
                RetrieveAllTrainers = LookupDAL.RetrieveSpecificItem(ShowAllTrainerSPName);
                return RetrieveAllTrainers;
            }
            catch (Exception ex)
            {
                return RetrieveAllTrainers;
            }
        }

        //Retrieve Trainer By PhoneNo

        public DataTable RetrieveTrainerByPhoneNoDAL(string phoneNo)
        {
            
            TrainerPhoneNo = phoneNo;
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@PhoneNo",TrainerPhoneNo)
            };
            DataTable RetrieveTrainerByPhoneNo = null;
            try
            {
               RetrieveTrainerByPhoneNo = LookupDAL.RetrieveSpecificDetails(SearchPhoneNoSPName, sqlParameter);
               return RetrieveTrainerByPhoneNo;
            }
            catch (Exception ex)
            {
                return RetrieveTrainerByPhoneNo;
            }
        }

        //Retrieve General Trainers
        public DataTable RetrieveGeneralTrainerDAL()
        {
            DataTable RetrieveGeneralTrainers = null;
            try
            {
                RetrieveGeneralTrainers = LookupDAL.RetrieveSpecificItem(ShowGeneralTrainerSPName);
                return RetrieveGeneralTrainers;
            }
            catch (Exception ex)
            {
                return RetrieveGeneralTrainers;
            }
        }

        //Retrieve Personal Trainers
        public DataTable RetrievePersonalTrainerDAL()
        {
            DataTable RetrievePersonalTrainers = null;
            try
            {
                RetrievePersonalTrainers = LookupDAL.RetrieveSpecificItem(ShowPersonalTrainerSPName);
                return RetrievePersonalTrainers;
            }
            catch (Exception ex)
            {
                return RetrievePersonalTrainers;
            }
        }
    }
}
