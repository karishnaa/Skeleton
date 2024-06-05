<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customers List</title>
    <style type="text/css">
        body { 
            width: 100vw;
            height: 100vh;
            background-image: url('../images/greeeen.jpg');
            background-size: cover;
            background-position: center;
            background-repeat: no-repeat;
            background-size: cover;
            margin: 0;
            padding: 0;
            overflow-x: hidden;
            display: flex;
            justify-content: center;
            align-items: center;
            flex-direction: column;
            }
     
        #form1 {
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: center;
            min-height: 50vh;
            min-width:50vh;
            background-color:#fffcf9;
        }
        .container {
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            text-align: center;
        }
        .container > * {
            margin: 10px 0;
        }
        .button-container {
            display: flex;
            justify-content: space-between;
            flex-wrap: wrap;
        }
        .button-container > * {
            margin: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:Label ID="lblEmailAddress" runat="server" Text="Enter Email Address" Font-Names="Century Gothic" ForeColor="#00278E" />
            <asp:TextBox ID="txtFilter" runat="server" Font-Names="Poppins" />
            <div class="button-container">
                <asp:Button ID="btnApplyFilter" runat="server" OnClick="BtnApplyFilter_Click" Text="Apply Filter" Font-Names="Century Gothic" />
                <asp:Button ID="btnClearfilter" runat="server" OnClick="BtnClearfilter_Click" Text="Clear Filter" Font-Names="Century Gothic" />
            </div>
            <asp:ListBox ID="lstCustomersList" runat="server" Height="200px" Width="100%" Font-Names="Century Gothic" />
            <asp:Label ID="lblError" runat="server" Text="" Font-Names="Century Gothic" ForeColor="Red" />
            <div class="button-container">
                <asp:Button ID="btnAdd" runat="server" OnClick="BtnAdd_Click" Text="Add" Width="100px" Font-Names="Centry Gothic" />
                <asp:Button ID="btnEdit" runat="server" OnClick="BtnEdit_Click" Text="Edit" Width="100px" Font-Names="Century Gothic" />
                <asp:Button ID="btnDelete" runat="server" OnClick="BtnDelete_Click" Text="Delete" Width="100px" Font-Names="Century Gothic" />
            </div>
            <div class="button-container">
                <asp:Button ID="btnStatisticspage" runat="server" OnClick="BtnStatisticspage_Click" Text="Statistics Page" Width="150px" Font-Names="Century Gothic" />
                <asp:Button ID="btnReturntomm" runat="server" OnClick="BtnReturntomm_Click" Text="Return to Main Menu" Width="200px" Font-Names="Century Gothic" />
            </div>
        </div>
    </form>
</body>
</html>

