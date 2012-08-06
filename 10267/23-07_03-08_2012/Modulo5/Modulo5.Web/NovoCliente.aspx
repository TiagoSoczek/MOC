<%@ Page Title="" Language="C#" MasterPageFile="~/Cadastro.master" AutoEventWireup="true" CodeBehind="NovoCliente.aspx.cs" Inherits="Modulo5.Web.NovoCliente" %>

<asp:Content runat="server" ID="Content2" ContentPlaceHolderID="ConteudoHead">
    
    <script language="javascript">
        function dummy_validarSenha(elemento, args) {
            args.IsValid = args.Value.length >= 3 &&
                args.Value.length <= 10;
        }
    </script>

</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ConteudoCadastro" runat="server">
    <h5>Cadastro de Cliente</h5>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" 
        ShowMessageBox="True" />
    <p>
        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtEmail" ErrorMessage="O email deve ser informado.">*</asp:RequiredFieldValidator>
            
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="txtEmail" ErrorMessage="O email informado é inválido." 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
       
    </p>
    
    <p>
        <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtSenha" ErrorMessage="A senha deve ser informada.">*</asp:RequiredFieldValidator>
        <asp:CustomValidator ID="CustomValidator1" runat="server" 
            ClientValidationFunction="validarSenha" ControlToValidate="txtSenha" 
            ErrorMessage="A senha deve conter de 3 a 10 caracteres" 
            onservervalidate="CustomValidator1_ServerValidate">*</asp:CustomValidator>
    </p>

    <p>
    <asp:Label ID="Label3" runat="server" Text="Confirmação de senha"></asp:Label>
    <asp:TextBox ID="txtConfirmacao" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="txtConfirmacao" ControlToValidate="txtSenha" 
            ErrorMessage="A confirmação deve ser igual a senha.">*</asp:CompareValidator>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Idade"></asp:Label>
        <asp:TextBox ID="txtIdade" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator2" runat="server" 
            ControlToValidate="txtIdade" ErrorMessage="A idade deve ser um número" 
            Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" 
            ControlToValidate="txtIdade" ErrorMessage="A idade deve ser de 0 a 100." 
            MaximumValue="100" MinimumValue="0" Type="Integer">*</asp:RangeValidator>
    </p>

    <p>
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" 
            onclick="btnSalvar_Click" />
    </p>

</asp:Content>
