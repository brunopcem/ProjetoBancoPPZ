<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClienteEdit.aspx.cs" Inherits="TrabalhoBD.WebForm2" Theme="Skin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Código"></asp:Label>
            <asp:TextBox runat="server" ReadOnly="True" />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox runat="server" />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Data de Nascimento"></asp:Label>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Código"></asp:Label>
            <asp:TextBox runat="server" />
            <br />
            <asp:Button Text="Salvar" runat="server" />
        </div>
    </form>
</body>
</html>
