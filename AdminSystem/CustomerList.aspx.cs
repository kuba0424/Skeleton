using System;
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
}