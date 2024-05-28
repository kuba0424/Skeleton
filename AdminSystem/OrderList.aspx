<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 13px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; top:347px; position:absolute; left: 26px;" Text="Add" OnClick="Button1_Click1" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; top:347px; position:absolute; left: 115px;" Text="Edit" />
        <asp:ListBox ID="lstOrderList" runat="server" Height="290px" style="z-index: 1; left: 22px; top: 35px; position: absolute; margin-right: 6px;" Width="357px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; top:394px; position:absolute; left: 69px;" Text="Label"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; top:347px; position:absolute; left: 199px;" Text="Delete" OnClick="btnDelete_Click" />
    </form>
</body>
</html>
