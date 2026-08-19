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
        // Retrieves data from the database for populating ComboBox controls.
        public static DataTable GetComboBoxDetails(string spName)
        {
            DataTable dataTable = new DataTable();
            SqlConnection sqlConnection = null;

            try
            {
                using (sqlConnection = DBconnection.GetSqlConnection())
                {
                    using (SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(spName, sqlConnection))
                    {
                        sqlDataAdapter.SelectCommand.CommandType =
                            CommandType.StoredProcedure;

                        sqlDataAdapter.Fill(dataTable);
                    }
                }

                return dataTable;
            }
            catch (Exception)
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
        // Retrieves data by executing the specified stored procedure.
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
            catch(Exception ex)
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
        // Updates a specific record by executing the specified stored procedure
        public static string UpdateSpecificItem(string spName, SqlParameter[] sqlParameter)
        {
            string UpdateMessege = null;
            SqlConnection sqlConnection = null;
            try
            {
                using (sqlConnection = DBconnection.GetSqlConnection())
                {
                    using (SqlCommand sqlCommand = new SqlCommand(spName, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddRange(sqlParameter);
                        sqlConnection.Open();
                        object result = sqlCommand.ExecuteScalar();
                        if (result != null)
                        {
                            UpdateMessege = result.ToString();
                        }

                        return UpdateMessege;
                    }
                }
            }
            catch(Exception ex)
            {
                return UpdateMessege;
            }
            finally
            {
                if (sqlConnection!=null)
                {
                    sqlConnection.Close();
                }
            }
        }
        // Deactivates or changes the status of a specific record using its ID.
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
            catch(Exception ex)
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
        // Retrieves specific record details using an ID.
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
        // Inserts a new record by executing the specified stored procedure
        public static string InsertSpecificItem(string spName, SqlParameter[] sqlParameter)
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
                        sqlCommand.Parameters.AddRange(sqlParameter);
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
        // Retrieves a single value from the database by executing
        public static object GetSingleData(string spName, SqlParameter[] parameters)
        {
            SqlConnection sqlConnection = null;
            try
            {
                using (sqlConnection = DBconnection.GetSqlConnection())
                {
                    using (SqlCommand sqlCommand = new SqlCommand(spName, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        if (parameters != null && parameters.Length > 0)
                        {
                            sqlCommand.Parameters.AddRange(parameters);
                        }
                        sqlConnection.Open();
                        object result = sqlCommand.ExecuteScalar();
                        return result;
                    }
                }
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
        // Retrieves specific records by executing the specified stored procedure
        public static DataTable RetrieveSpecificDetails(string spName,SqlParameter[] sqlParameters)
        {
            DataTable dataTable = null;
            SqlConnection sqlConnection = null;

            try
            {
                using (sqlConnection = DBconnection.GetSqlConnection())
                {
                    using (SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(spName, sqlConnection))
                    {
                        sqlDataAdapter.SelectCommand.CommandType =
                            CommandType.StoredProcedure;
                        sqlDataAdapter.SelectCommand.Parameters.AddRange(
                            sqlParameters);
                        dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
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