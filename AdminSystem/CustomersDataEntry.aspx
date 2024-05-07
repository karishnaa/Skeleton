<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: right;
        }
    </style>
    Customer Page 
</head>
<body style="height: 625px; width: 1103px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:TextBox ID="txtCustomerID" runat="server" height="21px" style="z-index: 1; left: 225px; top: 55px; position: absolute" width="93px"></asp:TextBox>
        </div>
        <p class="auto-style1">
            <asp:TextBox ID="txtFullName" runat="server" height="21px" style="z-index: 1; left: 224px; top: 88px; position: absolute; width: 110px"></asp:TextBox>
            <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 70px; top: 56px; position: absolute" Text="CustomerID" Font-Names="Century Gothic"></asp:Label>
        </p>
        <p class="auto-style1">
        <asp:Label ID="lblEmailAddress" runat="server" style="z-index: 1; left: 394px; top: 195px; position: absolute" Text="Email Address" Font-Names="Century Gothic"></asp:Label>
            <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 395px; top: 238px; position: absolute; margin-bottom: 0px;" Text="Phone Number" Font-Names="Century Gothic"></asp:Label>
            <asp:TextBox ID="txtSubscribed" runat="server" height="21px" style="z-index: 1; left: 561px; top: 320px; position: absolute" width="85px"></asp:TextBox>
          </p>
            <asp:Label ID="lblSubscribed" runat="server" style="z-index: 1; left: 395px; top: 326px; position: absolute" Text="Subscribed " Font-Names="Century Gothic"></asp:Label>
        <asp:TextBox ID="txtPhoneNumber" runat="server" height="21px" style="z-index: 1; left: 546px; top: 232px; position: absolute" width="116px"></asp:TextBox>
            <asp:Label ID="lblFullName" runat="server" style="z-index: 1; left: 70px; top: 84px; position: absolute" Text="Full Name" Font-Names="Century Gothic"></asp:Label>
            <p class="auto-style1">
            <asp:Label ID="lblDOB" runat="server" style="z-index: 1; left: 396px; top: 279px; position: absolute" Text="DOB" Font-Names="Century Gothic"></asp:Label>
                <asp:TextBox ID="TxtEmailAddress" runat="server" height="21px" style="z-index: 1; left: 229px; top: 112px; position: absolute" width="107px"></asp:TextBox>
        </p>
        <p class="auto-style1">
            &nbsp;</p>
    </form>
</body>
</html>
