<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Pesquisa.ascx.cs" Inherits="Modulo5.Web.Pesquisa" %>
<asp:TextBox ID="txtTermo" runat="server"></asp:TextBox>
<asp:Button ID="btnPesquisar" runat="server" onclick="btnPesquisar_Click" 
    Text="Pesquisar" />
<p>
    <asp:Label ID="lblResultado" runat="server"></asp:Label>
</p>

