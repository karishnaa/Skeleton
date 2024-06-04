<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Fashion Frenzy Main Menu</title>
    <style>
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

        .menu-container {
            text-align: center;
            margin-top: 20px; 
        }

        .menu-label {
            font-family: 'Century Gothic';
            font-size: 24px; 
            color: black;
            margin-bottom: 20px; 
            text-align: center; 

        }

        .button {
            height: 50px;
            width: 200px;
            position: relative;
            background-color: transparent;
            cursor: pointer;
            border: 2px solid #0a3a2a;
            overflow: hidden;
            border-radius: 30px;
            color: #137a63;
            transition: all 0.5s ease-in-out;
            margin-bottom: 10px; 
        }

        .btn-txt {
            z-index: 1;
            font-weight: 800;
            letter-spacing: 4px;
        }

        .type1::after {
            content: "";
            position: absolute;
            left: 0;
            top: 0;
            transition: all 0.5s ease-in-out;
            background-color: #0a3a2a;
            border-radius: 30px;
            visibility: hidden;
            height: 10px;
            width: 10px;
            z-index: -1;
        }

        .button:hover {
            box-shadow: 1px 1px 200px #137a63;
            color: #0a3a2a;
            border: none;
        }

        .type1:hover::after {
            visibility: visible;
            transform: scale(100) translateX(2px);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="menu-container">
            <asp:Label ID="Label1" runat="server" CssClass="menu-label" Text="Fashion Frenzy Main Menu"></asp:Label>
            <asp:Button ID="btnCustomers" runat="server" CssClass="button type1" OnClick="btnCustomers_Click" Text="Customers" />
            <asp:Button ID="btnStaff" runat="server" CssClass="button type1" OnClick="btnStaff_Click" Text="Staff" />
            <asp:Button ID="btnOrder" runat="server" CssClass="button type1" OnClick="btnOrder_Click" Text="Order" />
            <asp:Button ID="btnStock" runat="server" CssClass="button type1" OnClick="btnStock_Click" Text="Stock" />
            <asp:Button ID="btnDelivery" runat="server" CssClass="button type1" OnClick="btnDelivery_Click" Text="Delivery" />
        </div>
    </form>
</body>
</html>
