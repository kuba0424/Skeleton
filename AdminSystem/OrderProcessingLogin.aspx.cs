using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderProcessingLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the stock user class
        clsCustomerUser User = new clsCustomerUser();
        //create the variables to store the username and password
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;
        //create a variable to store the result of the find user operation
        Boolean Found = false;
        //get the username entered by the user
        Username = Convert.ToString(txtUsername.Text);
        //get the password entered by the user
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = User.FindUser(Username, Password);
        //add a session to capture the user name
        Session["User"] = User;
        //if username and or password empty
        if (txtUsername.Text == "")
        {
            //record the error
            lblError.Text = "Enter a username ";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a password ";
            ;
        }
        //if found
        else if (Found == true)
        {
            //redirect to the list page
            Response.Redirect("OrderList.aspx");
        }
        else if (Found == false)
        {
            //record the error
            lblError.Text = "Login details are incorrect. Please try again ";
        }
    }
}
