<%@ Page Language="C#" ViewStateMode="Disabled"  EnableViewState="false" 
	AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Modulo7.Web.Default" meta:resourcekey="PageResource1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    	&nbsp;<asp:Button ID="btnCor" runat="server" OnClick="btnCor_Click" Text="Alterar Cor" meta:resourcekey="btnCorResource1" />
		<br />
		<asp:Button ID="btnEnviarDados" runat="server" OnClick="btnEnviarDados_Click" Text="Apenas Enviar Dados" meta:resourcekey="btnEnviarDadosResource1" />
    
    	<br />
		<asp:Label ID="lblDataAtual" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
