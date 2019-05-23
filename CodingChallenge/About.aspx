<%@ Page Title="Cadastro de Usuários" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="CodingChallenge.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Cadastre novos usuários.</h3>
    <label>login: </label>
    <asp:TextBox ID="TextBoxLogin" runat="server"></asp:TextBox>
    <label>Senha: </label>
    <asp:TextBox ID="TextBoxSenha" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <asp:Button ID="ButtonCriar" runat="server" OnClick="ButtonCriar_Click" Text="Criar"/>
</asp:Content>
