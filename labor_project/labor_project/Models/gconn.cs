using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace labor_project.Models
{
 
    public class gconn
    {
        static string con;
        public static gconn()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"]
                                                        .ToString());
        }
    }
}