<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Veiculo.aspx.cs" Inherits="TrabalhoBD.Veiculo"  Theme="Skin1"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="divprincipal">
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False" ForeColor="#333333" Width="800px" GridLines="None" OnRowCommand="GridView1_RowCommand">
                <AlternatingRowStyle BackColor="#ecf2aa" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="Código" SortExpression="id" />
                    <asp:BoundField DataField="fabricante" HeaderText="Fabricante" SortExpression="fabricante" />
                    <asp:BoundField DataField="modelo" HeaderText="Modelo" SortExpression="modelo" />
                    <asp:BoundField DataField="ano_fabricacao" DataFormatString="{0:d}" HeaderText="Ano Fabricação" SortExpression="ano_fabricacao" />
                    <asp:BoundField DataField="placa" HeaderText="Placa" SortExpression="placa" />
                    <asp:BoundField DataField="uf" HeaderText="UF" SortExpression="uf" />
                    <asp:ButtonField CommandName="edit" Text="Editar" />
                    <asp:ButtonField CommandName="del" Text="Deletar" />
                </Columns>
                <EditRowStyle BackColor="#ecf2aa" />
                <FooterStyle BackColor="#ecf2aa" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#c3ff00" Font-Bold="True" ForeColor="#62007a" Font-Names="Verdana" />
                <PagerStyle BackColor="#ecf2aa" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#ecf2aa"  Font-Names="Verdana"/>
                <SelectedRowStyle BackColor="#ecf2aa" Font-Bold="True" ForeColor="#333333" />
                <sortedascendingcellstyle backcolor="#ecf2aa" />
                <sortedascendingheaderstyle backcolor="#ecf2aa" />
                <sorteddescendingcellstyle backcolor="#ecf2aa" />
                <sorteddescendingheaderstyle backcolor="#ecf2aa" />
            </asp:GridView>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/VeiculoNovo.aspx">Novo</asp:HyperLink>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="TrabalhoBD.DAL.VeiculoDAL"></asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
