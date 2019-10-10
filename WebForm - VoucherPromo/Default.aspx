
<%@ Page Title="Voucher" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm___VoucherPromo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div class="row">
            <div class="col s12">
                <asp:Label ID="lblGano" runat="server" Text=""></asp:Label>
                <div  class="card grey lighten-5">
                    <div class="card-content black-text">
                        <span class="card-title">Ingresá tu código y ganá</span>
                        <div class="row">
                            <div class="input-field col s12">
                                <label for="txtVoucher"></label>
                                <asp:TextBox runat="server" CssClass="validate" ID="txtVoucher" autofocus="true" placeholder="Código"/>
                            </div>
                        </div>
                    </div>
                    <div class="card-action" >
                        <asp:Button Text="Validar" runat="server" ClientIDMode="static" ID="btnEnviar" CssClass="btn" name="Enviar"  OnClick="btnEnviar_Click" style="background-color:#7005D3;"/>
                    </div>
                </div>
            </div>
        </div>

</asp:Content>
