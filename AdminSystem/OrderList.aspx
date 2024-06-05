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
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; top:347px; position:absolute; left: 47px;" Text="Add" OnClick="Button1_Click1" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; top:347px; position:absolute; left: 137px;" Text="Edit" />
        <asp:ListBox ID="lstOrderList" runat="server" Height="290px" style="z-index: 1; left: 22px; top: 35px; position: absolute; margin-right: 6px;" Width="357px" OnSelectedIndexChanged="lstOrderList_SelectedIndexChanged"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; top:480px; position:absolute; left: 47px;"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; top:347px; position:absolute; left: 224px;" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Label ID="lblEnter" runat="server"  style="z-index: 1; top:405px; position:absolute; left: 56px;" Text="Enter an Address"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server"  style="z-index: 1; top:404px; position:absolute; left: 178px; width: 191px;" ></asp:TextBox>
        <asp:Button ID="btnApply" runat="server"  style="z-index: 1; top:435px; position:absolute; left: 72px;" Text="Apply Filter" OnClick="btnApply_Click" />
        <asp:Button ID="btnClear" runat="server"  style="z-index: 1; top:435px; position:absolute; left: 225px;" Text="Clear Filter" OnClick="btnClear_Click" />
        <asp:Button ID="btnMainMenu" runat="server" style="z-index: 1; top:529px; position:absolute; left: 104px;" Text="Return to Main Menu" OnClick="btnMainMenu_Click" />
    </form>
</body>
</html>
