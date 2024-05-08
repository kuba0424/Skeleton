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
        staff.StaffId = Convert.ToInt32(txtStaffId.Text);
        //capture the username
        staff.StaffUser = txtStaffUser.Text;
        //caputre password
        staff.StaffPass = txtStaffPass.Text;
        //capture the nickname
        staff.StaffNickName = txtStaffNickName.Text;
        //capture date added
        staff.StaffDateCreated = Convert.ToDateTime(DateTime.Now);
        //capture is Admin checkbox
        staff.StaffIsAdmin = chkStaffIsAdmin.Checked;
        //store the staff in the session object
        Session["staff"] = staff;

        //Navigate to the view page
        Response.Redirect("AdminViewer.aspx");

    }
}