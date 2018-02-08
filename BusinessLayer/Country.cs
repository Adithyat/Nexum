using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public static List<Country> GetCountryList(string RegionID)
        {
            int RID = Convert.ToInt16(RegionID);
            List<Country> countries = new List<Country>();

            DataTable dt = CountryDL.GetCountryList(RID);

            foreach (DataRow dr in dt.Rows)
            {
                Country country = new Country();
                country.CountryID = Convert.ToInt16(dr["ID"].ToString());
                country.CountryName = dr["name"].ToString();

                countries.Add(country);
            }
            return countries;
        }
        public static string GetCountryName(int ID)
        {
            DataTable dt = CountryDL.GetCountryList(ID);
            DataRow dr = dt.Rows[0];
            return dr["name"].ToString();
        }

    }
}
