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
        public static string UpdateSpecificItem(string spName, SqlParameter[] parameters)
        {
            string Messege = null;
            SqlConnection sqlConnection = null;
            try
            {
                using (sqlConnection = DBconnection.GetSqlConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(spName, sqlConnection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(parameters);
                        sqlConnection.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            Messege = result.ToString();
                        }

                        return Messege;
                    }
                }
            }
            catch
            {
                return Messege;
            }
            finally
            {
                if (sqlConnection!=null)
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
        public static string InsertSpecificItem(string spName, SqlParameter[] parameters)
        {
            SqlConnection sqlConnection = null;
            string RowMessage = null;
            try
            {
                using (sqlConnection = DBconnection.GetSqlConnection())
                {
                    using (SqlCommand sqlCommand = new SqlCommand(spName, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddRange(parameters);
                        sqlConnection.Open();
                        RowMessage=Convert.ToString(sqlCommand.ExecuteScalar());
                        return RowMessage;
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }


    }
}