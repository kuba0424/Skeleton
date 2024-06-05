<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessingLogin.aspx.cs" Inherits="OrderProcessingLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 533px; width: 694px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblLoginPage" runat="server" style="z-index; top: 61px; position:absolute; left: 44px;" Text="Order Processing Login Page"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" style="z-index; top: 134px; position:absolute; left: 84px; height: 19px;" Text="UserName"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index; top: 165px; position:absolute; left: 84px;" Text="Password"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index; top: 133px; position:absolute; left: 167px;" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index; top: 163px; position:absolute; left: 166px;" TextMode="Password" ></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index; top: 150px; position:absolute; left: 343px;" ForeColor="#FF3300"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" style="z-index; top: 207px; position:absolute; left: 104px;" Text="Login" OnClick="btnLogin_Click" />
        <asp:Button ID="BtnCancel" runat="server" style="z-index; top: 207px; position:absolute; left: 209px;" Text="Cancel" />
    </form>
</body>
</html>
