﻿using System;
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

    protected void txtStockId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock Stock = new clsStock();

        //capture the stock id

        string itemDescription = txtItemDesc.Text;
        string itemDate = txtItemDate.Text;
        string Error = "";
        string itemId = txtStockId.Text;
        string itemStock = txtItemStock.Text;
        string itemSize = txtItemSize.Text;
        string itemPrice = txtItemPrice.Text;
        string itemAvailable = txtItemAvailable.Text;

        Error = Stock.Valid(itemId, itemStock, itemSize, itemPrice, itemDescription, itemAvailable, itemDate);
        if (Error == "")
        {
            //capture the item description
            Stock.itemDescription = itemDescription;
            Stock.itemDate = Convert.ToDateTime(itemDate);
            Session["Stock"] = Stock;
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            //display error messasge
            lblError.Text = Error;
        }
    }





    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsStock Stock = new clsStock();
        //create a variable to store the primary key
        Int32 Id;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        Id = Convert.ToInt32(txtId.Text);
        //find the record
        Found = Stock.Find(Id);
        //if found
        if (Found == true)
        {
            //display the vakyes if the properties in the form
            txtStockId.Text = Stock.itemId.ToString();
            txtItemSize.Text = Stock.itemSize.ToString();
            txtItemStock.Text = Stock.itemStock.ToString();
            txtItemPrice.Text = Stock.itemPrice.ToString();
            txtItemAvailable.Text = Stock.itemAvailable.ToString();
            txtItemDate.Text = Stock.itemDate.ToString();
            txtItemDesc.Text = Stock.itemDescription;
            chkActive.Checked = Stock.Active;

        }
    }
}
