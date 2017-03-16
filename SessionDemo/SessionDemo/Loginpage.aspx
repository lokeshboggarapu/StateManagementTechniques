<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loginpage.aspx.cs" Inherits="SessionDemo.Loginpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 348px;
        }
        .auto-style2 {
            width: 348px;
            height: 182px;
        }
        .auto-style3 {
            height: 182px;
        }
    </style>
</head>
<body style="background-color: #CCFFFF">
    <form id="form1" runat="server">
<div>    
    
    <table style="width: 100%; height: 180px;">
        <tr>
            <td class="auto-style1">USERNAME</td>
            <td>
                <asp:TextBox ID="txtusername" runat="server" Height="27px" Width="403px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtusername" ErrorMessage="Please Enter Username" SetFocusOnError="True" ></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">PASSWORD</td>
            <td>
                <asp:TextBox ID="txtpassword" runat="server" ClientIDMode="AutoID" Height="27px" TextMode="Password" Width="403px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtpassword" ErrorMessage="Please Enter password" SetFocusOnError="True" ></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style3">
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Login" Width="406px" />
                <asp:ValidationSummary ID="VsErrmsg" runat="server" />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Arial Black" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
    </table>
    
    </div>
    
    </form>
    
</body>
</html>
