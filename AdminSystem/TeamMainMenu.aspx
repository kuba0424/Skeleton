<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 238px; top: 109px; position: absolute;" Text="Sprint Squad Main Menu"></asp:Label>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 732px; top: 189px; position: absolute;" Text="Button" />
        <asp:Button ID="btnCustomerM" runat="server" style="z-index: 1; left: 462px; top: 188px; position: absolute;" Text="Customer Management" OnClick="btnCustomerM_Click" />
        <asp:Button ID="btnAdminManage" runat="server" style="z-index: 1; left: 19px; top: 188px; position: absolute;" Text="Admin Management" OnClick="btnAdminManage_Click" />
        <p>
        <asp:Button ID="btnStockManagement" runat="server" style="z-index: 1; left: 242px; top: 188px; position: absolute;" Text="Stock Management" OnClick="Button3_Click" />
        </p>
    </form>
</body>
</html>
