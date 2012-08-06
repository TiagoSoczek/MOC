<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginManual.aspx.cs" Inherits="Modulo15.Web.LoginManual" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Usuário"></asp:Label>
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
        <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Login" runat="server" onclick="Login_Click" Text="Login" />
        <br />
        <br />
        <asp:Label ID="lblErro" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
