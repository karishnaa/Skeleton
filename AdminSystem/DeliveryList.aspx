<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeliveryList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
           
        <asp:ListBox ID="lstDeliveryList1" runat="server" style="z-index: 1; left: 12px; top: 46px; position: absolute; height: 344px; width: 699px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 32px; top: 404px; position: absolute" Text="Add" />
            <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 114px; top: 403px; position: absolute" Text="Delete" />
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 194px; top: 403px; position: absolute" Text="Edit" />
            <asp:Button ID="btnApplFilter" runat="server" style="z-index: 1; left: 350px; top: 463px; position: absolute" Text="Apply Filter" />
            <asp:Button ID="btnClrFilter" runat="server" style="z-index: 1; left: 463px; top: 463px; position: absolute" Text="Clear Filter" />
        </p>
        <asp:Button ID="btnStati" runat="server" style="z-index: 1; left: 573px; top: 465px; position: absolute" Text="Statistics " />
        <asp:Button ID="btnReturn" runat="server" style="z-index: 1; left: 464px; top: 568px; position: absolute" Text="Return to Main Menu" />
        <asp:Label ID="lblDeliveryID" runat="server" style="z-index: 1; left: 311px; top: 407px; position: absolute" Text="Enter a Delivery ID: "></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 21px; top: 458px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtDeliveryID" runat="server" style="z-index: 1; left: 436px; top: 406px; position: absolute"></asp:TextBox>
           
    </form>
</body>
</html>
