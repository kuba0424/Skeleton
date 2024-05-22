<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstStaffList" runat="server" Height="304px" Width="323px"></asp:ListBox>
        <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblFilterNickname" runat="server" Text="Enter a Nickname"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtFilterNickname" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter" />
        <br />
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
    </form>
</body>
</html>
