<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstStaffList" runat="server" position="absolute" style="z-index: 1; left: 9px; top: 11px; position: absolute" Height="304px" Width="323px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 9px; top: 341px; position: absolute; " OnClick="btnAdd_Click" Text="Add" height="26px" width="55px"  />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 83px; top: 341px; position: absolute" OnClick="btnEdit_Click" Text="Edit" height="26px" width="55px" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 157px; top: 341px; position: absolute" OnClick="btnDelete_Click" Text="Delete" height="26px" width="55px" />
       
        <asp:Label ID="lblFilterNickname" runat="server" style="z-index: 1; left: 9px; top: 398px; position: absolute" Text="Enter a Nickname:"></asp:Label>
        <asp:TextBox ID="txtFilterNickname" runat="server" style="z-index: 1; left: 140px; top: 397px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" style="z-index: 1; top: 395px; position: absolute; right: 1446px;" OnClick="btnApplyFilter_Click" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 412px; top: 395px; position: absolute" OnClick="btnClearFilter_Click" Text="Clear Filter" height="26px" width="100px" />
        <asp:Label ID="lblError" runat="server"  style="z-index: 1; left: 9px; top: 445px; position: absolute" Text="lblError"></asp:Label>
        
    </form>
</body>
</html>
