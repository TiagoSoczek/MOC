<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Modulo1.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
	<link href="lib/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
	<form id="form1" runat="server">
		<div>

			<asp:Label ID="Label1" runat="server" Text="Usuário:"></asp:Label>
			<asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
			<br />
			<asp:Label ID="Label2" runat="server" Text="Senha:"></asp:Label>
			<asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
			<br />
			<asp:Button ID="btnOk" runat="server" CssClass="btn btn-primary" OnClick="btnOk_Click" Text="OK" />
			<br />
			<asp:Label ID="lblMensagem" runat="server"></asp:Label>

		</div>
	</form>
</body>
</html>
