<%@ Page Title="Premios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="WebForm___VoucherPromo.Premios" %>


<asp:Content ClientIDMode="static" ID="Premio" ContentPlaceHolderID="MainContent" runat="server">



 <div class="row">
     <% foreach (var item in listaPremios)
      { %>
    <div class="col s12 m4">
      <div class="card">
        <div class="card-image">
          <img src="<%= item.UrlImagen %>">
          <span class="card-title"><%= item.Titulo %></span>
        </div>
        <div class="card-content">
          <p><%= item.Descripcion %></p>
        </div>
        <div class="card-action">
            <a class="waves-effect waves-light btn" href="FormularioCliente.aspx?idPremio=<% = item.ID.ToString() %>">LO QUIERO!</a>
        </div>
      </div>
    </div>
   <% }%>
  </div>



</asp:Content>
