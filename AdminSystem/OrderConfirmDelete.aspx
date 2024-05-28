<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblconfirm" runat="server" style="z-index: 1; top:140px; position:absolute; left: 199px;" Text="Are you sure you want to delete this record?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; top:195px; position:absolute; left: 238px;" Text="Yes" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; top:193px; position:absolute; left: 357px;" Text="No" OnClick="btnNo_Click" />
    </form>
</body>
</html>
