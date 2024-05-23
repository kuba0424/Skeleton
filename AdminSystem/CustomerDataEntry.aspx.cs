using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 Customer_Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of address to be processed
        Customer_Id = Convert.ToInt32(Session["Customer_Id"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (Customer_Id != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }

    private void DisplayCustomer()
    {
        //create an instance of the Customer book 
        clsCustomerCollection Customer = new clsCustomerCollection();
        //find the record to update
        Customer.ThisCustomer.Find(Customer_Id);
        //display the data for the record
        txtCustomerId.Text = Customer.ThisCustomer.Customer_Id.ToString();
        txtUsername.Text = Customer.ThisCustomer.Username.ToString();
        txtPassword.Text = Customer.ThisCustomer.Password.ToString();
        txtEmail.Text = Customer.ThisCustomer.Email.ToString();
        txtHomeAddress.Text = Customer.ThisCustomer.HomeAddress.ToString();
        txtRegistrationDate.Text = Customer.ThisCustomer.RegistrationDate.ToString();
        lblActive.Checked = Customer.ThisCustomer.Active;
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
            //capture the CustomerId
            AnCustomer.Customer_Id = Customer_Id;
            // capture the username
            AnCustomer.Username = Username;
            AnCustomer.Email = Email;
            AnCustomer.Password = Password;
            AnCustomer.HomeAddress = HomeAddress;
            AnCustomer.RegistrationDate = Convert.ToDateTime(RegistrationDate);
            //capture active
            AnCustomer.Active = lblActive.Checked;
            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
           if (Customer_Id == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(Customer_Id);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //update the record
                CustomerList.Update();
            }
            // navigate to the list page
            Response.Redirect("CustomerList.aspx");
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

    protected void btnFind_Click1(object sender, EventArgs e)
    {
        //create an instance of the Customer class
        clsCustomer AnCustomer = new clsCustomer();
        //create a varible to store the primary key
        Int32 Customer_Id;
        //create a varible to store the result of the find operation
        Boolean Found = false;
        //get primary key entered by user
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