<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customers Data Entry - Fashion Frenzy</title>
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
            min-width: 80vh;
            background-color: #fffcf9;
        }

        .container {
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            text-align: left;
            width: 300px;
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
            flex-direction: column;
            align-items: center;
        }

        .button-container > * {
            margin: 5px;
        }

        button {
            padding: 10px 20px;
            border-radius: 5px;
            cursor: pointer;
            border: 0;
            background-color: white;
            box-shadow: rgb(0 0 0 / 5%) 0 0 8px;
            letter-spacing: 1.5px;
            text-transform: uppercase;
            font-size: 15px;
            transition: all 0.5s ease;
        }

        button:hover {
            background-color: #f0f0f0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="container">
        <div class="form-group">
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" Font-Names="Century Gothic"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server" Height="31px" Width="200px"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label ID="lblFullName" runat="server" Text="Full Name" Font-Names="Century Gothic"></asp:Label>
            <asp:TextBox ID="txtFullName" runat="server" Height="31px" Width="200px"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address" Font-Names="Century Gothic"></asp:Label>
            <asp:TextBox ID="TxtEmailAddress" runat="server" Height="31px" Width="200px"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number" Font-Names="Century Gothic"></asp:Label>
            <asp:TextBox ID="txtPhoneNumber" runat="server" Height="31px" Width="200px"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label ID="lblDOB" runat="server" Text="DOB" Font-Names="Century Gothic"></asp:Label>
            <asp:TextBox ID="txtDOB" runat="server" Height="31px" Width="200px"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:CheckBox ID="ChkSubscribed" runat="server" Text="Subscribed" Font-Names="Century Gothic"></asp:CheckBox>
        </div>

        <asp:Label ID="lblError" runat="server" Text="" Font-Names="Century Gothic"></asp:Label>

        <div class="button-container">
            <asp:Button ID="BtnOK" runat="server" Text="OK" CssClass="styled-button" Font-Names="Century Gothic" OnClick="BtnOK_Click" />
            <asp:Button ID="BtnCancel" runat="server" Text="Cancel" CssClass="styled-button" Font-Names="Century Gothic" OnClick="BtnCancel_Click" />
            <asp:Button ID="BtnFind" runat="server" Text="Find" CssClass="styled-button" Font-Names="Century Gothic" OnClick="BtnFind_Click" />
            <asp:Button ID="btnReturntomm" runat="server" Text="Return to Main Menu" Width="181px" CssClass="styled-button" Font-Names="Century Gothic" OnClick="btnReturntomm_Click" />
        </div>
    </form>
</body>
</html>

