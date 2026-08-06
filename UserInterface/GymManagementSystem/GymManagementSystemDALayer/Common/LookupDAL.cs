using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using GymManagementSystemDALayer.ModulesDALayer.Shift;
using GymManagementSystemDALayer.ModulesDALayer.MembershipPlan;
using GymManagementSystemDALayer.ModulesDALayer.DietPlan;
using GymManagementSystemDALayer.SqlHelper;

namespace GymManagementSystemDALayer.Common
{
    public class LookupDAL
    {
        public static List<ShiftDAL> GetShifts()
        {
            List<ShiftDAL> Shifts = null;
            SqlConnection sqlConnection = null;
            try
            {
                Shifts = new List<ShiftDAL>();
                //throw new Exception("Testing exception");
                using (sqlConnection = DBconnection.GetSqlConnection())
                {
                    SqlCommand cmd = new SqlCommand("spRetrieveShiftTimeTable", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    sqlConnection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ShiftDAL shift = new ShiftDAL();
                        shift.ShiftId = Convert.ToInt32(reader["ShiftId"]);
                        shift.ShiftName = reader["ShiftName"].ToString();
                        Shifts.Add(shift);
                    }
                    return Shifts;
                }
            }
            catch(Exception ex)
            {
                return Shifts;
            }
            finally
            {
                if(sqlConnection!=null)
                {
                    sqlConnection.Close();
                }
            }
            
            //return Shifts;
        }
        public static List<MembershipPlanDAL> GetMembershipPlans()
        {
            List<MembershipPlanDAL> MembershipPlans = null;
            SqlConnection sqlConnection = null;
            try
            {
                MembershipPlans = new List<MembershipPlanDAL>();
                using (sqlConnection = DBconnection.GetSqlConnection())
                {
                    SqlCommand cmd = new SqlCommand("spRetrieveMembershipPlans", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    sqlConnection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        MembershipPlanDAL membershipPlanDAL = new MembershipPlanDAL();
                        membershipPlanDAL.MembershipPlanId = Convert.ToInt32(reader["MembershipPlanId"]);
                        membershipPlanDAL.MembershipPlanName = reader["MembershipPlanName"].ToString();
                    }
                    return MembershipPlans;
                }
            }
            catch(Exception ex)
            {
                return MembershipPlans;
            }
            finally
            {
                if(sqlConnection!=null)
                {
                    sqlConnection.Close();
                }
            }
        }
      public static List<DietPlanDAL> GetDietPlans()
      {
         List<DietPlanDAL> dietPlans = null;
        SqlConnection sqlConnection = null;
        try
        {
          dietPlans = new List<DietPlanDAL>();
          using (sqlConnection = DBconnection.GetSqlConnection())
          {
              SqlCommand cmd = new SqlCommand("spRetrieveDietPlanDetails", sqlConnection);
              cmd.CommandType = CommandType.StoredProcedure;
              sqlConnection.Open();
              SqlDataReader reader = cmd.ExecuteReader();
              while (reader.Read())
              {
                  DietPlanDAL dietPlan = new DietPlanDAL();
                  dietPlan.DietPlanId = Convert.ToInt32(reader["DietPlanId"]);
                  dietPlan.CaloriesPerDay = Convert.ToInt32(reader["CaloriesPerDay"]);
                  dietPlans.Add(dietPlan);
              }
              return dietPlans;
            }
           }
           catch (Exception ex)
           {
             return dietPlans;
           }
           finally
           {
              if (sqlConnection != null)
              {
                  sqlConnection.Close();
              }
           }
        }
     public static DataTable GetGenderDetails()
     {
        DataTable dtGender = null;
        SqlConnection sqlConnection = null;
        try
        {
          dtGender = new DataTable();
          using (sqlConnection = DBconnection.GetSqlConnection())
          {
             SqlCommand cmd = new SqlCommand("spRetrieveGenderDetails", sqlConnection);
             cmd.CommandType = CommandType.StoredProcedure;
             sqlConnection.Open();
             SqlDataAdapter adapter = new SqlDataAdapter(cmd);
             adapter.Fill(dtGender);
            return dtGender;
         }
        }
        catch (Exception ex)
        {
          return dtGender;
        }
        finally
        {
           if (sqlConnection != null)
           {
              sqlConnection.Close();
           }
        }
       }
        public static DataTable RetrieveSpecificItem(string spName)
        {
            DataTable dataTable = null;
            SqlConnection sqlConnection = null;

            try
            {
                using (sqlConnection = DBconnection.GetSqlConnection())
                {
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(spName, sqlConnection))
                    {
                        sqlDataAdapter.SelectCommand.CommandType =
                            CommandType.StoredProcedure;

                        dataTable = new DataTable();

                        sqlDataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch
            {
                return dataTable;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
        public static DataTable UpdateSpecificItemById(string spName,int id,string parameterId,decimal price,string description)
        {
            DataTable dataTable = null;
            SqlConnection sqlConnection = null;

            try
            {
                using (sqlConnection = DBconnection.GetSqlConnection())
                {
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(spName, sqlConnection))
                    {
                        sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                        sqlDataAdapter.SelectCommand.Parameters.AddWithValue(parameterId, id);
                        sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Description", description);
                        sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@NewPrice", price);

                        dataTable = new DataTable();

                        sqlDataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch
            {
                return dataTable;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
        public static DataTable DeactivateSpecificItemById(string spName, int id, string parameterName)
        {
            DataTable dataTable = null;
            SqlConnection sqlConnection = null;

            try
            {
                dataTable=new Datatable();
                using (sqlConnection = DBconnection.GetSqlConnection())
                {
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(spName, sqlConnection))
                    {
                        sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sqlDataAdapter.SelectCommand.Parameters.AddWithValue(parameterName, id);
                        sqlDataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
            catch
            {
                return dataTable;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
        public static DataTable RetrieveSpecificDetailsById(string spName,int id,string parameterId)
        {
            DataTable dataTable = null;
            SqlConnection sqlConnection = null;

            try
            {
                using (sqlConnection = DBconnection.GetSqlConnection())
                {
                    using (SqlDataAdapter sqlDataAdapter=new SqlDataAdapter(spName,sqlConnection))
                    {
                        sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                        sqlDataAdapter.SelectCommand.Parameters.AddWithValue(parameterId, id);
                        dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
            catch
            {
                return dataTable;
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
            } 
        }
    }
}