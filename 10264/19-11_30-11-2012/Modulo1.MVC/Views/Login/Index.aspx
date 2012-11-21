<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Modulo1.MVC.Models.ApresentacaoModel>" %>

<!DOCTYPE html>

<html>
<head runat="server">
	<title>Index</title>
</head>
<body>
	<%using (Html.BeginForm("Inicial", "Login"))
	{ %>
		<div>

			<%= Html.TextBoxFor(m => m.Nome) %>

			<input type="submit" value="Enviar" />

			<%= Model.Resultado %>

		</div>
	<% } %>
</body>
</html>
