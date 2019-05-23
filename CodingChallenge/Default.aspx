<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CodingChallenge._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <div class="container">
       <asp:Label ID="LabelErro" runat="server"></asp:Label>
       <div class="row">
       <label>Usuário: </label>
       <asp:DropDownList ID="DropDownListUsuario" runat="server" CssClass="btn btn-default"></asp:DropDownList>
       </div>
       <div class="row">
       <label>Pruduto: </label>
       <asp:DropDownList ID="DropDownListProduto" runat="server" CssClass="btn btn-default"></asp:DropDownList>
       </div>
       <div class="row">
       <label>Lance: </label>
       <asp:TextBox ID="TextBoxLance" runat="server" TextMode="Number"></asp:TextBox>
       </div>
       <div class="row">
       <asp:Button ID="ButtonNovoLance" runat="server" Text="Dar Lance" OnClick="ButtonNovoLance_Click" />   
       </div>
   </div>
    <hr />
    <div>
        <asp:GridView ID="GridViewLances" runat="server"
            DataKeyNames="Id" AutoGenerateColumns="false" OnRowDataBound="GridViewLances_RowDataBound" CssClass="table table-striped">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" />
                <asp:BoundField DataField="Usuario.Id"  HeaderText="Usuario" />
                <asp:BoundField DataField="Produto.Id" HeaderText="Produto" />
                <asp:BoundField DataField="Lance" HeaderText="Lance" />
            </Columns>

        </asp:GridView>
    </div>

</asp:Content>
