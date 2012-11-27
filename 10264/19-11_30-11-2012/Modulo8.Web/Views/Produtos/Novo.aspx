<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Modulo8.Model.Produto>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Novo</title>
	<style>
		.input-padrao {
			border: 1px solid red;
		}
	</style>
</head>
<body>
    <div>
        <%using (Html.BeginForm("Salvar", "Produtos")){ %>
		
        	Nome: <%= Html.TextBoxFor(m => m.Nome, new {@class="input-padrao"}) %> <br />
			Preço: <%= Html.TextBoxFor(m => m.Preco) %> <br />
			Ativo: <%= Html.CheckBoxFor(m => m.Ativo) %> <br />
		
			<input type="submit" value="Salvar" />

        <%} %>
    </div>
</body>
</html>
