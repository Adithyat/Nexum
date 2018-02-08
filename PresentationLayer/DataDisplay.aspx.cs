using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class DataDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["PersonID"]);
            ID_People per = new ID_People();
            per.PersonID = id;
            People p = per.getPerson();
            IdCell.Text = p.ID.ToString();
            NameCell.Text = p.Name.ToString();
            PhoneCell.Text = p.Phone.ToString();
            RegionCell.Text = p.Region;
            CountryCell.Text = p.Country;
            StateCell.Text = p.State;
            CityCell.Text = p.City.ToString();
        }
    }
}