<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioClienteFilled.aspx.cs" Inherits="WebForm___VoucherPromo.FormularioClienteFilled" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="row">
       <div class="row">
        <div class="input-field col s12">
            <asp:TextBox runat="server"  AutoPostBack="true" ClientIDMode="Static" placeholder="DNI" ID="DNI" CssClass="validate"/>
<%--          <input placeholder="DNI" id="DNI">--%>
          <label for="DNI"><%= cliente.DNI %></label>
        </div>
      </div>
      <div class="row">
        <div class="input-field col s6">
            <asp:TextBox runat="server" ClientIDMode="Static" placeholder="Nombre"  ID="first_name" type="text" CssClass="validate"/>
<%--          <input placeholder="Nombre"  id="first_name" type="text" class="validate">--%>
          <label for="first_name"></label>
        </div>
        <div class="input-field col s6">
            <asp:TextBox runat="server" ClientIDMode="Static" placeholder="Apellido" ID="last_name" type="text" CssClass="validate"/>
<%--          <input placeholder="Apellido" id="last_name" type="text" class="validate">--%>
          <label for="last_name"></label>
        </div>
      </div>
      <div class="row">
        <div class="input-field col s12">
            <asp:TextBox runat="server" ClientIDMode="Static" placeholder="Email" ID="email" type="email" CssClass="validate"/>
<%--          <input id="email" type="email" class="validate">--%>
          <label for="email"></label>
        </div>
      </div>
       <div class="row">
        <div class="input-field col s6">
            <asp:TextBox runat="server" ClientIDMode="Static" placeholder="Direccion" ID="Direccion" type="text" CssClass="validate"/>
<%--          <input placeholder="Direccion" id="Direccion" type="text" class="validate">--%>
          <label for="Direccion"></label>
        </div>
        <div class="input-field col s4">
            <asp:TextBox runat="server" ClientIDMode="Static" placeholder="Ciudad" ID="Ciudad" type="text" CssClass="validate" />
<%--          <input placeholder="Ciudad" id="Ciudad" type="text" class="validate">--%>
          <label for="Ciudad"></label>
        </div>
        <div class="input-field col s2">
            <asp:TextBox runat="server" ClientIDMode="Static" placeholder="CP" ID="CP" type="text" CssClass="validate"/>
<%--          <input placeholder="CP" id="CP" type="text" class="validate">--%>
          <label for="CP"></label>
        </div>
      </div>
  </div>

<asp:Button Text="Enviar" runat="server" CssClass="btn waves-effect waves-light"  type="submit" name="action"/>   


</asp:Content>
