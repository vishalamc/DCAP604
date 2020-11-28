<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="CollegeManagementSystem.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            background-color:burlywood;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div> <center>
            <table height="100%" width="50%">
                <tr><td colspan="2">User Sign IN</td></tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Enter User Name"></asp:Label>
                    </td>
                    <td>
                         <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                     </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Enter Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    </tr>
                <tr>
                    <td colspan="2"><asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                        <asp:Label ID="Label3" runat="server" ForeColor="#FF0066" Text="Label"></asp:Label>
                    </td>
                </tr>
                

               
            
            
                </table></center>
        </div>
    </form>
</body>
</html>
