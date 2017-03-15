<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarritoCompras.aspx.cs" Inherits="Proyecto1.VerOrden" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="collapse navbar-collapse" id="upmenu" style="background-color: #ffffff">
        <ul class="nav navbar-nav" id="navbarontop" style="background-color: #ffffff">
            <li><a href="Inicio.aspx">INICIO</a> </li>
            <li><a href="Productos.aspx">PRODUCTOS</a></li>
            <li class="dropdown">
                <a href="QuienesSomos.aspx">QUIENES SOMOS</a>
            </li>
            <li>
                <a href="Contactenos.aspx">CONTACTENOS</a>

            </li>

        </ul>
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

    <div id="CarritoComprasTitulo" runat="server" class="ContentHead"><h1>Carrito De Compras</h1></div>

        <asp:GridView ID="gvCarrito" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered" CellPadding="4" ItemType="Proyecto1.Models.ItemCarrito" SelectMethod="LlenarCarrito" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
            <Columns>
                <asp:BoundField DataField="ProductoID" HeaderText="ID" SortExpression="ProductoID" />
                <asp:BoundField DataField="Producto.NombreProducto" HeaderText="Nombre del Producto" />
                <asp:BoundField DataField="Producto.PrecioU" HeaderText="Precio (unidad)" />
                <asp:TemplateField HeaderText="Cantidad">
                    <ItemTemplate>
                        <asp:TextBox ID="txtCantidad" Width="40" runat="server" Text="<%#:Item.Cantidad %>"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Item Total">
                    <ItemTemplate>
                         <%#: Item.Cantidad * Item.Producto.PrecioU%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                    <asp:CheckBox ID="Remover" runat="server" Text="Quitar Producto"></asp:CheckBox>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>

<%--<a href="<% Response.Write(((Hashtable) preference["response"])["init_point"]); %>" name="MP-Checkout" class="orange-ar-m-sq-arall">Pay</a>
        <script type="text/javascript" src="//resources.mlstatic.com/mptools/render.js"></script>
        
        
         <script type="text/javascript">
            function execute_my_onreturn(json) {
                if (json.collection_status == 'approved') {
                    alert('Pago acreditado');
                } else if (json.collection_status == 'pending') {
                    alert('El usuario no completó el pago');
                } else if (json.collection_status == 'in_process') {
                    alert('El pago está siendo revisado');
                } else if (json.collection_status == 'rejected') {
                    alert('El pago fué rechazado, el usuario puede intentar nuevamente el pago');
                } else if (json.collection_status == null) {
                    alert('El usuario no completó el proceso de pago, no se ha generado ningún pago');
                }
            }
        </script>


        <script type="text/javascript">
            (function () { function $MPC_load() { window.$MPC_loaded !== true && (function () { var s = document.createElement("script"); s.type = "text/javascript"; s.async = true; s.src = document.location.protocol + "//secure.mlstatic.com/mptools/render.js"; var x = document.getElementsByTagName('script')[0]; x.parentNode.insertBefore(s, x); window.$MPC_loaded = true; })(); } window.$MPC_loaded !== true ? (window.attachEvent ? window.attachEvent('onload', $MPC_load) : window.addEventListener('load', $MPC_load, false)) : null; })();
        </script>--%>

    <p></p>
    <div>
        <strong>
            <asp:Label ID="LabelTotalTexto" runat="server" Text="Total:"></asp:Label>
            <asp:Label ID="LblTotal" runat="server" EnabledViewState="false"></asp:Label>
        </strong>
    </div>
    <table>
        <tr>
            <td>
                <asp:Button ID="UpdateBtn" runat="server" Text="Actualizar" OnClick="UpdateBtn_Click"/>
            </td>
        </tr>
    </table>
    

        
   
</asp:Content>

