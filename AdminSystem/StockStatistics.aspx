<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockStatistics.aspx.cs" Inherits="_StockStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                Statistics Page
            </h1>
        </div>
        <div>
            <h3>
                Stock List- Grouped by Price
            </h3>
            <asp:GridView ID="GridViewStGroupByPrice" runat="server" ></asp:GridView>
        </div>
        <div>
            <h3>
                Stock List- Grouped by Quantity
            </h3>
            <asp:GridView ID="GridViewStGroupByQuantity" runat="server"></asp:GridView>
            <asp:Button runat="server" Text="Back to Stock List" ID="btnBack" OnClick="btnBack_Click"></asp:Button>
        </div>
    </form>
</body>
</html>
