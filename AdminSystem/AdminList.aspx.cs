using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaff(); 
        }

    }

    void DisplayStaff()
    {
        //create instance of staff collection
        clsStaffCollection staffCollection = new clsStaffCollection();
        //set the data source to list staff in collection
        lstStaffList.DataSource = staffCollection.StaffList;
        //set the name of primary key
        lstStaffList.DataValueField = "StaffId";
        //set the data field to display
        lstStaffList.DataTextField = "StaffUser";
        //bind the data to list
        lstStaffList.DataBind();

    }
}