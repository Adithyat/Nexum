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
    public class CountryDL
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["AdithyaConnectionString"].ToString();

        public static DataTable GetCountryList(int RegionID)
        {
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("GetCountries");
            command.Connection = con;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@region_id", RegionID);

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = command;
           da.Fill(ds);

            return ds.Tables[0];
        }
    }
}
