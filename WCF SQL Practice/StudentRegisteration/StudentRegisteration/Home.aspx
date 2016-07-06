<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="StudentRegisteration.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
             <tr>
                <td>
                    <asp:Label ID="lblStudID" runat="server" Text="Student ID: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtStudID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblName" runat="server" Text="Student Name: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblGender" runat="server" Text="Gender: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
