using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class NexumHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                lstRegions.DataSource = Region.GetRegionList();
                lstRegions.DataValueField = "RegionID";
                lstRegions.DataTextField = "RegionName";
                
                lstRegions.DataBind();
                lstRegions.Items.Insert(0, new ListItem("", ""));

            }
        }

        protected void GetCountries(object sender, EventArgs e)
        {
            
            lstCountries.DataSource = Country.GetCountryList(lstRegions.SelectedValue);
            lstCountries.DataValueField = "CountryID";
            lstCountries.DataTextField = "CountryName";
            lstCountries.DataBind();
        }

        protected void GetStates(object sender, EventArgs e)
        {
            
            lstStates.DataSource = State.GetStateList(lstCountries.SelectedValue);
            lstStates.DataValueField = "StateID";
            lstStates.DataTextField = "StateName";
            lstStates.DataBind();
        }

        protected void GetCities(object sender, EventArgs e)
        {
            
            lstCities.DataSource = City.GetCityList(lstStates.SelectedValue, lstCountries.SelectedValue);
            lstCities.DataValueField = "CityID";
            lstCities.DataTextField = "CityName";
            lstCities.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string region = Convert.ToString(lstRegions.SelectedItem);
            string country = Convert.ToString(lstCountries.SelectedItem);
            string state = Convert.ToString(lstStates.SelectedItem);
            string city = Convert.ToString(lstCities.SelectedItem);

            BusinessLayer.People.InsertPeople(Name.Text, Phone.Text, region, country, state, city);
            Button1.Text = "submitted";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.Url.PathAndQuery, true);
        }
    }
}