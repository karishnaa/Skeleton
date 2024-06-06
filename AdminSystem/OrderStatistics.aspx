<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderStatistics.aspx.cs" Inherits="OrderStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Orders Statistics Page</h1>
        </div>
        <h3>Order List - Grouped by OrderID</h3>
        <asp:GridView ID="GridViewStatGroupByOrderID" runat="server" style="z-index: 1; left: 17px; top: 112px; position: absolute; height: 133px; width: 187px">
        </asp:GridView>
        <h3>&nbsp;</h3>
        <h3>&nbsp;</h3>
        <h3>&nbsp;</h3>
        <h3>&nbsp;</h3>
        <h3>&nbsp;Order List - Grouped By Is Paid?</h3>
        <asp:GridView ID="GridViewStatGroupedByIsPaid" runat="server" style="z-index: 1; left: 10px; top: 323px; position: absolute; height: 133px; width: 187px">
        </asp:GridView>
        <asp:Button ID="btnBack_onClick" runat="server" style="z-index: 1; left: 347px; top: 285px; position: absolute" Text="Back to Order List" />

    </form>
</body>
</html>
