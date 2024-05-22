using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the priomary key of the valued record to be deleted
    Int32 Id;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the numver of the address to be deleted from the session object
        Id = Convert.ToInt32(Session["Id"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the Stock collection class
        clsStockCollection Stock = new clsStockCollection();
        //find the record to delete
        Stock.ThisStock.Find(Id);
        Stock.Delete();
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}