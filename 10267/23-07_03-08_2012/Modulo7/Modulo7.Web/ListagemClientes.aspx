<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListagemClientes.aspx.cs" Inherits="Modulo7.Web.ListagemClientes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" DataSourceID="odsCliente">
        </asp:GridView>
        <asp:ObjectDataSource ID="odsCliente" runat="server" 
            OldValuesParameterFormatString="original_{0}" SelectMethod="ObterTodosClientes" 
            TypeName="Modulo7.DAL.ClienteDAL"></asp:ObjectDataSource>
    
    </div>
    </form>
</body>
</html>
