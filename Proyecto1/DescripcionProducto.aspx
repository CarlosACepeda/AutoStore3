<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DescripcionProducto.aspx.cs" Inherits="Proyecto1.DescripcionProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        <asp:ListView ID="listaProductosLV" runat="server"
        DataKeyNames="ProductoID" GroupItemCount="3"

        ItemType="Proyecto1.Models.Producto" SelectMethod="ObtenerProductos">

        <EmptyDataTemplate>
            <table>
                <tr>
                    <td> Ningún dato ha sido recuperado</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <EmptyDataTemplate>
            <td/>
        </EmptyDataTemplate>
        <GroupTemplate>
            <tr id="itemPlaceholderContenedor" runat="server">
                <td id="itemPlaceholder" runat="server"></td>
            </tr>
        </GroupTemplate>
            <ItemTemplate>
                <td runat="server">
                    <table>
                        <tr>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <a href="/AgregarAlCarro.aspx?ProductoID=<%#:Item.ProductoID %>">

                                    <span class="ListaItemProducto">
                                        <b>Agregar Al Carro</b>

                                    </span>
                                </a>
                            </td>
                        </tr>
                    </table>
                </td>
            </ItemTemplate>
       <LayoutTemplate>
           <table style="width:100%;">
               <tbody>
                   <tr>
                       <td>
                           <table id="GroupPlaceHolderContenedor" runat="server" style="width: 100%">
                               <tr id="groupPlaceHolder"></tr>
                           </table>
                       </td>
                   </tr>
               </tbody>
           </table>
       </LayoutTemplate>
    </asp:ListView>
</asp:Content>
