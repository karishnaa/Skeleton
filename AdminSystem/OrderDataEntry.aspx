<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 351px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 587px; top: 56px; position: absolute" Text="OrderID"></asp:Label>
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 583px; top: 86px; position: absolute" Text="CustomerID" width="53px"></asp:Label>
        <asp:Label ID="StaffID" runat="server" style="z-index: 1; left: 585px; top: 119px; position: absolute; bottom: 572px;" Text="StaffID" width="53px"></asp:Label>
        <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 584px; top: 153px; position: absolute" Text="Date" width="53px"></asp:Label>
        <asp:Label ID="lblNotes" runat="server" style="z-index: 1; left: 586px; top: 192px; position: absolute" Text="Notes" width="53px"></asp:Label>
        <asp:CheckBox ID="chkIsPaid" runat="server" style="z-index: 1; left: 685px; top: 222px; position: absolute" Text="Yes" />
        <asp:Label ID="lblIsPaid" runat="server" style="z-index: 1; left: 585px; top: 224px; position: absolute" Text="Is Paid?" width="53px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 594px; top: 286px; position: absolute" Text="OK" height="26px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 659px; top: 287px; position: absolute; bottom: 397px" Text="Cancel" />
        <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; top: 56px; position: absolute; left: 660px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 660px; top: 85px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 660px; top: 150px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStaffID" runat="server"  style="z-index: 1; left: 658px; top: 117px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtNotes" runat="server" style="z-index: 1; left: 660px; top: 189px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 512px; top: 290px; position: absolute"></asp:Label>
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 808px; top: 52px; position: absolute" Text="Find" />
    </form>
</body>
</html>
