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
}