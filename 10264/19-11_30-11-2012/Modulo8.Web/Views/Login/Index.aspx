<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Index</title>
</head>
<body>
    <div>
        <% using (Html.BeginForm("Login", "Login"))
		   {%>
			
        	Usuário: <%= Html.TextBox("Usuario") %>	<br />
        	Senha: <%= Html.TextBox("Senha") %>	<br />
		
			<input type="submit" value="Login" />
		  
		   <%} %>
    </div>
</body>
</html>
