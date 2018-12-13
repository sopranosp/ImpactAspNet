<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Pessoal.WebForms.Tarefas.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Nova Tarefa</h1>
   
    <hr />

     <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    <table>
        <tr>

            <td> Nome</td>
            <td><asp:TextBox ID="NomeTextBox1" runat="server" Width="342px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Nome é Obrigatório" CssClass="text-Danger" ControlToValidate="NomeTextBox1">&amp;</asp:RequiredFieldValidator>

            </td>
        </tr>

         <tr>
             

            <td> Prioridade</td>
            <<asp:DropDownList ID="prioridadeDropDownList" DataSourceID="prioridadesObjectDataSource" AppendDataBoundItems="true" runat="server">
                    <asp:ListItem Text="Selecione" Value="0" />
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Selecion a Prioridade" ControlToValidate="prioridadeDropDownList" CssClass="text-danger" InitialValue="0" Text="(!)"></asp:RequiredFieldValidator>
                <asp:ObjectDataSource ID="prioridadesObjectDataSource" runat="server" SelectMethod="ObterPrioridades" TypeName="Pessoal.WebForms.Tarefas.Create"></asp:ObjectDataSource>

        </tr>
         <tr>

            <td style=" width:89px"> Concluída</td>
            <td><asp:CheckBox ID="concluidaCheckBox" runat="server" Width="341px"></asp:CheckBox></td>
        </tr>
         <tr>

            <td>
                <asp:TextBox ID="observacoesTextBox" runat="server" Width="342px" TextMode="MultiLine">
                </asp:TextBox>
               </td>
            <td>|</td>
        </tr>

    </table>
    <asp:Button Text="Gravar"  ID="gravarButton"   runat="server" OnClick="gravarButton_Click" />

</asp:Content>
