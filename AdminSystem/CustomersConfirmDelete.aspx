<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete - Fashion Frenzy</title>
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
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            text-align: center;
            width: 300px;
        }

        #form1 > * {
            margin: 10px 0;
        }

        .styled-button {
            padding: 10px 20px;
            border-radius: 5px;
            cursor: pointer;
            border: none;
            background-color: #137a63;
            color: white;
            font-family: 'Century Gothic', sans-serif;
            transition: background-color 0.3s ease;
        }

        .styled-button:hover {
            background-color: #0a3a2a;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this record?" Font-Names="Century Gothic"></asp:Label>
        <asp:Button ID="btnYES" runat="server" Text="Yes" CssClass="styled-button" OnClick="btnYES_Click" />
        <asp:Button ID="btnNO" runat="server" Text="No" CssClass="styled-button" OnClick="btnNO_Click" />
    </form>
</body>
</html>


