<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Principal.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    TesteMaster
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2 class="titulo-sucesso">TesteMaster</h2>
	
<div class="titulo-sucesso">
	Mensagem de Sucesso
</div>
	
	<span>
		<h2 class="titulo-sucesso">Outro teste</h2>
	</span>

</asp:Content>
