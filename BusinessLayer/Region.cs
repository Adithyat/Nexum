using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class Region
    {
        public int RegionID { get; set; }
        public string RegionName { get; set; }

        public static List<Region> GetRegionList()
        {
            List<Region> regions = new List<Region>();

            DataTable dt = RegionDL.GetRegionList();

            foreach (DataRow dr in dt.Rows)
            {
                Region Region = new Region();
                Region.RegionID = Convert.ToInt16(dr["ID"].ToString());
                Region.RegionName = dr["name"].ToString();

                regions.Add(Region);
            }
            return regions;
        }
        public static string GetRegionName()
        {
            DataTable dt = RegionDL.GetRegionList();
            DataRow dr = dt.Rows[0];
            return dr["name"].ToString();
        }
    }
}

