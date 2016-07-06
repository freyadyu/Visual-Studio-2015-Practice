<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplicationPractice.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server">test</asp:TextBox>
        <br />
        <asp:button runat="server" text="Click" OnClick="Single_Click" /> 
        
    </div>
        
    </form>
</body>
</html>

