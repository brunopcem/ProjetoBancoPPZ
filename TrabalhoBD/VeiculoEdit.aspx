<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VeiculoEdit.aspx.cs" Inherits="TrabalhoBD.VeiculoEdit" Theme="Skin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                 <div>
                <asp:Label ID="LabelFabricante" runat="server" Text="Fabricante"></asp:Label>
                <asp:TextBox ID="TextBoxFAB" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="LabelMOD" runat="server" Text="Modelo"></asp:Label>
                <asp:TextBox ID="TextBoxMOD" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="LabelANO" runat="server" Text="Ano de Fabricação"></asp:Label>
                <asp:TextBox ID="TextBoxANO" runat="server" MaxLength="4"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="LabelPLACA" runat="server" Text="Placa"></asp:Label>
                <asp:TextBox ID="TextBoxPLACA" runat="server" MaxLength="8"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="LabelUF" runat="server" Text="UF"></asp:Label>
                <asp:TextBox ID="TextBoxUF" runat="server" MaxLength="2"></asp:TextBox>
            </div>
            <asp:Button ID="ButtonS1" runat="server" Text="Salvar" OnClick="ButtonS1_Click" />
        </div>
    </form>
</body>
</html>
