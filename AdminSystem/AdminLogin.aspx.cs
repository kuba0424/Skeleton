using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsStaffUser staffuser = new clsStaffUser();
        //create variable to store username and password
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;
        //create boolean variable to store the result of find user operation
        Boolean Found = false;
        //get the username entered by user
        Username = Convert.ToString(txtUsername.Text);
        //get password entered
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = staffuser.FindUser(Username, Password);
        //add session to capture username
        Session["staffuser"] = staffuser;

        //if username and/or password is empty
        if (txtUsername.Text == "")
        {
            //record error and make it visible
            lblError.Visible = true;
            lblError.Text = "Enter a Username";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Visible = true;
            lblError.Text = "Enter a Password";
        }
        //if found
        else if (Found == true)
        {
            Response.Redirect("AdminList.aspx");
        }
        else if (Found == false)
        {
            //record error
            lblError.Visible = true;
            lblError.Text = "Login details are incorrect. Please try again ";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}