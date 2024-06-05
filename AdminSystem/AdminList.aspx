<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
      /*  #banner#{
            
            background-color : blue;
            color: white;
            padding: 20px;
            text-align:center;
          <div id="banner">//div would be inbetween head and body if it worked
    <p>Welcome to Sprint Squad!</p>
</div>
        }*/
    </style>
    <title></title>
   </head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstStaffList" runat="server" position="absolute" style="z-index: 1; left: 10px; top: 114px; position: absolute" Height="304px" Width="323px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 10px; top: 455px; position: absolute; " OnClick="btnAdd_Click" Text="Add" height="26px" width="55px"  />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 88px; top: 455px; position: absolute" OnClick="btnEdit_Click" Text="Edit" height="26px" width="55px" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 162px; top: 455px; position: absolute" OnClick="btnDelete_Click" Text="Delete" height="26px" width="55px" />
       
        <asp:Label ID="lblFilterNickname" runat="server" style="z-index: 1; left: 10px; top: 508px; position: absolute; width: 137px;" Text="Enter a Nickname:"></asp:Label>
        <asp:TextBox ID="txtFilterNickname" runat="server" style="z-index: 1; left: 155px; top: 507px; position: absolute;"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" style="z-index: 1; top: 507px; position: absolute; left: 302px;" OnClick="btnApplyFilter_Click" Text="Apply Filter" height="22px" width="128px" />
        <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 452px; top: 507px; position: absolute; " OnClick="btnClearFilter_Click" Text="Clear Filter" height="22px" width="128px" />
        
        <asp:Button ID="btnReturn" runat="server"  style="z-index: 1; left: 607px; top: 507px; position: absolute; width: 133px;" Text="Return to MainMenu" OnClick="btnReturn_Click" height="22px" />
        
        
        <asp:Label ID="lblError" runat="server"  style="z-index: 1; left: 10px; top: 544px; position: absolute; height: 19px; width: 491px;" Text="lblError" Visible="False"></asp:Label>
        
        
        
    </form>
</body>
</html>
