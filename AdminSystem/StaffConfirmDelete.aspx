<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 28px;
            width: 739px;
        }
    </style>
</head>
<body style="height: 151px; width: 742px">
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblRequest" runat="server" style="z-index: 1; left: 14px; top: 97px; position: absolute; width: 285px" Text="Are you sure you want to delete this record?"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnYes" runat="server" Text="Yes" Width="44px" OnClick="btnYes_Click" Height="21px" />
        <asp:Button ID="btnNo" runat="server" Height="21px" OnClick="btnNo_Click" style="margin-left: 30px; margin-top: 0px" Text="No" Width="44px" />
    </form>
</body>
</html>
