<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RecuperarPass.aspx.cs" Inherits="Proyecto1.RecuperarPass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

    <div>
        <label for="ex0">Ingresa tu correo electrónico y nombre de Usuario y te enviaremos tu password</label>"

                <asp:TextBox ID="txtCorreo" runat="server" Style="width: 20%;" CssClass="form-control"></asp:TextBox>
        <br />
                <asp:Label ID="lblMensaje" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
        <br />
        <asp:Button ID="Enviar" runat="server" Text="Enviarme un correo" OnClick="btnEnviarC_Click" />
    </div>
</asp:Content>
