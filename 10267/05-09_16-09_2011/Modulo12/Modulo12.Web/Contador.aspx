<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contador.aspx.cs" Inherits="Modulo12.Web.Contador" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Visitantes Online: <%= Application["Visitantes"] %>
        <br />
        <br />
        <asp:Button ID="btnSair" runat="server" onclick="btnSair_Click" Text="Sair" />
    </div>
    </form>
</body>
</html>
