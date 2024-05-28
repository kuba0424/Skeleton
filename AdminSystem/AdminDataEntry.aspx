﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
      
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
        <asp:CheckBox ID="chkStaffIsAdmin" runat="server" style="z-index: 1; left: 144px; top: 387px; position: absolute" Text="Is Admin?" />
        <asp:Label ID="lblDepartment" runat="server" style="z-index: 1; left: 27px; top: 345px; position: absolute; width: 93px;" Text="Department:"></asp:Label>
        <asp:TextBox ID="txtDepartment" runat="server" style="z-index: 1; left: 123px; top: 347px; position: absolute; width: 128px;" height="22px"></asp:TextBox>
        <asp:Label ID="lblStaffError" runat="server" style="z-index: 1; left: 22px; top: 419px; position: absolute; width: 212px;"></asp:Label>
        <asp:Button ID="btnStaffOk" runat="server" style="z-index: 1; left: 31px; top: 478px; position: absolute" Text="Ok" OnClick="btnStaffOk_Click" height="26px" width="60px" />
        <asp:Button ID="btnStaffCancel" runat="server" style="z-index: 1; left: 135px; top: 478px; position: absolute" Text="Cancel" height="26px" width="60px" />
        <asp:TextBox ID="txtStaffUser" runat="server" style="z-index: 1; left: 123px; top: 167px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" height="26px" OnClick="btnFind_Click" style="z-index: 1; left: 296px; top: 121px; position: absolute" Text="Find" width="60px" />
        <asp:Button ID="btnReturn" runat="server"  style="z-index: 1; left: 232px; top: 478px; position: absolute" Text="Return to main menu" OnClick="btnReturn_Click" />
        
    </form>
</body>
</html>
