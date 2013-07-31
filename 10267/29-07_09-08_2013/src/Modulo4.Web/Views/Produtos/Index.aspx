<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Modulo4.Web.Models.ProdutosViewModel>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
	<head runat="server">
		<title>Produtos</title>
	</head>
	<body>
		<h1>Produtos</h1>
		
		<%= Html.ActionLink("Novo", "Novo") %>
		
		<hr />
		<%= Model.Agora.ToString("D") %>
		<hr />
		<%= Model.Preco.ToString("C") %>
	</body>
</html>
