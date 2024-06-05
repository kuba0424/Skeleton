<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 618px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnAdminManage" runat="server" style="z-index: 1; left: 102px; top: 293px; position: absolute;" Text="Admin Management" OnClick="btnAdminManage_Click" />
        <p>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 414px; top: 45px; position: absolute; height: 18px; width: 298px; font-size: x-large; font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif; margin-top: 10px;" Text="Sprint Squad Main Menu"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Image ID="Image1" runat="server" Height="116px" ImageUrl="~/RunningMan/runningman.jpg" style="margin-left: 471px; margin-right: 53px" Width="154px" />
        <p>
        <asp:Button ID="btnStockManagement" runat="server" style="z-index: 1; left: 329px; top: 293px; position: absolute;" Text="Stock Management" OnClick="Button3_Click" />
        </p>
        <p>
        <asp:Button ID="btnCustomerM" runat="server" style="z-index: 1; left: 556px; top: 293px; position: absolute;" Text="Customer Management" OnClick="btnCustomerM_Click" />
        <asp:Button ID="btnOrderProcessing" runat="server" style="z-index: 1; left: 790px; top: 293px; position: absolute;" Text="Order Processing" OnClick="btnOrderProcessing_Click" />
        </p>
    </form>
</body>
</html>
