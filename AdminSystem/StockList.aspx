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
            left: 84px;
            top: 467px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style2" OnClick="btnAdd_Click" Text="Add" />
        <asp:ListBox ID="lstStockList" runat="server" CssClass="auto-style1"></asp:ListBox>
    </form>
</body>
</html>
