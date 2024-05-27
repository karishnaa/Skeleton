<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="StockConfirmDelete">
            <asp:Label ID="lblConfirmation" runat="server" Text="Are you sure you want to delete this record?" /><br />
            <asp:Button ID="btnDeleteY" runat="server" Text="Yes" OnClick="btnDeleteY_Click" />
            <asp:Button ID="btnDeleteN" runat="server" Text="No" OnClick="btnDeleteN_Click" />
        </div>
    </form>
</body>
</html>
