<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Index</title>
	<script src="<%= Url.Content("~/scripts/jquery-1.7.1.js") %>"></script>
	<script>
		$.ajaxSetup({ cache: false });

		$(document).ready(function () {

			/*$.ajaxSend(function () {
				console.log("Send");
			});*/
/*
			$.ajaxComplete(function () {
				console.log("Complete");
			});

			$.ajaxError(function () {
				console.log("Error");
			});*/

			$("#btn-carregar").click(function () {
				$("#conteudo").load("<%= Url.Action("ConteudoParcial") %>");
			});
			
			$("#btn-carregar-clientes").click(function () {

				$.post("<%= Url.Action("ObterClientes") %>", function(clientes) {

					$("#lista-clientes").empty();

					for (var i = 0; i < clientes.length; i++) {
						var cliente = clientes[i];

						$("#lista-clientes").append("<option value='" + cliente.Id + "'>" +
							cliente.Nome + "</option>");
					}

					// alert(clientes);
					// alert(clientes[0].Nome);

					// console.log(clientes);
				});

			});
		});
	</script>
</head>
<body>
    <div>
        <button id="btn-carregar">Carregar</button>
		<div id="conteudo">
			
		</div>
		<button id="btn-carregar-clientes">Carregar Clientes Random</button>
		
		<select id="lista-clientes" />
    </div>
</body>
</html>
