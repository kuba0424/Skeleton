<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 190px; top: 86px; position: absolute" Text="Customer Login Page"></asp:Label>
        </div>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 70px; top: 274px; position: absolute" Text="Password:"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 70px; top: 219px; position: absolute" Text="Username:"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 180px; top: 219px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 179px; top: 274px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 164px; top: 370px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 264px; top: 370px; position: absolute; height: 26px;" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 220px; top: 444px; position: absolute"></asp:Label>
    </form>
</body>
</html>
