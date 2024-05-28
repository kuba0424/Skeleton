using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page

  
{   
    //variavle to store the primary key with page level scope
    Int32 Id;


    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        Id = Convert.ToInt32(Session["Id"]);
        if (IsPostBack == false)
        {
            //if this is not thge new record
            if (Id != -1)
            {
                //display the current data for the record
                DisplayId();
                {

                }
            }
        }
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
        string itemId = txtStockId.Text;
        string itemStock = txtItemStock.Text;
        string itemSize = txtItemSize.Text;
        string itemPrice = txtItemPrice.Text;
        string itemAvailable = txtItemAvailable.Text;
        string Error = "";

        Error = Stock.Valid(itemDescription,itemDate);
        if (Error == "")
        {
            //capture the item description
            Stock.Id = Id;
            Stock.itemDescription = itemDescription;
            Stock.itemDate = Convert.ToDateTime(itemDate);
            //capture the itemId
            Stock.itemId = Convert.ToInt32(itemId);
            Stock.itemStock = Convert.ToInt32(itemStock);
            Stock.itemPrice = Convert.ToDouble(itemPrice);
            Stock.itemSize = Convert.ToDouble(itemSize);
            Stock.itemAvailable = Convert.ToBoolean(itemAvailable);
            Stock.Active = chkActive.Checked;
            //create a new instance of the Stock Collection
            clsStockCollection StockList = new clsStockCollection();
            //set the ThisStock property
            StockList.ThisStock = Stock;
            //add the new record
            StockList.Add();
            //redirect back to the lsit page
            Response.Redirect("StockList.aspx");
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

    void DisplayId()
    {
        //create an instance of the id book
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to update
        StockBook.ThisStock.Find(Id);
        //display the data for the record
        txtStockId.Text = StockBook.ThisStock.itemId.ToString();
        txtItemSize.Text = StockBook.ThisStock.itemSize.ToString();
        txtItemStock.Text = StockBook.ThisStock.itemStock.ToString();
        txtItemPrice.Text = StockBook.ThisStock.itemPrice.ToString();
        txtItemAvailable.Text = StockBook.ThisStock.itemAvailable.ToString();
        txtItemDate.Text = StockBook.ThisStock.itemDate.ToString();
        txtItemDesc.Text = StockBook.ThisStock.itemDescription;
        chkActive.Checked = StockBook.ThisStock.Active;
    }



    protected void Button1_Click(object sender, EventArgs e) //main menu button
    {
        //redirect back to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}
