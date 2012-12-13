<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MOC10265.Web.Models.ProdutoModel>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
	<head runat="server">
		<title>Produtos</title>
	</head>
	<body>
		
		<%= Html.ActionLink("Novo", "Novo") %>
		
		<hr/>

		<table>
			<tr>
				<th>Nome</th>
				<th>Preço</th>
				<th>Quantidade</th>
				<th>Ativo</th>
				<th>Data Primeira Compra</th>
				<th>Ação</th>
			</tr>
			
			<% foreach (var produto in Model.Produtos)
		   {
			   %>
				<tr>
					<td><%= Html.ActionLink(produto.Nome, "Editar", new {id = produto.Id}) %></td>
					<td><%= produto.Preco %></td>
					<td><%= produto.Quantidade %></td>
					<td><%= produto.Ativo %></td>
					<td><%= produto.DataPrimeiraCompra %></td>
					<td><%= Html.ActionLink("Remover", "Remover", new {id = produto.Id}) %></td>
				</tr>
				<%
		   } %>

		</table>
		
	</body>
</html>
