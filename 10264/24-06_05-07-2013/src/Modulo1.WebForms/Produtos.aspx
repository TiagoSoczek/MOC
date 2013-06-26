<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Produtos.aspx.cs" Inherits="Modulo1.WebForms.Produtos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div>

			<asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
			<asp:Label ID="lblResultado" runat="server"></asp:Label>
			<br />
			<br />
			<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
			<br />
			<br />
			<asp:FileUpload ID="FileUpload1" runat="server" />
			<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />

		</div>
	</form>
</body>
</html>
