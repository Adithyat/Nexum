using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class NexumView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = ID_People.GetIdOnlyList();
                GridView1.DataBind();

                regDD.DataSource = Region.GetRegionList();
                regDD.DataValueField = "RegionID";
                regDD.DataTextField = "RegionName";
                regDD.DataBind();

                ctryDD.DataSource = Country.GetCountryList(regDD.SelectedValue);
                ctryDD.DataValueField = "CountryID";
                ctryDD.DataTextField = "CountryName";
                ctryDD.DataBind();

                stateDD.DataSource = State.GetStateList(ctryDD.SelectedValue);
                stateDD.DataValueField = "StateID";
                stateDD.DataTextField = "StateName";
                stateDD.DataBind();

                cityDD.DataSource = City.GetCityList(stateDD.SelectedValue, ctryDD.SelectedValue);
                cityDD.DataValueField = "CityID";
                cityDD.DataTextField = "CityName";
                cityDD.DataBind();
            }

        }

        protected void Filter_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = ID_People.FilterIdOnlyList(Convert.ToString(regDD.SelectedItem), Convert.ToString(ctryDD.SelectedItem), Convert.ToString(stateDD.SelectedItem), Convert.ToString(cityDD.SelectedItem));
            GridView1.DataBind();
            //Response.Redirect(this.ToString());
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.Url.PathAndQuery, true);
            regDD.SelectedIndex = 0;

            ctryDD.DataSource = Country.GetCountryList("0");
            ctryDD.DataValueField = "CountryID";
            ctryDD.DataTextField = "CountryName";
            ctryDD.DataBind();

            stateDD.DataSource = State.GetStateList("0");
            stateDD.DataValueField = "StateID";
            stateDD.DataTextField = "StateName";
            stateDD.DataBind();

            cityDD.DataSource = City.GetCityList("0","0");
            cityDD.DataValueField = "CityID";
            cityDD.DataTextField = "CityName";
            cityDD.DataBind();

            GridView1.DataSource = ID_People.GetIdOnlyList();
            GridView1.DataBind();
        }

        protected void RegDD_OnSelectedIndexChange(object sender, EventArgs e)
        {
            ctryDD.DataSource = Country.GetCountryList(regDD.SelectedValue);
            ctryDD.DataValueField = "CountryID";
            ctryDD.DataTextField = "CountryName";
            ctryDD.DataBind();

            stateDD.DataSource = State.GetStateList(ctryDD.Items[0].Value);
            stateDD.DataValueField = "StateID";
            stateDD.DataTextField = "StateName";
            stateDD.DataBind();

            cityDD.DataSource = City.GetCityList(stateDD.Items[0].Value, ctryDD.Items[0].Value);
            cityDD.DataValueField = "CityID";
            cityDD.DataTextField = "CityName";
            cityDD.DataBind();
        }

        protected void CtryDD_OnSelectedIndexChange(object sender, EventArgs e)
        {
            stateDD.DataSource = State.GetStateList(ctryDD.SelectedValue);
            stateDD.DataValueField = "StateID";
            stateDD.DataTextField = "StateName";
            stateDD.DataBind();

            cityDD.DataSource = City.GetCityList(stateDD.Items[0].Value, ctryDD.SelectedValue);
            cityDD.DataValueField = "CityID";
            cityDD.DataTextField = "CityName";
            cityDD.DataBind();
        }

        protected void StateDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityDD.DataSource = City.GetCityList(stateDD.SelectedValue, ctryDD.SelectedValue);
            cityDD.DataValueField = "CityID";
            cityDD.DataTextField = "CityName";
            cityDD.DataBind();
        }



        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton name = (LinkButton)e.Row.FindControl("lnkbtn");
                name.Attributes.Add("OnClick", "OpenWindow(" + ((ID_People)e.Row.DataItem).PersonID.ToString() + ")");
            }
        }

        protected void chkProduct_CheckedChanged(object sender, EventArgs e)
        {
            delete_button.Enabled = true;
        }

        protected void delete_button_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            foreach (GridViewRow r in GridView1.Rows)
            {
                CheckBox chkbx = (CheckBox)r.FindControl("chkProduct");
                if (chkbx.Checked)
                {
                    int id = Convert.ToInt32(r.Cells[1].Text);
                    list.Add(id);
                }
                People.DeletePeopleList(list);
                GridView1.DataSource = ID_People.GetIdOnlyList();
                GridView1.DataBind();
            }
        }

       
    }
}