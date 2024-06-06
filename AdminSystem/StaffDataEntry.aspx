
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
    <style type="text/css">
        #form1 {
            height: 469px;
            width: 784px;
        }
    </style>
   
</head>
<body style="height: 599px; width: 821px">
    <form id="form1" runat="server">
     
        <div>
             <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; width: 57px; height: 19px;" Text="Staff Id"></asp:Label>
            <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; margin-left: 10px; margin-right: 0px;" Width="128px" Height="16px"></asp:TextBox>
            &nbsp;<asp:TextBox ID="txtName" runat="server" style="z-index: 1; position: absolute; width: 128px; height: 16px; top: 49px; left: 71px; bottom: 565px;"></asp:TextBox>
             <p style="height: 25px; width: 781px">
             <asp:Label ID="lblName" runat="server" style="z-index: 1;  width: 51px; height: 17px" Text="Name"></asp:Label>
            </p>

             <p style="height: 27px; width: 788px; margin-right: 5px">
                 <asp:Label ID="lblDOB" runat="server" style="z-index: 1;  width: 49px; height: 23px; right: 740px;" Text="DOB"></asp:Label>
               <asp:TextBox ID="txtDOB" runat="server" style="z-index: 1;  position: absolute; width: 128px; height: 16px; left: 70px; top: 89px;"></asp:TextBox>
               
            </p> 
            <p style="height: 26px; width: 785px; margin-right: 0px; margin-top: 18px">
                 
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1;  height: 17px; width: 46px" Text="Email"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1;   margin-left: 8px; margin-right: 0px; margin-top: 3px;" Height="16px" OnTextChanged="txtEmail_TextChanged" Width="128px"></asp:TextBox>
            </p>

            <p>
                 <asp:Label ID="lblPosition" runat="server" style="z-index: 1;  height: 20px; width: 57px" Text="Position"></asp:Label>
               &nbsp;<asp:TextBox ID="txtPosition" runat="server" style="z-index: 1; margin-left: 3px; margin-top: 0px;" OnTextChanged="TextBox1_TextChanged" Width="128px" Height="16px"></asp:TextBox>                    
          </p>

             <p>
     <asp:Label ID="lblSalary" runat="server" Text="Salary"></asp:Label>

     <asp:TextBox ID="txtSalary" runat="server" style="margin-left: 20px" Width="128px" Height="16px"></asp:TextBox>
 </p>

        <p style="height: 28px; width: 780px; margin-right: 0px; margin-top: 0px; margin-bottom: 6px">
            
     
          
       
        &nbsp;&nbsp;&nbsp;<asp:CheckBox ID="chkIsAvailable" runat="server" Text="Available" OnCheckedChanged="chkIsAvailable_CheckedChanged" />
           
     
          
       
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblError" runat="server"></asp:Label>
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        
      
        
       
       
     
     
          
        <p style="height: 47px; width: 780px; margin-top: 26px">
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Height="24px" style="margin-right: 0px; margin-top: 17px" Width="56px" />
        <asp:Button ID="btnCancel" runat="server" Height="24px" Text="Cancel" Width="68px" OnClick="btnCancel_Click" style="margin-left: 20px; margin-top: 0px" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" style="margin-left: 21px; margin-top: 15px" Width="60px" Height="24px" />
     
          
        </p>

        </div>
          
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     
          
        <asp:Button ID="btnReturnToMainMenu" runat="server" OnClick="btnReturnToMainMenu_Click" style="z-index: 1; left: 10px; top: 405px; position: absolute; width: 167px; height: 24px" Text="Return to main menu" />
     
          
    </form>
</body>
</html> 