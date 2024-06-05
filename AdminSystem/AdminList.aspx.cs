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
        //create new instance of clsstaffuser
        clsStaffUser staffuser = new clsStaffUser();
        //get data from session object
        staffuser = (clsStaffUser)Session["staffuser"];
        //display username
        Response.Write("Logged in as: " + staffuser.StaffUsername);

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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store the -1 into the session object to indicate this is a new record
        Session["StaffId"] = -1;
        //redirect to data entry page
        Response.Redirect("AdminDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 StaffId;
        //if record has been selected from list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get primary key value of record to edit
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in session object
            Session["StaffId"] = StaffId;
            //redirect to edit page
            Response.Redirect("AdminDataEntry.aspx");

        }
        else
        {
            //if no record selected, make error visible
            lblError.Visible = true;
            lblError.Text = "please select a record from list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 StaffId;
        //if record has been selected from list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get primary key value of record to delete
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in session object
            Session["StaffId"] = StaffId;
            //redirect to delete page
            Response.Redirect("AdminConfirmDelete.aspx");
            Console.WriteLine(StaffId);
        }
        else
        {
            //if no record selected
            lblError.Visible = true;
            lblError.Text = "Please select a record from list to delete";
        }
        
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsStaffCollection staffcollection = new clsStaffCollection();
        //retrieve value of nickname from presentation layer
        staffcollection.ReportbyNickName(txtFilterNickname.Text);
        //set the data source to the list of staff in the collection
        lstStaffList.DataSource = staffcollection.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the name of the field to display
        lstStaffList.DataTextField = "staffNickName";
        ///bind data to list
        lstStaffList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsStaffCollection staffCollection = new clsStaffCollection();
        //set empty string
        staffCollection.ReportbyNickName("");
        //clear any existing filter to tidy up ui
        txtFilterNickname.Text = "";
        //set the data source to the list of staff in the collection
        lstStaffList.DataSource = staffCollection.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the name of the field to display
        lstStaffList.DataTextField = "staffNickName";
        ///bind data to list
        lstStaffList.DataBind();
    }


    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //redirect to mainmenu
        Response.Redirect("TeamMainMenu.aspx");
    }
}