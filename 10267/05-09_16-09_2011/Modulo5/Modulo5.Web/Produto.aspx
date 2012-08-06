<%@ Page Title="Produto" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Produto.aspx.cs" Inherits="Modulo5.Web.Produto" %>
<%@ Register src="Pesquisa.ascx" tagname="Pesquisa" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Página do Produto</h2>
    <asp:HyperLink ID="HyperLink1" runat="server" 
    NavigateUrl="Default.aspx">Home</asp:HyperLink>

    <br />
    <br />
    <uc1:Pesquisa ID="Pesquisa2" runat="server" />

</asp:Content>
