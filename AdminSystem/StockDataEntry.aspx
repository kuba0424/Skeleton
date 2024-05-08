<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 16px;
            top: 107px;
            position: absolute;
            height: 18px;
        }
        .auto-style2 {
            z-index: 1;
            left: 16px;
            top: 174px;
            position: absolute;
            right: 1137px;
        }
        .auto-style3 {
            z-index: 1;
            left: 16px;
            top: 246px;
            position: absolute;
        }
        .auto-style4 {
            z-index: 1;
            left: 16px;
            top: 313px;
            position: absolute;
            width: 111px;
            bottom: 354px;
        }
        .auto-style5 {
            z-index: 1;
            left: 16px;
            top: 386px;
            position: absolute;
        }
        .auto-style7 {
            z-index: 1;
            left: 16px;
            top: 472px;
            position: absolute;
        }
        .auto-style8 {
            z-index: 1;
            left: 171px;
            top: 104px;
            position: absolute;
        }
        .auto-style9 {
            z-index: 1;
            left: 168px;
            top: 172px;
            position: absolute;
        }
        .auto-style10 {
            z-index: 1;
            left: 170px;
            top: 242px;
            position: absolute;
        }
        .auto-style11 {
            z-index: 1;
            left: 170px;
            top: 311px;
            position: absolute;
        }
        .auto-style12 {
            z-index: 1;
            left: 167px;
            top: 383px;
            position: absolute;
        }
        .auto-style13 {
            z-index: 1;
            left: 166px;
            top: 467px;
            position: absolute;
        }
        .auto-style14 {
            z-index: 1;
            left: 126px;
            top: 526px;
            position: absolute;
        }
        .auto-style15 {
            z-index: 1;
            left: 21px;
            top: 633px;
            position: absolute;
        }
        .auto-style16 {
            z-index: 1;
            left: 77px;
            top: 569px;
            position: absolute;
            width: 53px;
            height: 26px;
        }
        .auto-style17 {
            z-index: 1;
            left: 172px;
            top: 570px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStockId" runat="server" style="z-index: 1; left: 16px; top: 55px; position: absolute" Text="Stock ID" width="111px"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtStockId" runat="server" OnTextChanged="txtStockId_TextChanged" style="z-index: 1; top: 52px; position: absolute; left: 175px"></asp:TextBox>
        </p>
        <asp:Label ID="lblItemStock" runat="server" CssClass="auto-style1" Text="Item Stock" width="111px"></asp:Label>
        <asp:Label ID="lblItemSize" runat="server" CssClass="auto-style2" Text="Item Size" width="111px"></asp:Label>
        <asp:Label ID="lblItemPrice" runat="server" CssClass="auto-style3" Text="Item Price" width="111px"></asp:Label>
        <asp:Label ID="lblItemDesc" runat="server" CssClass="auto-style4" Text="Item Description"></asp:Label>
        <asp:Label ID="lblItemAvailable" runat="server" CssClass="auto-style5" Text="Item Availability" width="111px"></asp:Label>
        <asp:Label ID="lblItemDate" runat="server" CssClass="auto-style7" Text="Item Date" width="111px"></asp:Label>
        <asp:TextBox ID="txtItemStock" runat="server" CssClass="auto-style8" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtItemSize" runat="server" CssClass="auto-style9" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtItemPrice" runat="server" CssClass="auto-style10" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtItemDesc" runat="server" CssClass="auto-style11" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtItemAvailable" runat="server" CssClass="auto-style12" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtItemDate" runat="server" CssClass="auto-style13" height="22px" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" CssClass="auto-style14" Text="Active" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style15" Text="Label"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style17" Text="Cancel" />
        <p>
            <asp:Button ID="btnOK" runat="server" CssClass="auto-style16" OnClick="btnOK_Click" Text="OK" />
        </p>
    </form>
</body>
</html>
