<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="WebForm___VoucherPromo.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p><% = Session["Error" + Session.SessionID] %></p>
    <a class="waves-effect waves-light btn" href="Default.aspx">VOLVER</a>

</asp:Content>
