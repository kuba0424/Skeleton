using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP;
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

        //create a new instance of the clsStockUser
    //    clsStockUser User = new clsStockUser();
        //get data from the session object
    //    User = (clsStockUser)Session["User"];
        //display the username
    //    Response.Write("Logged in as: " + User.Username);
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
        lstStockList.DataTextField = "itemDescription";
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

    protected void lblError_Click(object sender, EventArgs e) //EDIT CLICK
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

    protected void lstStockList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }



    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the stock object
        clsStockCollection Stock = new clsStockCollection();
        //retrieve the value of the item description from the presentation layer
        Stock.ReportByItemDescription(txtItemDesc.Text);
        //set the data source to the list of the stock in the collection
        lstStockList.DataSource = Stock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "Id";
        //set the name of the field to display
        lstStockList.DataTextField = "itemDescription";
        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e) //Void
    {
        /*//create an instance of the stock object
        clsStockCollection Stock = new clsStockCollection();
        //set an empty string
        Stock.ReportByItemDescription("");
        //clear up any existing filter to tidy up the interface
        txtItemDesc.Text = "";
        //set the source of the list of stock in the collection
        lstStockList.DataSource= Stock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField= "Id";
        //set the name of the field to display
        lstStockList.DataTextField = "Item Description";
        //bind the data to the list
        lstStockList.DataBind();*/
    }

    protected void Button1_Click(object sender, EventArgs e) //This is the btnClearFilter...
    {
        //create an instance of the stock object
        clsStockCollection Stock = new clsStockCollection();
        //set an empty string
        Stock.ReportByItemDescription("");
        //clear up any existing filter to tidy up the interface
        txtItemDesc.Text = "";
        //set the source of the list of stock in the collection
        lstStockList.DataSource = Stock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "Id";
        //set the name of the field to display
        lstStockList.DataTextField = "itemDescription";
        //bind the data to the list
        lstStockList.DataBind();
    }



    protected void Button1_Click1(object sender, EventArgs e) //main menu button
    {
        //rediret back to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}
