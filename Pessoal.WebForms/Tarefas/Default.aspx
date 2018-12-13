<%@ Page Title="Tarefas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Pessoal.WebForms.Tarefas.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h1>Tarefas</h1>
    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="Create">Nova Tarefa</asp:LinkButton>
    <asp:GridView runat="server" AutoGenerateColumns="False" DataSourceID="TarefasObjectDSN" Width="100%">
        <Columns >  
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
            <asp:BoundField DataField="Prioridade" HeaderText="Prioridade" SortExpression="Prioridade" />
            <asp:CheckBoxField DataField="Concluida" HeaderText="Concluida" SortExpression="Concluida" />
            <asp:BoundField DataField="Observacoes" HeaderText="Observacoes" SortExpression="Observacoes" />
        </Columns>


    </asp:GridView>

    <asp:ObjectDataSource runat="server" ID="TarefasObjectDSN" SelectMethod="Selecionar" TypeName="Pessoal.Repositorios.SqlServer.TarefaRepositorio" />
</asp:Content>
