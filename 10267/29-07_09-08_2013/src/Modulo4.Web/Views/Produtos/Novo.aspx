<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Modulo4.Web.Models.CadastroProdutoViewModel>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
	<head runat="server">
		<title>Cadastro</title>
	</head>
	<body>
		
		<% using (Html.BeginForm("Salvar", "Produtos"))
		{ %>

			Nome:
			<%= Html.TextBoxFor(x => x.Nome) %>
			<br />
		
			Preço:
			<%= Html.TextBoxFor(x => x.Preco) %>
			<br />
		
			<input type="submit" value="Salvar" />

		<% } %>
	</body>
</html>
