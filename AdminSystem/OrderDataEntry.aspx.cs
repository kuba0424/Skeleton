using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            if (OrderId != -1)
            {
                DisplayOrder();
            }
        }
    }

    void DisplayOrder()
    {
        //create an instance of the address book
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record to update
        OrderBook.ThisOrder.Find(OrderId);
        //display the data for the record
        txtOrderID.Text = OrderBook.ThisOrder.OrderID.ToString();
        txtCustomerAddress.Text = OrderBook.ThisOrder.CustomerAddress.ToString();
        txtDispatchDate.Text = OrderBook.ThisOrder.DispatchDate.ToString();
        txtPaymentInformation.Text = OrderBook.ThisOrder.PaymentInformation.ToString();
        txtTotalPrice.Text = OrderBook.ThisOrder.TotalPrice.ToString();
        chkDispatched.Checked = OrderBook.ThisOrder.OrderDispatched;

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        string DispatchDate = txtDispatchDate.Text;
        string PaymentInformation = txtPaymentInformation.Text;
        string CustomerAddress = txtCustomerAddress.Text;
        string TotalPrice = txtTotalPrice.Text;
        string OrderDispatched = chkDispatched.Text;
        string Error = "";
        Error = AnOrder.Valid(DispatchDate, PaymentInformation, CustomerAddress, TotalPrice);
        if (Error == "")
        {
            AnOrder.OrderID = OrderId;
            AnOrder.DispatchDate = Convert.ToDateTime(DispatchDate);
            AnOrder.PaymentInformation = Convert.ToInt32(PaymentInformation);
            AnOrder.CustomerAddress = CustomerAddress;
            AnOrder.TotalPrice = Convert.ToInt32(TotalPrice);
            AnOrder.OrderDispatched = chkDispatched.Checked;
            //create a new instance of the order collection
            clsOrderCollection OrderList = new clsOrderCollection();
            
            if (OrderId == -1)
            {
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderId);
                //set the thisorder property
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.update();
            }
            //redirect back to the list page
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create an instance of the order class
        clsOrder AnOrder = new clsOrder();
        //create a variable to store the primary key
        Int32 OrderId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderId = Convert.ToInt32(txtOrderID.Text);
        //find the record
        Found = AnOrder.Find(OrderId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerAddress.Text = AnOrder.CustomerAddress;
            txtTotalPrice.Text = AnOrder.TotalPrice.ToString();
            txtPaymentInformation.Text = AnOrder.PaymentInformation.ToString();
            chkDispatched.Checked = AnOrder.OrderDispatched;
            txtDispatchDate.Text = AnOrder.DispatchDate.ToString();
            chkDispatched.Checked = AnOrder.OrderDispatched;
        }
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }
}