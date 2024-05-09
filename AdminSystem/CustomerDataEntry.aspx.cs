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

    protected void txtCustomerId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtPassword_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtRegistration_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
            // capture the username
            AnCustomer.Username = txtUsername.Text;
                AnCustomer.Email = txtEmail.Text;
           AnCustomer.Password = txtPassword.Text;
        AnCustomer.HomeAddress = txtHomeAddress.Text;
        AnCustomer.RegistrationDate = DateTime.Now;
        //store the address in the session object
        Session ["AnCustomer"] = AnCustomer;
        // navigate to the view page
        Response.Redirect("CustomerViewer.aspx");

    }
}