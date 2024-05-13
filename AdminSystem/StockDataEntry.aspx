<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 482px;
            width: 801px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:TextBox ID="txtStockID" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 385px; top: 25px; position: absolute" height="22px"></asp:TextBox>
        <asp:Label ID="lblStockID" runat="server" style="z-index: 1; left: 239px; top: 23px; position: absolute" Text="Stock ID" height="22px" width="74px"></asp:Label>
            <asp:TextBox ID="txtStockName" runat="server" style="z-index: 1; left: 385px; top: 66px; position: absolute" height="22px"></asp:TextBox>
        <asp:Label ID="lblStockName" runat="server" style="z-index: 1; left: 239px; top: 68px; position: absolute; width: 77px;" Text="Stock Name" height="22px"></asp:Label>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 239px; top: 163px; position: absolute" Text="Quantity" height="22px" width="74px"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 239px; top: 114px; position: absolute; width: 74px;" Text="Price" height="22px"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 385px; top: 112px; position: absolute" height="22px"></asp:TextBox>
            <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 239px; top: 256px; position: absolute" Text="Description" height="22px" width="74px"></asp:Label>
            <asp:CheckBox ID="chkAvailable" runat="server" style="z-index: 1; left: 400px; top: 293px; position: absolute; bottom: 558px" Text="Available" />
        <asp:Label ID="lblArrivalDate" runat="server" style="z-index: 1; left: 239px; top: 209px; position: absolute" Text="Arrival Date" height="22px"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 385px; top: 166px; position: absolute" height="22px" OnTextChanged="txtQuantity_TextChanged"></asp:TextBox>
            <asp:TextBox ID="txtArrivalDate" runat="server" style="z-index: 1; left: 385px; top: 212px; position: absolute" height="22px"></asp:TextBox>
        <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 385px; top: 253px; position: absolute" height="22px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 256px; top: 343px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 328px; top: 400px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 401px; top: 400px; position: absolute" Text="Cancel" />
            </div>
    </form>
</body>
</html>
