<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetalheProduto.aspx.cs" Inherits="Modulo5.Web.DetalheProduto" %>

<%@ Register src="Pesquisa.ascx" tagname="Pesquisa" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Detalhe de Produto<br />
        <uc1:Pesquisa ID="Pesquisa1" runat="server" />
    
    </div>
    </form>
</body>
</html>
