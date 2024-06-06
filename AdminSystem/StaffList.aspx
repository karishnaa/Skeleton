<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p style="height: 26px; width: 1501px">
            <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 11px; top: 31px; position: absolute; height: 308px; width: 335px" OnSelectedIndexChanged="lstStaffList_SelectedIndexChanged"></asp:ListBox>
        </p>
        <p style="height: 26px; width: 1501px">
            &nbsp;</p>
        <p style="height: 26px; width: 1501px">
            &nbsp;</p>
        <p style="height: 26px; width: 1501px">
            &nbsp;</p>
        <p style="height: 26px; width: 1501px">
            &nbsp;</p>
        <p style="height: 26px; width: 1501px">
            &nbsp;</p>
        <p style="height: 26px; width: 1501px">
            &nbsp;</p>
        <p style="height: 26px; width: 1501px">
            <asp:Label ID="lblDOB" runat="server" style="z-index: 1; left: 6px; top: 464px; position: absolute; width: 104px; height: 21px" Text="Enter DOB"></asp:Label>
        </p>
        <p style="height: 26px; width: 1501px">
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 112px; top: 351px; position: absolute; width: 45px; height: 26px; right: 720px;" Text="Edit" />
            <asp:TextBox ID="txtDOB" runat="server" style="z-index: 1; top: 463px; position: absolute; left: 134px"></asp:TextBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Height="26px" Width="54px" />
        </p>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 205px; top: 353px; position: absolute; width: 64px;" Text="Delete" />
        <p style="height: 31px; width: 892px">
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 544px; position: absolute; height: 16px; width: 44px" Text="lblError"></asp:Label>
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 138px; top: 498px; position: absolute" Text="Clear Filter" />
            <asp:Button ID="btnReturnToMainMenu" runat="server" OnClick="btnReturnToMainMenu_Click" style="z-index: 1; left: 258px; top: 498px; position: absolute; width: 155px" Text="Return To Main Menu" />
            <asp:Button ID="btnStatisticsPage" runat="server" OnClick="btnStatisticsPage_Click" style="z-index: 1; left: 455px; top: 495px; position: absolute; height: 26px; width: 137px;" Text="Statistics Page" />
        </p>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 11px; top: 498px; position: absolute; height: 26px;" Text="Apply Filter" />
    </form>
</body>
</html>
