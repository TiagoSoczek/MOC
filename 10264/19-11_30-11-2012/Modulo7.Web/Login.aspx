<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Modulo7.Web.Loginaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    	<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
		<asp:Label ID="Label1" runat="server" Text="Usuário:"></asp:Label>
		<asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
		<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsuario" ErrorMessage="O usuário deve ser preenchido" ForeColor="Red">*</asp:RequiredFieldValidator>
		<br />
		<asp:Label ID="Label2" runat="server" Text="Senha:"></asp:Label>
		<asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
		<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSenha" ErrorMessage="A senha deve ser preenchida" ForeColor="Red">*</asp:RequiredFieldValidator>
		<br />
		<asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
    
    </div>
    </form>
</body>
</html>
