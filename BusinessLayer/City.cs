using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;

namespace BusinessLayer
{
    public class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }

        public static List<City> GetCityList(string StateID,string CountryID)
        {
            int SID = Convert.ToInt16(StateID);
            int CID = Convert.ToInt16(CountryID);
            List<City> Cities = new List<City>();

            DataTable dt = CityDL.GetCities(SID,CID);

            foreach (DataRow dr in dt.Rows)
            {
                City City = new City();
                City.CityID = Convert.ToInt32(dr["ID"].ToString());
                City.CityName = dr["name"].ToString();

                Cities.Add(City);
            }
            return Cities;
        }
        public static string GetRegionName(int ID)
        {
            DataTable dt = RegionDL.GetRegionList();
            DataRow dr = dt.Rows[0];
            return dr["name"].ToString();
        }
    }
}
