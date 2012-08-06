<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Modulo12.Web.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Panel ID="pnlLogin" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
            &nbsp;<asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
            &nbsp;<asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnAutenticar" runat="server" OnClick="btnAutenticar_Click" Text="Autenticar" />
            <br />
            <br />
            <asp:Label ID="lblResultado" runat="server"></asp:Label>
        </div>
    </asp:Panel>
    <asp:Panel ID="pnlLogado" runat="server" Visible="False">
        <asp:Label ID="Label3" runat="server" Text="Usuário já autenticado"></asp:Label>
        <br />
        <asp:Button ID="btnSair" runat="server" Text="Sair" onclick="btnSair_Click" />
    
    </asp:Panel>
    </form>
    &nbsp;</p>
</body>
</html>
