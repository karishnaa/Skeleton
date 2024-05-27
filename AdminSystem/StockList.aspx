<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .absolute-position {
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="position: absolute; top: 0px; left: 0px; width: 1501px; height: 580px;">
            <asp:ListBox ID="lstStockList1" runat="server" style="z-index: 1; left: 10px; top: 15px; height: 400px; width: 600px;"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="absolute-position" Style="z-index: 2; left: 10px; top: 430px;" OnClick="btnAdd_Click"></asp:Button>
            <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="absolute-position" style="z-index: 2; left: 110px; top: 430px;" OnClick="btn_Edit_Click"></asp:Button>
            <asp:Button ID="btnDelete_Button" runat="server" Text="Delete" CssClass="absolute-position" style="z-index: 2; left: 210px; top: 430px;" OnClick="btn_Delete_Click"></asp:Button>
            <asp:Label ID="lblError" runat="server" Text="" CssClass="absolute-position" style="z-index: 3; left: 10px; top: 480px; color: red;"></asp:Label>
            
            <asp:Label ID="lblStockName" runat="server" Text="Enter a Stock Name:" CssClass="absolute-position" Style="z-index: 3; left: 330px; top: 430px;" ></asp:Label>
            <asp:TextBox ID="txtStockName" runat="server" CssClass="absolute-position" style="z-index: 3; left: 460px; top: 430px;"></asp:TextBox>
            <asp:Button ID="btnApplyFilter" runat="server" Text="Apply Filter" CssClass="absolute-position" Style="z-index: 3; left: 460px; top: 470px;" OnClick="btnApplyFilter_Click" />
            <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" CssClass="absolute-position" Style="z-index: 3; left: 560px; top: 470px;" OnClick="btnClearFilter_Click" />
        </div>
    </form>
</body>
</html>