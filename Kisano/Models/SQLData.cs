using Kisano.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Kisano.Models
{
    public class SQLData
    {

        public static SqlConnection SQLConnection { get; set; }
        public const string Get_Consumer_Details="select * from " 

        public static void MakeConnection()
        {

            SQLConnection = DbUtility.GetSQLConnectionObj();

        }


       
    }
}