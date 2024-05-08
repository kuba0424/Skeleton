<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffUser" runat="server" style="z-index: 1; left: 27px; top: 165px; position: absolute" Text="Username:" width="85px"></asp:Label>
        <asp:Label ID="lblStaffPass" runat="server" style="z-index: 1; left: 27px; top: 207px; position: absolute" Text="Password:" width="85px"></asp:Label>
        <asp:TextBox ID="txtStaffPass" runat="server" style="z-index: 1; left: 123px; top: 208px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCreateStaff" runat="server" style="z-index: 1; left: 23px; top: 56px; position: absolute" Text="Create Staff" width="85px"></asp:Label>
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 27px; top: 122px; position: absolute" Text="Staff ID:" width="85px"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 123px; top: 124px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDateCreated" runat="server" style="z-index: 1; left: 27px; top: 303px; position: absolute" Text="Date Created:"></asp:Label>
        <asp:TextBox ID="txtStaffDateCreated" runat="server" style="z-index: 1; left: 123px; top: 300px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffNickName" runat="server" style="z-index: 1; left: 27px; top: 256px; position: absolute" Text="Nickname:" width="85px"></asp:Label>
        <asp:TextBox ID="txtStaffNickName" runat="server" style="z-index: 1; left: 123px; top: 254px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkStaffIsAdmin" runat="server" style="z-index: 1; left: 146px; top: 340px; position: absolute" Text="Is Admin?" />
        <asp:Label ID="lblStaffError" runat="server" style="z-index: 1; left: 27px; top: 381px; position: absolute" width="85px"></asp:Label>
        <asp:Button ID="btnStaffOk" runat="server" style="z-index: 1; left: 39px; top: 423px; position: absolute" Text="Ok" OnClick="btnStaffOk_Click" height="26px" width="60px" />
        <asp:Button ID="btnStaffCancel" runat="server" style="z-index: 1; left: 157px; top: 422px; position: absolute" Text="Cancel" />
        <asp:TextBox ID="txtStaffUser" runat="server" style="z-index: 1; left: 123px; top: 167px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
