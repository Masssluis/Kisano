using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Kisano.Utility
{
    public class DbUtility
    {
        public static SqlConnection GetSQLConnectionObj()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}