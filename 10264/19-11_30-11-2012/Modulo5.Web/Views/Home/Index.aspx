<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Modulo5.Web.Models.ProdutoModel>" %>
<%@ Import Namespace="Modulo5.Web.Models" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Index</title>
</head>
<body>
    <div>
        <%
        	// var produtos = (List<Produto>)ViewData["Produtos"];
			if (Model.Produtos.Count == 0)
		   { %>
		<h3>Nenhum produto encontrado.</h3>
        <% }
		   else
		   {
			   foreach (var produto in Model.Produtos)
			   {
				   %>
					<% Html.RenderPartial("DetalheProduto", produto); %>
		<%
			   }
		   } %>
    </div>
</body>
</html>
