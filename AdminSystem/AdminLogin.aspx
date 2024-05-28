<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblUsername" runat="server" style="z-index; top: 134px; position:absolute; left: 84px;" Text="Username: "></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index; top: 176px; position:absolute; left: 84px;"  Text="Password: "></asp:Label>
        <asp:Label ID="lblLoginPageText" runat="server" style="z-index; top: 52px; position:absolute; left: 13px;"  Text="Admin Login Page"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index; top: 175px; position:absolute; left: 155px;" TextMode="Password" ></asp:TextBox>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index; top: 133px; position:absolute; left: 154px;" ></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index; top: 161px; position:absolute; left: 355px; bottom: 471px;"  Text="lblError" ForeColor="#FF3300"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" style="z-index; top: 231px; position:absolute; left: 155px;"  Text="Login" OnClick="btnLogin_Click" width="47" />
        <asp:Button ID="btnCancel" runat="server" style="z-index; top: 231px; position:absolute; left: 232px;"  Text="Cancel" height="26px" width="47px" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
