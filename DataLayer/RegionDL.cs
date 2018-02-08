using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DataLayer
{
    public class RegionDL
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["AdithyaConnectionString"].ToString();

        public static DataTable GetRegionList()
        {
            SqlConnection con = new SqlConnection(connectionString);
          
            SqlCommand command = new SqlCommand("GetRegions");
            command.Connection = con;
            command.CommandType = CommandType.StoredProcedure;
            

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = command;
            da.Fill(ds);

            
            return ds.Tables[0];
        }
    }
}
