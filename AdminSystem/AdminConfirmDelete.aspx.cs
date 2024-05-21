using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be deleted from the sssion object
        StaffId = Convert.ToInt32(Session["StaffId"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create new instance of the staffcollection class
        clsStaffCollection staffcllect = new clsStaffCollection();
        //find record to delete
        staffcllect.Delete();
        //redirect to main page
        Response.Redirect("AdminList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminList.aspx");
    }
}