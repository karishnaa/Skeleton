<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeliveryDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delivery</title>
    <style type="text/css">
        #form1 {
            height: 333px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

 
     
        <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 871px; top: 55px; position: absolute" Text="Find" />

 
     
        <asp:TextBox ID="txtDeliveryAddress" runat="server" style="z-index: 1; top: 144px; position: absolute" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 707px; top: 233px; position: absolute" Text="Yes" />
        <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 616px; top: 103px; position: absolute; bottom: 588px;" Text="OrderID" width="66px"></asp:Label>
        <asp:Label ID="lblDeliveryAddress" runat="server" style="z-index: 1; left: 618px; top: 134px; position: absolute" Text="Delivery Address" width="66px"></asp:Label>
        <asp:TextBox ID="txtDateOfDelivery" runat="server" style="z-index: 1; left: 695px; top: 189px; position: absolute" width="128px"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 730px; top: 295px; position: absolute" Text="OK" OnClick="btnOK_Click" />
        <asp:Label ID="lblDateOfDelivery" runat="server" style="z-index: 1; left: 618px; top: 180px; position: absolute; bottom: 492px;" Text="Date Of Delivery" width="66px"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 694px; top: 103px; position: absolute" width="128px"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 783px; top: 295px; position: absolute; width: 53px;" Text="Cancel" height="26px" />
        <asp:Label ID="lblDeliveryID" runat="server" style="z-index: 1; left: 617px; top: 62px; position: absolute" Text="DeliveryID"></asp:Label>
        <asp:TextBox ID="txtDeliveryID" runat="server" style="z-index: 1; left: 694px; top: 60px; position: absolute; width: 127px;"></asp:TextBox>
        <asp:Label ID="lblDispatchedID" runat="server" style="z-index: 1; left: 616px; top: 231px; position: absolute" Text="Dispatched" width="66px"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 621px; top: 300px; position: absolute"></asp:Label>

 
        <asp:Button ID="btnReturn" runat="server" style="z-index: 1; left: 890px; top: 295px; position: absolute" Text="Return to Main Menu" />

 
    </form>
</body>
</html>
