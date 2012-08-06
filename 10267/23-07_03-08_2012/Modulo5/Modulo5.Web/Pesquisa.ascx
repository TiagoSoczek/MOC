<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Pesquisa.ascx.cs" Inherits="Modulo5.Web.Pesquisa" %>
<div style="border: 1px solid green; padding: 10px; width: 400px;">

    <asp:Label ID="Label1" runat="server" Text="Pesquisa:"></asp:Label>
    <asp:TextBox ID="txtPesquisa" runat="server"></asp:TextBox><asp:RequiredFieldValidator
        ID="RequiredFieldValidator1" SetFocusOnError="True" runat="server" ErrorMessage="*" ControlToValidate="txtPesquisa" ValidationGroup="pesquisa"></asp:RequiredFieldValidator>
    <asp:Button ID="btnPesquisa" runat="server" onclick="btnPesquisa_Click" ValidationGroup="pesquisa" 
        Text="OK" />
    <br />
    <asp:Label ID="lblResultado" runat="server"></asp:Label>

</div>