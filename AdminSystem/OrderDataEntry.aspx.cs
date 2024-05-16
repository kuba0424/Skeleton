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
        //capture the customer address
        AnOrder.CustomerAddress = txtCustomerAddress.Text;
        AnOrder.TotalPrice = Convert.ToDouble(txtTotalPrice.Text);
        AnOrder.OrderDispatched = chkDispatched.Checked;
        AnOrder.PaymentInformation = Convert.ToInt32(txtPaymentInformation.Text);
        AnOrder.DispatchDate = Convert.ToDateTime(DateTime.Now);
        //Store the address in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the view page
        Response.Redirect("OrderViewer.aspx");
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
            txtDispatchDate.Text = AnOrder.DispatchDate.ToString();
            chkDispatched.Checked = AnOrder.OrderDispatched;
        }
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}