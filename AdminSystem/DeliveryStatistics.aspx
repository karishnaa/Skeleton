<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeliveryStatistics.aspx.cs" Inherits="DeliveryStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Delivery Statistics Page</h1>
        <h3>Deliveries - Grouped by Delivery Status</h3>
        
        <asp:GridView ID="GridViewStatsGroupedByDeliveryStatus" runat="server" style="z-index: 1; left: 11px; top: 127px; position: absolute; height: 133px; width: 187px">
        </asp:GridView>

        <h3>&nbsp;</h3>
        <h3>&nbsp;</h3>
        <h3>&nbsp;</h3>
        <h3>&nbsp;</h3>
        <h3>&nbsp;</h3>
        <h3>
            <asp:GridView ID="GridViewStatsGroupedByOrderID" runat="server" style="z-index: 1; left: 21px; top: 361px; position: absolute; height: 139px; width: 226px">
            </asp:GridView>
            Deliveries - Grouped by Order ID</h3>
        <p>&nbsp;</p>
        
        <asp:Button ID="btnBack_onClick" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 300px; top: 463px; position: absolute" Text="Back to Delivery List" />
        
    </form>
</body>
</html>
