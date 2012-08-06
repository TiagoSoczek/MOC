<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Wise.Web.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        


        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtNome" Display="Dynamic" ErrorMessage="Campo Obrigatório" 
            SetFocusOnError="True"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" />
        
        &nbsp;<asp:Button ID="btnExibirEsconder" runat="server"
            Text="Esconder" />
        
        <br />
        <br />
        <asp:Label ID="lblNome" runat="server"></asp:Label>
        
    </div>
    </form>
</body>
</html>