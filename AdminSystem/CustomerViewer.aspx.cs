﻿using System;
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
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new ClassLibrary.clsCustomer();
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["Ancustomer"];
        //display the usernnamer for the entry
        Response.Write(AnCustomer.Username);
        Response.Write(AnCustomer.Password);
        Response.Write(AnCustomer.Email);
        Response.Write(AnCustomer.HomeAddress);
        Response.Write(AnCustomer.RegistrationDate);



    }
}