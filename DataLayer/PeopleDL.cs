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
    public class PeopleDL
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["WFConnectionString"].ToString();

        public static void InsertPeople(string name,long phone, string region, string country, string state, string city)
        {
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("InsertPeople");
            command.Connection = con;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@name", SqlDbType.VarChar,255).Value = name;
            command.Parameters.Add("@phone", SqlDbType.BigInt).Value = phone;
            command.Parameters.Add("@region", SqlDbType.VarChar, 255).Value = region;
            command.Parameters.Add("@country", SqlDbType.VarChar,255).Value = country;
            command.Parameters.Add("@state", SqlDbType.VarChar,255).Value = state; 
            command.Parameters.Add("@city", SqlDbType.VarChar,255).Value = city;
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            
        }

        public static void DeletePerson(int ID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("DeletePerson");
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p_ID = new SqlParameter("@ID", SqlDbType.Int);
            p_ID.Value = ID;
            cmd.Parameters.Add(p_ID);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        public static DataTable GetPeople()
        {
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("GetPeople");
            command.Connection = con;
            command.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = command;
            da.Fill(ds);

            return ds.Tables[0];
        }

        public static DataTable GetFilteredList(string Region, string Country, string State, string City)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("GetFiltered");
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;

            
            cmd.Parameters.Add("@Reg", SqlDbType.VarChar, 255).Value = Region;
            cmd.Parameters.Add("@country", SqlDbType.VarChar, 255).Value = Country;
            cmd.Parameters.Add("@state", SqlDbType.VarChar, 255).Value = State;
            cmd.Parameters.Add("@city", SqlDbType.VarChar, 255).Value = City;
       
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);

            return ds.Tables[0];
        }

        public static DataTable GetPersonByID(int ID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("GetPersonByID");
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p_ID = new SqlParameter("@ID", SqlDbType.Int);
            p_ID.Value = ID;
            cmd.Parameters.Add(p_ID);

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);

            return ds.Tables[0];
        }
    }
}
