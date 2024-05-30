using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdminManage_Click(object sender, EventArgs e)
    {
        //redirect to the admin manage login page
        Response.Redirect("AdminLogin.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e) //StockManagement button !!
    {
        //redirect to the stock management login page
        Response.Redirect("StockLogin.aspx");
    }

    protected void btnCustomerM_Click(object sender, EventArgs e)
    {
        //redirect to the Customer management login page
        Response.Redirect("CustomerLogin.aspx");
    }
}