<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PublicarProducto.aspx.cs" Inherits="Proyecto1.PublicarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

    <!--FORMULARIO DE PUBLICAR PRODUCTO-->
    <div class="form-group">
    <div class="collapse navbar-collapse" id="upmenu2" style="background-color:#e9eef1">
        <ul class="nav navbar-nav" id="navbarontop3" style="background-color:#e9eef1">
            <li>
               
    <asp:Label ID="LblNombreProducto" runat="server" Text="Nombre del Producto" ></asp:Label>
    <asp:TextBox ID="TtxNombreProducto" runat="server" CssClass="form-control" Width="62%"></asp:TextBox><br />
                <asp:FileUpload ID="FileUpload1"  runat="server" /> <br />
    <asp:Label ID="LblDescripcion" runat="server" Text="Descripcion"></asp:Label>
    <textarea id="TxtDescripcion" Class="form-control" name="comentario" rows="5" cols="25" ></textarea>
    <asp:Label ID="LblPrecio" runat="server" Text="Precio"></asp:Label>
    <asp:TextBox ID="TxtPrecio" runat="server" Class="form-control"  Width="62%"></asp:TextBox><br />

    <asp:Button ID="BtnSubirProducto" runat="server" Text="Publicar" CssClass="btn btn-lg btn-primary btn-block btn-signin" Width="62%" OnClick="BtnSubirProducto_Click"/><br />
                </li>
            </ul>
        </div>
        </div>
</asp:Content>
