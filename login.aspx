<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ElectionPollingManagement.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style>
        body{
            background-color:burlywood;
        }
        div{
            border:dotted;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
      <div><center><strong>Login Page</strong>
    <table border="0" height="50%" Width="50%">
      
               <tr><td>Enter your Email Id</td>
                <td><asp:TextBox  ID="txtEmail" runat="server"></asp:TextBox></td>
                    
                    </tr>

        
        <tr><td>Enter your Password</td>
                <td><asp:TextBox  ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                    
                    </tr>
             <tr>
            <td>
                <asp:Button ID="btnSignUp" runat="server" Text="Submit" Width="142px" OnClick="btnSignUp_Click" /></td>
            <td><asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="True" Font-Size="Large"></asp:Label>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                 </td>
        </tr>
    </table></center>
    </div>
    </form>
</body>
</html>
