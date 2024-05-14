<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
    <title></title>Customer Page 
    </head>
<body style="height: 671px; width: 1189px; margin-left: 16px; margin-top: 16px;">
   <form id="form1" runat="server">
    <asp:TextBox ID="txtCustomerID" runat="server" height="31px" style="z-index: 1; left: 800px; top: 104px; position: absolute; width: 150px;" OnTextChanged="txtCustomerID_TextChanged"></asp:TextBox>
    <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 588px; top: 111px; position: absolute; right: 829px;" Text="CustomerID" Font-Names="Century Gothic"></asp:Label>
    <asp:TextBox ID="txtFullName" runat="server" height="31px" style="z-index: 1; left: 798px; top: 159px; position: absolute; width: 150px; right: 554px;" OnTextChanged="txtFullName_TextChanged"></asp:TextBox>
    <asp:TextBox ID="txtPhoneNumber" runat="server" height="31px" style="z-index: 1; left: 798px; top: 272px; position: absolute; width: 150px;"></asp:TextBox>
    <asp:Label ID="lblEmailAddress" runat="server" style="z-index: 1; left: 587px; top: 224px; position: absolute" Text="Email Address" Font-Names="Century Gothic" height="21px" width="107px"></asp:Label>
    <asp:TextBox ID="TxtEmailAddress" runat="server" height="31px" style="z-index: 1; left: 799px; top: 217px; position: absolute; width: 150px;"></asp:TextBox>
    <asp:Label ID="lblDOB" runat="server" style="z-index: 1; left: 590px; top: 324px; position: absolute" Text="DOB" Font-Names="Century Gothic"></asp:Label>
    <asp:TextBox ID="txtDOB" runat="server" height="31px" style="z-index: 1; left: 799px; top: 323px; position: absolute; width: 150px;"></asp:TextBox>
    <asp:Label ID="lblFullName" runat="server" style="z-index: 1; left: 589px; top: 165px; position: absolute" Text="Full Name" Font-Names="Century Gothic"></asp:Label>
    <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 587px; top: 278px; position: absolute; margin-bottom: 0px;" Text="Phone Number" Font-Names="Century Gothic"></asp:Label>
    <asp:CheckBox ID="Subscribed" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged"  Text="Subscribed" style="z-index: 1; left: 793px; top: 377px; position: absolute; width: 150px;" Font-Names="Century Gothic"></asp:CheckBox>
    <asp:Button ID="BtnCancel" runat="server" BorderStyle="Solid" Text="Cancel" style="z-index: 1; left: 867px; top: 456px; position: absolute;" Font-Names="Century Gothic" />
    <asp:Label ID="lblError" runat="server" Text="lblError" style="z-index: 1; left: 587px; top: 416px; position: absolute;" Font-Names="Century Gothic"></asp:Label>
    <asp:Button ID="BtnOK" runat="server" BorderStyle="Solid" Text="OK" style="z-index: 1; left: 787px; top: 456px; position: absolute; right: 182px; height: 27px;" Font-Names="Century Gothic" OnClick="BtnOK_Click" />
</form>

</body>


</html>
