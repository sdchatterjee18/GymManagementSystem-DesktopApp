using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace GymManagementSystemDALayer.SqlHelper
{
    public class DBconnection
    {
        public  static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString);
        }
    }
}
