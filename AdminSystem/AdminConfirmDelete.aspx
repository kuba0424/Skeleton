<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <asp:Label ID="lblDelete" runat="server"  style="z-index: 1; left: 24px; top: 44px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
            <asp:Button ID="btnYes" runat="server"  style="z-index: 1; left: 24px; top: 97px; position: absolute" OnClick="btnYes_Click" Text="Yes" />
            <asp:Button ID="btnNo" runat="server"  style="z-index: 1; left: 103px; top: 97px; position: absolute" OnClick="btnNo_Click" Text="No" height="26px" width="37px" />    
    </form>
</body>
</html>
