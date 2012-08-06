<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Modulo13.Web.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
	    <h1>Login</h1>
    <div>
    
        <asp:Label ID="lblUsuariosOnline" runat="server"></asp:Label>
    
    </div>
    <asp:Label ID="Label1" runat="server" Text="Usuário:"></asp:Label>
    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
    <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnLogin" runat="server" onclick="btnLogin_Click" 
        Text="Login" />
    <br />
    <br />
    <asp:CustomValidator ID="cvSenha" runat="server" ControlToValidate="txtSenha" 
        ErrorMessage="Usuario ou senha invalidos." ForeColor="Red"></asp:CustomValidator>
    </form>
</body>
</html>
