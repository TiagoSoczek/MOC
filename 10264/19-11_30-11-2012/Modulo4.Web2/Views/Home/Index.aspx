<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Index</title>
</head>
<body>
    <div>
        <h1>Página Principal</h1>
		
		<img src="<%= Url.Content("~/ExemploResult/Arquivo") %>" 
			width="100" height="100"/>
		
		<%--<% foreach (var item in lista)
		   {  %>
			   <li><%= item %></li>
		  <% } %>--%>

    </div>
</body>
</html>
