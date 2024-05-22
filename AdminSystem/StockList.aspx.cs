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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["Id"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //ariablve to store the primary key value of the record to be edited
        Int32 Id;
        //if a rtecord has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            Id = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["Id"] = Id;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            //if no record has been selected
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void lblError_Click(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 Id;
        //if the record has been selected from the list
        if (lstStockList.SelectedIndex != 1)
        {
            //get the primary key value of the record delete
            Id = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session objct
            Session["Id"] = Id;
            //redirect to the delete page
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            //if no record has been selected

            //display an error message
            lblError.Text = "please select a record from the list to delete!";
        }
    }
}
