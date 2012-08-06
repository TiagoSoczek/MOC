<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Modulo15.Web.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LoginView ID="LoginView1" runat="server">
            <AnonymousTemplate>
                Bem-vindo ao site! |
                <asp:LoginStatus ID="LoginStatus1" runat="server" />
            </AnonymousTemplate>
            <LoggedInTemplate>
                Bem-vindo <asp:LoginName ID="LoginName1" runat="server" /> |
                <asp:LoginStatus ID="LoginStatus1" runat="server" />
            </LoggedInTemplate>
        </asp:LoginView>
    
    </div>
    </form>
</body>
</html>
