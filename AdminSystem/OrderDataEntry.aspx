<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 322px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Order ID" width="150px"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 219px; top: 34px; position: absolute" width="257px"></asp:TextBox>
        <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 10px; top: 63px; position: absolute" Text="Customer Address" width="150px"></asp:Label>
        <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; left: 219px; top: 61px; position: absolute" width="257px"></asp:TextBox>
        <asp:CheckBox ID="chkDispatched" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" style="z-index: 1; left: 223px; top: 223px; position: absolute; height: 21px" Text="Order Dispatched" width="257px" />
        <asp:Label ID="lblPaymentInformation" runat="server" style="z-index: 1; left: 10px; top: 144px; position: absolute; right: 1404px" Text="Payment Information"></asp:Label>
        <asp:TextBox ID="txtPaymentInformation" runat="server" style="z-index: 1; left: 219px; top: 141px; position: absolute; width: 257px"></asp:TextBox>
        <asp:Label ID="lblDispatchDate" runat="server" style="z-index: 1; left: 10px; top: 185px; position: absolute" Text="Dispatch Date" width="150px"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 219px; top: 183px; position: absolute" width="257px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 323px; top: 255px; position: absolute" width="257px"></asp:Label>
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 408px; top: 287px; position: absolute; width: 65px" Text="Cancel" />
            <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 532px; top: 31px; position: absolute" Text="Find" />
        </p>
        <asp:Label ID="lblTotalPrice" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute; right: 1439px" Text="Total Price" width="150px"></asp:Label>
        <asp:TextBox ID="txtTotalPrice" runat="server" style="z-index: 1; left: 219px; top: 91px; position: absolute" width="257px"></asp:TextBox>
        <p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 230px; top: 287px; position: absolute; width: 65px" Text="OK" />
        </p>
    </form>
</body>
</html>
