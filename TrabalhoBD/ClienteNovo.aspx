<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClienteNovo.aspx.cs" Inherits="TrabalhoBD.ClienteNovo" Theme="Skin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="divprincipal">
            <div>
                <asp:Label ID="LabelNOME" runat="server" Text="Nome"></asp:Label>
                <asp:TextBox ID="TextBoxNOME" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="LabelDATA" runat="server" Text="Data de Nascimento"></asp:Label>
                <input type="date" id="DATA" name="DATA"/>
            </div>

            <div>
                <asp:Label ID="LabelCPF" runat="server" Text="CPF"></asp:Label>
                <asp:TextBox ID="TextBoxCPF" runat="server" MaxLength="14" placeholder="Cpf com pontos e traços."></asp:TextBox>
            </div>

            <asp:Button ID="ButtonS" runat="server" Text="Salvar" OnClick="ButtonS_Click" />
        </div>
    </form>
</body>
</html>
