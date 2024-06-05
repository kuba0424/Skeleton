using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store primary key with page level scope
    Int32 StaffId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffId != -1)
            {
                //display current data for record
                DisplayStaff();
            }
        }

    }

    void DisplayStaff()
    {
        //create instance of staffcollection
        clsStaffCollection staffCollection = new clsStaffCollection();
        staffCollection.ThisStaff.Find(StaffId);
        //display the data for the record
        txtStaffId.Text = staffCollection.ThisStaff.StaffId.ToString();
        txtStaffUser.Text = staffCollection.ThisStaff.StaffUser.ToString();
        txtStaffPass.Text = staffCollection.ThisStaff.StaffPass.ToString();
        txtStaffNickName.Text = staffCollection.ThisStaff.StaffNickName.ToString();
        txtStaffDateCreated.Text = staffCollection.ThisStaff.StaffDateCreated.ToString();
        chkStaffIsAdmin.Checked = staffCollection.ThisStaff.StaffIsAdmin;
        txtDepartment.Text = staffCollection.ThisStaff.StaffDep;
    }

   

    protected void btnStaffOk_Click(object sender, EventArgs e)
    {
        //create new instance of clsStaff
        clsStaff staff = new clsStaff();
        //capture the username
        string StaffUser = txtStaffUser.Text;
        //caputre password
        string StaffPass = txtStaffPass.Text;
        //capture the nickname
        string StaffNickName = txtStaffNickName.Text;
        //capture date added
        string StaffDateCreated = txtStaffDateCreated.Text;
        //capture is Admin checkbox
        string StaffIsAdmin = chkStaffIsAdmin.Text;
        //capture department
        string staffDepartment = txtDepartment.Text;
        //variable to store error msg
        string Error = "";
        //validate data
        Error = staff.Valid(StaffUser, StaffPass, StaffNickName, StaffDateCreated,staffDepartment);
        if (Error == "")
        {
            //capture staff id
            staff.StaffId = StaffId;
            //capture data
            staff.StaffUser = StaffUser;
            staff.StaffPass = StaffPass;
            staff.StaffDateCreated = Convert.ToDateTime(StaffDateCreated);
            staff.StaffNickName = StaffNickName;
            staff.StaffIsAdmin = chkStaffIsAdmin.Checked;
            staff.StaffDep = staffDepartment;
            //create new instance of staff collection
            clsStaffCollection StaffList = new clsStaffCollection();
            if (StaffId == -1)
            {
                //set the thisstaff property
                StaffList.ThisStaff = staff;
                StaffList.Add();
            }
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(StaffId);
                //set the thisstaff property
                StaffList.ThisStaff = staff;
                //update record
                StaffList.Update();
            }
            Response.Redirect("AdminList.aspx");
            
            

        }
        else
        {
            //display error msg
            lblStaffError.Visible = true;
            lblStaffError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff staff = new clsStaff();
        //create variable to store primary key
        Int32 StaffId;
        //create variable to store result of find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffId = Convert.ToInt32(txtStaffId.Text);
        //find the record
        Found = staff.Find(StaffId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStaffUser.Text = staff.StaffUser;
            txtStaffPass.Text = staff.StaffPass;
            txtStaffNickName.Text = staff.StaffNickName;
            txtStaffDateCreated.Text = staff.StaffDateCreated.ToString();
            chkStaffIsAdmin.Checked = staff.StaffIsAdmin;
            txtDepartment.Text = staff.StaffDep;


        }
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //redirect to mainmenu
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnStaffCancel_Click(object sender, EventArgs e)
    {
        //redirect to list
        Response.Redirect("AdminList.aspx");
    }
}