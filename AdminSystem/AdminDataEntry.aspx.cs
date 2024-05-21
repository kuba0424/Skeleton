using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

   

    protected void btnStaffOk_Click(object sender, EventArgs e)
    {
        //create new instance of clsStaff
        clsStaff staff = new clsStaff();
        //capture staff id
        //staff.StaffId = Convert.ToInt32(txtStaffId.Text);
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
        //variable to store error msg
        string Error = "";
        //validate data
        Error = staff.Valid(StaffUser, StaffPass, StaffNickName, StaffDateCreated);
        if (Error == "")
        {
            //capture data
            staff.StaffUser = StaffUser;
            staff.StaffPass = StaffPass;
            staff.StaffDateCreated = Convert.ToDateTime(StaffDateCreated);
            staff.StaffNickName = StaffNickName;
            staff.StaffIsAdmin = chkStaffIsAdmin.Checked;
            //create new instance of staff collection
            clsStaffCollection StaffList = new clsStaffCollection();
            //set the thisstaff property
            StaffList.ThisStaff =staff;
            StaffList.Add();
            //redirect to the list page
            Response.Redirect("AdminList.aspx");

        }
        else
        {
            //display error msg
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


        }
    }
}