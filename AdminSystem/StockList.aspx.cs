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
        //if this is the first time the page has been displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStock();
        }
    }

    public void DisplayStock()
    {
        //create an instgance of the stock collection
        clsStockCollection Stock = new clsStockCollection();
        //set the data source to the lsit opf stock int he collection
        lstStockList.DataSource = Stock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "Id";
        //set the data field to display
        lstStockList.DataTextField = "ItemId";
        //bind the data to the list
        lstStockList.DataBind();
    }
}
