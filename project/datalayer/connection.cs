using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace datalayer
{
    //************CLASS FOR CONNECTION STRING*************************//
   // public class connection
   // {
   //     private SqlConnection conn; //CREATE A OBJECT WHICH IS SQLCONNECTION TYPE//
   //    protected SqlConnection get_connection() //FUNCTION WHICH RETURN CONNECTION
   //    {
   //        conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);//CREATE THE CONNECTION STRING
   //        return conn;//RETURN THE CONNECTION STRING
   //    }

   //}
    public abstract class ClsCon
    {
        protected SqlConnection con = new SqlConnection();//create the object of the sqlconnection
        public ClsCon()//class constructor
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;//create the connection string
        }
    }
   
}
