<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="Admin.css" rel="stylesheet" type="text/css" />
</head>
    <div class="banner">
    <p><strong>Welcome to sprint squad!</strong></p>
        <p><strong>Admin Login</strong></p>
</div>
   
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblUsername" runat="server" style="z-index; top: 185px; position:absolute; left: 74px; font-weight: 700;" Text="Username: "></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index; top: 225px; position:absolute; left: 74px; font-weight: 700;"  Text="Password: "></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index; top: 224px; position:absolute; left: 153px;" TextMode="Password" ></asp:TextBox>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index; top: 184px; position:absolute; left: 153px;" ></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index; top: 215px; position:absolute; left: 340px; bottom: 417px;"  Text="lblError" ForeColor="#FF3300" Visible="False"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" style="z-index; top: 271px; position:absolute; left: 153px; font-weight: 700;"  Text="Login" OnClick="btnLogin_Click" width="59px" height="26px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index; top: 271px; position:absolute; left: 232px; width: 59px; font-weight: 700;"  Text="Cancel" height="26px" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
