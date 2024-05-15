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

    protected void txtStockId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of clsStock
        clsStock Stock = new clsStock();


        //capture the item desc
        Stock.itemDescription = txtItemDesc.Text;
        //capture the stock id
        Stock.itemId = Convert.ToInt32(txtStockId.Text);
        //capture the rest of the data types...
        Stock.Id = Convert.ToInt32(txtId.Text);
        Stock.itemStock = Convert.ToInt32(txtItemStock.Text);
        Stock.itemSize = Convert.ToDouble(txtItemSize.Text);
        Stock.itemPrice = Convert.ToDouble(txtItemPrice.Text);
        Stock.itemAvailable = Convert.ToBoolean(txtItemAvailable.Text);
        Stock.itemDate = Convert.ToDateTime(txtItemDate.Text);
        Stock.Active = chkActive.Checked;
        
        
        //store the desc in the session object
        Session["Stock"]= Stock;
        //navigate to the view page as a click response
        Response.Redirect("StockViewer.aspx");
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
