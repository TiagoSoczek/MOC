<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Admin</title>
</head>
<body>
    <div>
        <%= Html.ActionLink("Remover todos os produtos!", "RemoverTodosProdutos") %>
    </div>
</body>
</html>
