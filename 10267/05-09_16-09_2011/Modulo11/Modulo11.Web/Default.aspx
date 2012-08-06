<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Modulo11.Web.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="lblAgora" runat="server"></asp:Label>
                <br />
                <asp:Timer ID="Timer1" runat="server" Interval="2000" ontick="Timer1_Tick">
                </asp:Timer>
                <br />
                <asp:Button ID="btnAtualizar" runat="server" onclick="btnAtualizar_Click" 
                    Text="Atualizar" />

                    <asp:UpdateProgress ID="UpdateProgress1" runat="server" 
            AssociatedUpdatePanelID="UpdatePanel1">
                    <ProgressTemplate>
                        Atualizando
                    </ProgressTemplate>
                </asp:UpdateProgress>
            </ContentTemplate>
        </asp:UpdatePanel>

        
    </div>
    </form>
</body>
</html>
