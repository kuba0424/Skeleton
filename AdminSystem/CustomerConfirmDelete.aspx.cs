﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //varible to store primary key value of the record to be deleted
    Int32 Customer_Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Customer to be deleted from the session object
        Customer_Id = Convert.ToInt32(Session["Customer_ID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the customer collection class
        clsCustomerCollection Customer = new clsCustomerCollection();
        //find the record to delete
        Customer.ThisCustomer.Find(Customer_Id);
        //delete the record
        Customer.Delete();
        //redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to main page
        Response.Redirect("CustomerList.aspx");
    }
}