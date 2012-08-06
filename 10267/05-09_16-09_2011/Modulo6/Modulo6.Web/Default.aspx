<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Modulo6.Web.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function validarSenha(src, args) {
            
            if (args.Value.length >= 5 && args.Value.length <= 10) {
                args.IsValid = true;
            } else {
                args.IsValid = false;
            }

            args.IsValid = true;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
&nbsp;<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtEmail" Display="Dynamic" 
            ErrorMessage="O email deve ser informado." Font-Bold="True" ForeColor="Red" 
            SetFocusOnError="True">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Email inválido" 
            Font-Bold="True" ForeColor="Red" SetFocusOnError="True" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
&nbsp;<asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtSenha" Display="Dynamic" 
            ErrorMessage="A senha deve ser informada" Font-Bold="True" ForeColor="Red" 
            SetFocusOnError="True">*</asp:RequiredFieldValidator>
        <asp:CustomValidator ID="CustomValidator1" runat="server" 
            ClientValidationFunction="validarSenha" ControlToValidate="txtSenha" 
            Display="Dynamic" ErrorMessage="Entre 5 e 10" Font-Bold="True" ForeColor="Red" 
            onservervalidate="CustomValidator1_ServerValidate" SetFocusOnError="True">*</asp:CustomValidator>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Confirmação Senha"></asp:Label>
&nbsp;<asp:TextBox ID="txtConfirmacao" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="txtConfirmacao" Display="Dynamic" 
            ErrorMessage="A confirmação deve ser informada" Font-Bold="True" 
            ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="txtSenha" ControlToValidate="txtConfirmacao" 
            Display="Dynamic" ErrorMessage="A confirmação deve ser igual a senha." 
            Font-Bold="True" ForeColor="Red" SetFocusOnError="True">*</asp:CompareValidator>
        <br />
        <br />
        <asp:Button ID="btnSalvar" runat="server" onclick="btnSalvar_Click" 
            Text="Salvar" />
        <br />
        <br />
        <asp:Label ID="lblResultado" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
