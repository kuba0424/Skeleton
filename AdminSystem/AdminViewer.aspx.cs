using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create new instance of clsStaff
        clsStaff staff = new clsStaff();
        //get data from session object
        staff = (clsStaff)Session["staff"];
        //dispay the id
        Response.Write(staff.StaffId);
        
        //display the username
        Response.Write(staff.StaffUser);

        //display the password
        Response.Write(staff.StaffPass);

        //display the nickname for this entry
        Response.Write(staff.StaffNickName);

        //display the date created
        Response.Write(staff.StaffDateCreated);

        //display is admin
        Response.Write(staff.StaffIsAdmin);

     
    }
}