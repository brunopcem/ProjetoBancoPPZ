<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="TrabalhoBD.WebForm1" Theme="Skin1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="divprincipal">
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" Width="800px" OnRowCommand="GridView1_RowCommand">
                <AlternatingRowStyle BackColor="#ecf2aa" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="Código" SortExpression="id" />
                    <asp:BoundField DataField="nome" HeaderText="Nome" SortExpression="nome" />
                    <asp:BoundField DataField="data_nascimento" DataFormatString="{0:d}" HeaderText="Data de Nascimento" SortExpression="data_nascimento" />
                    <asp:BoundField DataField="cpf" HeaderText="CPF" SortExpression="cpf" />
                    <asp:ButtonField Text="Editar" CommandName="edit" />
                    <asp:ButtonField Text="Excluir" CommandName="del" />
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
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ClienteNovo.aspx">Novo</asp:HyperLink>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="TrabalhoBD.DAL.ClienteDAL"></asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
