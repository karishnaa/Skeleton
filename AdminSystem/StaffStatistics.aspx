<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffStatistics.aspx.cs" Inherits="StaffStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 24px; width: 694px">
    <form id="form1" runat="server">
        <asp:GridView ID="GridViewStGroupByDOB" runat="server" OnSelectedIndexChanged="GridViewStGroupByDOB_SelectedIndexChanged" style="z-index: 1; left: 18px; top: 53px; position: absolute; height: 133px; width: 187px">
        </asp:GridView>
        <asp:GridView ID="GridViewStGroupByIsAvailable" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="z-index: 1; left: 20px; top: 255px; position: absolute; height: 133px; width: 187px">
        </asp:GridView>
    </form>
</body>
</html>
