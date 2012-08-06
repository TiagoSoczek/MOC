<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Modulo5.Web.Default" %>
<%@ Register src="Pesquisa.ascx" tagname="Pesquisa" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ConteudoPrincipal" runat="server">
    
    <h3>Conteúdo da página principal</h3>
    <p>&nbsp;</p>
    <uc1:Pesquisa ID="Pesquisa1" runat="server" />
    <p>&nbsp;</p>

</asp:Content>
