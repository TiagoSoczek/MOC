<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Modulo8.Web.Models.PesquisaProdutosModel>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Index</title>
</head>
<body>
    <div>
	    
	    <%= Html.ActionLink("Adicionar Produto", "Novo") %><br />
	    <%= Html.ActionLink("Admin", "Index", "Admin") %><br />

	    <% using (Html.BeginForm("Index", "Produtos", FormMethod.Get))
		   {%>
			
		Termo: <%= Html.TextBoxFor(m => m.Termo) %>	 
		<input type="submit" value="Pesquisar" />
		
		   <%} %>
		
	    <hr />

        <% foreach (var produto in Model.Produtos)
		   { %>
			<div>
				Id: <%= produto.Id %><br />
				Nome: <%= produto.Nome %><br />
				Preco: <%= produto.Preco %><br />
				Ativo: <%= produto.Ativo %><br />
			</div>
		<%  } %>
    </div>
</body>
</html>
