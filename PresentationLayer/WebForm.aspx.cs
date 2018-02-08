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
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lstCountries.DataSource = Country.GetCountryList();
                lstCountries.DataValueField = "CountryID";
                lstCountries.DataTextField = "CountryName";
                lstCountries.DataBind();
            }
        }
        protected void GetRegions(object sender, EventArgs e)
        {
            int CountryID = Convert.ToInt16(lstCountries.SelectedValue);
            lstStates.DataSource = State.GetStateList(CountryID);
            lstStates.DataValueField = "StateID";
            lstStates.DataTextField = "StateName";
            lstStates.DataBind();
        }

        protected void GetCities(object sender, EventArgs e)
        {
            int StateID = Convert.ToInt16(lstStates.SelectedValue);
            lstCities.DataSource = City.GetCityList(StateID);
            lstCities.DataValueField = "CityID";
            lstCities.DataTextField = "CityName";
            lstCities.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string country = Convert.ToString(lstCountries.SelectedItem);
            string state = Convert.ToString(lstStates.SelectedItem);
            string city = Convert.ToString(lstCities.SelectedItem);
            BusinessLayer.People.InsertPeople(Name.Text, Phone.Text, country, state, city);
            Button1.Text = "submitted";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.Url.PathAndQuery, true);
        }
    }
}