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
        public static DataTable GetComboBoxDetails(string spName)
     {
        DataTable dataTable = null;
        SqlConnection sqlConnection = null;
        try
        {
           dataTable = new DataTable();
          using (sqlConnection = DBconnection.GetSqlConnection())
          {
              SqlCommand cmd = new SqlCommand(spName, sqlConnection);
             cmd.CommandType = CommandType.StoredProcedure;
             sqlConnection.Open();
             SqlDataAdapter adapter = new SqlDataAdapter(cmd);
             adapter.Fill(dataTable);
             return dataTable;
         }
        }
        catch (Exception ex)
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
                dataTable=new DataTable();
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
            catch(Exception ex)
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