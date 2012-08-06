<%@ Page Title="Outro" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Modulo5.Web.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="background-color: red; border: 1px solid;">
        Conteúdo Principal
    </div>

    <asp:HyperLink ID="HyperLink1" runat="server" 
    NavigateUrl="Produto.aspx">Produto</asp:HyperLink>

</asp:Content>
