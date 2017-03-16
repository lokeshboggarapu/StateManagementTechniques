<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="SessionDemo.Department" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 24px;
        }
    </style>
</head>
<body style="background-color: #66FFCC">
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Italic="False" Font-Names="Arial Black" Text="Welocme  "></asp:Label>
                    <asp:Label ID="lblUsername" runat="server" Text="Label" Font-Bold="True" Font-Names="Arial Black"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Department ID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtsearch" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style1">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Arial Black" ForeColor="#FF3300" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
