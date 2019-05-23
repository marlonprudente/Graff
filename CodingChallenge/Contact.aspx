<%@ Page Title="Cadastrar novo Produto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="CodingChallenge.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<h2><%: Title %>.</h2>
<h3>Cadastre novos produtos.</h3>
    <label>Nome: </label>
    <asp:TextBox ID="TextBoxNome" runat="server"></asp:TextBox>
    <label>Valor:</label>
    <asp:TextBox ID="TextBoxValor" runat="server" TextMode="Number"></asp:TextBox>
    <asp:Button ID="ButtonCriar" runat="server" OnClick="ButtonCriar_Click" Text="Cadastrar" />

</asp:Content>
