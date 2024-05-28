<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 82px;
            top: 35px;
            position: absolute;
            height: 409px;
            width: 460px;
        }
        .auto-style2 {
            z-index: 1;
            left: 85px;
            top: 466px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style2" OnClick="btnAdd_Click" Text="Add" />
        <asp:ListBox ID="lstStockList" runat="server" CssClass="auto-style1" OnSelectedIndexChanged="lstStockList_SelectedIndexChanged"></asp:ListBox>
        <asp:Button ID="btnEdit" runat="server" OnClick="lblError_Click" style="z-index: 1; left: 146px; top: 467px; position: absolute" Text="Edit" />
        <asp:Button ID="lblError" runat="server" style="z-index: 1; left: 89px; top: 684px; position: absolute" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 215px; top: 466px; position: absolute" Text="Delete" />
        <asp:Button ID="btnApplyFilter" runat="server" style="z-index: 1; left: 91px; top: 597px; position: absolute" Text="Apply Filter" OnClick="btnApplyFilter_Click" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 231px; top: 596px; position: absolute" Text="Clear Filter" />
        <asp:TextBox ID="txtItemDesc" runat="server" style="z-index: 1; left: 235px; top: 544px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 60px; top: 544px; position: absolute" Text="Enter Item Description"></asp:Label>
    </form>
</body>
</html>
