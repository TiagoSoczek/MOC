<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Modulo1.MVC.Models.ApresentacaoModel>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>IndexXml</title>
</head>
<body>
    <div>
        <h1>Isto aqui é um XML!</h1>
		<ul>
			<li>Nome: <%= Model.Nome %></li>
			<li>Resultado: <%= Model.Resultado %></li>
		</ul>
    </div>
</body>
</html>
