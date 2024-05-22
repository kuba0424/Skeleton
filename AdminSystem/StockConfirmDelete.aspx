<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 444px; top: 156px; position: absolute" Text="Yes" />
        </p>
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 709px; top: 155px; position: absolute" Text="No" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 464px; top: 81px; position: absolute" Text="Are you sure you want to delete this reord?"></asp:Label>
    </form>
</body>
</html>
