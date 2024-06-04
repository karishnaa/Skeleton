<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersStatistics.aspx.cs" Inherits="CustomersStatistics" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Statistics - Fashion Frenzy</title>
    <style type="text/css">
        body {
            width: 100vw;
            height: 100vh;
            background-image: url('../images/greeeen.jpg');
            background-size: cover;
            background-position: center;
            background-repeat: no-repeat;
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
            min-height: 80vh;
            width: 90vw;
            max-width: 1000px;
            background-color: #fffcf9;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            padding: 20px;
        }

        h3 {
            font-family: 'Century Gothic', sans-serif;
            color: #333;
            text-align: center;
            margin-top: 20px;
        }

        .gridview-container {
            width: 100%;
            margin-bottom: 20px;
        }

        .aspNet-GridView {
            width: 100%;
            border-collapse: collapse;
            text-align: left;
        }

        .aspNet-GridView th, .aspNet-GridView td {
            padding: 10px;
            border: 1px solid #ccc;
        }

        .aspNet-GridView th {
            background-color: #f5f5f5;
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
        <div class="gridview-container">
            <h3>Customer List - Grouped by DOB</h3>
            <asp:GridView ID="GridViewStGroupByDOB" runat="server" Height="198px" Width="100%" CssClass="aspNet-GridView" OnSelectedIndexChanged="GridViewStGroupByDOB_SelectedIndexChanged">
            </asp:GridView>
        </div>
        <div class="gridview-container">
            <h3>Customer List - Grouped By Subscribed</h3>
            <asp:GridView ID="GridViewStGroupBySubscribed" runat="server" Height="198px" Width="100%" CssClass="aspNet-GridView" OnSelectedIndexChanged="GridViewStGroupBySubscribed_SelectedIndexChanged">
            </asp:GridView>
        <div class="button-container">
             <asp:Button ID="btnCustomersList" runat="server" OnClick="BtnCustomersList_Click" Text="Return to Customers List" Width="200px" Font-Names="Century Gothic" />
        </div>
    </form>
</body>
</html>

