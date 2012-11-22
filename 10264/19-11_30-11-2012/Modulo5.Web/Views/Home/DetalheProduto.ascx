<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Modulo5.Web.Models.Produto>" %>

<div>
	<strong>Nome:</strong> <%= Model.Nome %><br />
	<strong>Preço:</strong> <%= Model.Preco %><br />
	<strong>Status:</strong> <%= Model.Status %><br />
</div>
