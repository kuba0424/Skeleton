using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //if this the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
        //create a new instance of clsCustomerUser
        clsCustomerUser AnUser = new clsCustomerUser();
        //get data from the session objec
        AnUser = (clsCustomerUser)Session["AnUser"];
        //display the user name
        Response.Write("Logged in as: " + AnUser.UserName);
    }
    void DisplayCustomers()
    {
        //create an instance of the Customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data source to list of customers in the collection
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of thhe primary key 
        lstCustomerList.DataValueField = "Customer_Id";
        //set the data field to display
        lstCustomerList.DataTextField = "Username";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void lstCustomerList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["Customer_Id"] = -1;
        //redirect tot he data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // varible to stored the primary key value of the record to be edited
        Int32 Customer_Id;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            Customer_Id = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["Customer_Id"] = Customer_Id;
            //redirect to the edit page
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else     //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //varible to store the primary key value of the record to be delete
        Int32 Customer_Id;
        //if a record has been selected from the lsit
        if(lstCustomerList.SelectedIndex != -1)
        {
            //get the primay key value of the record delete
            Customer_Id = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["Customer_Id"] = Customer_Id;
            //redirect to the delete page
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the Customer object
        clsCustomerCollection AnCustomer = new clsCustomerCollection();
        //retrieve the value of Home address from the presentation layer
        AnCustomer.ReportByHomeAddress(txtboxEtrHomeAddress.Text);
        //set the data source to the list of customers in the collection
        lstCustomerList.DataSource = AnCustomer.CustomerList;
        //seet the name if the primary key
        lstCustomerList.DataValueField = "Customer_Id";
        //set the name of the field to display
        lstCustomerList.DataTextField = "HomeAddress";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the Customer object
        clsCustomerCollection AnCustomer = new clsCustomerCollection();
        //set an empty string
        AnCustomer.ReportByHomeAddress("");
        //clear any exsiting filter to tidy up the interface
        txtboxEtrHomeAddress.Text = "";
        //set the data source to the list of customers in the collection
        lstCustomerList.DataSource = AnCustomer.CustomerList;
        //seet the name if the primary key
        lstCustomerList.DataValueField = "Customer_Id";
        //set the name of the field to display
        lstCustomerList.DataTextField = "HomeAddress";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnReturnMM_Click(object sender, EventArgs e)
    {
        //redirect back to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}