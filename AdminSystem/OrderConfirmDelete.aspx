<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div class="OrdersDelete">
    <asp:Label ID="lblOrdersDelete" runat="server" Text="You wanna delete this order?" /><br />
    <asp:Button ID="btnDeleteYes" runat="server" Text="Yes" OnClick="btnDeleteYes_onClick" />
    <asp:Button ID="btnDeleteNno" runat="server" Text="No" OnClick="btnDeleteNo_onClick" />
</div>
    </form>
</body>
</html>
