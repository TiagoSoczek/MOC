<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MOC10265.Web.Models.EditarProdutoModel>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Novo</title>
</head>
<body>
    <div>
        <% using (Html.BeginForm("Salvar", "Produtos"))
           { %>
			
			<%= Html.HiddenFor(m => m.Produto.Id) %>
			<%= Html.HiddenFor(m => m.Produto.Versao) %>
		
        	Nome: <%= Html.TextBoxFor(m => m.Produto.Nome) %><br />
        	Preço: <%= Html.TextBoxFor(m => m.Produto.Preco) %><br />
        	Quantidade: <%= Html.TextBoxFor(m => m.Produto.Quantidade) %><br />
        	Ativo: <%= Html.CheckBoxFor(m => m.Produto.Ativo) %><br />
		
			<input type="submit" value="Salvar" />
        <% } %>
    </div>
</body>
</html>
