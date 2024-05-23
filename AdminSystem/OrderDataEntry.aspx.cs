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
    protected void Page_Load(object sender, EventArgs e)
    {

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
            AnOrder.DispatchDate = Convert.ToDateTime(DispatchDate);
            AnOrder.PaymentInformation = Convert.ToInt32(PaymentInformation);
            AnOrder.CustomerAddress = CustomerAddress;
            AnOrder.TotalPrice = Convert.ToInt32(TotalPrice);
            AnOrder.OrderDispatched = chkDispatched.Checked;
            //create a new instance of the order collection
            clsOrderCollection OrderList = new clsOrderCollection();
            //set the ThisOrder property
            OrderList.ThisOrder = AnOrder;
            //add the new record
            OrderList.Add();
            //redirect back to the list page
            Response.Redirect("OrderList.aspx");
        }
        else
        {
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
}