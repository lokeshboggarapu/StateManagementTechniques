using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Configuration;


namespace SessionDemo
{
    public class ConnectionStrings
    {

         public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ToString());
    }
}