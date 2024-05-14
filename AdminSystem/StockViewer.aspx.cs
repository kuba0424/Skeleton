using System;
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
        //create an instance of clsStock
        clsStock Stock = new clsStock();
        //get data from the session object
        Stock = (clsStock)Session["Stock"];
       
        
        //display the item desc for this entry
        Response.Write(Stock.itemDescription);
        //display the item stock for this entry
        Response.Write(Stock.itemId);
        //repeated for the other data types...
        Response.Write(Stock.itemStock);
        Response.Write(Stock.itemSize);
        Response.Write(Stock.itemPrice);
        Response.Write(Stock.itemAvailable);
        Response.Write(Stock.itemDate);
    }
}