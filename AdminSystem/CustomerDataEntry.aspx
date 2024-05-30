<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="Active">
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtCustomerId" runat="server" OnTextChanged="txtCustomerId_TextChanged" style="z-index: 1; left: 126px; top: 14px; position: absolute" width="128px"></asp:TextBox>
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 4px; top: 31px; position: absolute; height: 24px" Text="CustomerId" width="97px"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFind" runat="server" Text="Find" Width="52px" OnClick="btnFind_Click1" />
        </div>
        <p>
            <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 4px; top: 68px; position: absolute; width: 97px" Text="Username"></asp:Label>
        </p>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 126px; top: 66px; position: absolute" width="128px"></asp:TextBox>
        <p>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 4px; top: 110px; position: absolute" Text="Password" width="97px"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" OnTextChanged="txtPassword_TextChanged" style="z-index: 1; left: 126px; top: 110px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 4px; top: 147px; position: absolute" Text="Email" width="97px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 126px; top: 144px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblHomeAddress" runat="server" style="z-index: 1; left: 4px; top: 185px; position: absolute; height: 19px" Text="HomeAddress" width="97px"></asp:Label>
        <asp:TextBox ID="txtHomeAddress" runat="server" style="z-index: 1; left: 126px; top: 185px; position: absolute" width="128px"></asp:TextBox>
        <p>
            <asp:Label ID="lblRegistrationDate" runat="server" style="z-index: 1; left: 4px; top: 218px; position: absolute" Text="Resitration Date"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtRegistrationDate" runat="server" OnTextChanged="txtRegistration_TextChanged" style="z-index: 1; left: 126px; top: 225px; position: absolute"></asp:TextBox>
        </p>
        <asp:CheckBox ID="lblActive" runat="server" style="z-index: 1; left: 136px; top: 272px; position: absolute" Text="Active" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 108px; top: 344px; position: absolute; bottom: 51px;" Text="OK" width="52px" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 22px; top: 296px; position: absolute"></asp:Label>
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 220px; top: 344px; position: absolute" Text="Cancel" width="52px" OnClick="btnCancel_Click" />
        <asp:Button ID="bnMm" runat="server" OnClick="bnMm_Click" style="margin-left: 329px" Text="Return to Main Menu " />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
