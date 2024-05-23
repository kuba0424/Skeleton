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
        <asp:ListBox ID="lstOrderList" runat="server" Height="290px" style="z-index: 1; left: 9px; top: 31px; position: absolute; margin-right: 6px;" Width="357px"></asp:ListBox>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; top:346px; position:absolute; left: 11px;" Text="Add" OnClick="Button1_Click1" />
    </form>
</body>
</html>
