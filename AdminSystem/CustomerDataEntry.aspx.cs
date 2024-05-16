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
        //capture the username
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;
        string Email = txtEmail.Text;
        string HomeAddress = txtHomeAddress.Text;
        string RegistrationDate = txtRegistrationDate.Text;
        string Active = lblActive.Text;
        //varible to sotre any error messages
        string Error = "";
        //validate the data
        Error = AnCustomer.Valid(Username, Password, Email, HomeAddress, RegistrationDate);
        if (Error == "")
        {
            // capture the username
            AnCustomer.Username = Username;
            AnCustomer.Email = Email;
            AnCustomer.Password = Password;
            AnCustomer.HomeAddress = HomeAddress;
            AnCustomer.RegistrationDate = DateTime.Now;
            //store the address in the session object
            Session["AnCustomer"] = AnCustomer;
            // navigate to the view page
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }
    protected void btnFind_Click(object send, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //creat a varible to sotre the primary key
        Int32 Customer_Id;
        //create a varible to store the result of the the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        Customer_Id = Convert.ToInt32(txtCustomerId.Text);
        //find the record
        Found = AnCustomer.Find(Customer_Id);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtUsername.Text = AnCustomer.Username;
            txtPassword.Text = AnCustomer.Password;
            txtEmail.Text = AnCustomer.Email;
            txtHomeAddress.Text = AnCustomer.HomeAddress;
            txtRegistrationDate.Text = AnCustomer.RegistrationDate.ToString();
            lblActive.Checked = AnCustomer.Active;

        }

    }
}