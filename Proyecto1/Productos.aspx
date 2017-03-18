<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Proyecto1.Productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- INICIO Y BUSCADOR DE PRODUCTOS-->
        <ul class="nav navbar-nav" style="margin-left: auto;"  id="navbarontop">
            <li><a style="margin-left: auto" href="Inicio.aspx">INICIO</a> </li>
            <li class="dropdown">
                <a href="QuienesSomos.aspx">QUIENES SOMOS</a>
            </li>
            <li>
                <a href="Contactenos.aspx">CONTACTENOS</a>

            </li>


            <!--buscador panel-->
            <li>
        </ul>
    <br />
    <br />
    <br />
    <br />
  

    <nav class="navbar navbar-default midle-nav">
			<div class="navbar-header">
				<button type="button" class="navbar-toggle collapsed textcostume" data-toggle="collapse" data-target="#navbarmidle" aria-expanded="false">
						<h1>SEARCH TEXT</h1>
					<span class="sr-only">Toggle navigation</span>
					<span class="icon-bar"></span>
					<span class="icon-bar"></span>
					<span class="icon-bar"></span>
				</button>
			</div>
			 <div class="collapse navbar-collapse" id="navbarmidle" style="margin-left: 15%">
            <div class="searchtxt">
            </div>
                <div class="form-group">
                    <input type="text" class="form-control searchform" size="25" maxlength="45" placeholder="Buscar Producto...">
                    <button class="searchbutton"><span class="glyphicon glyphicon-search "></span></button> 

                </div>
             
                 <ul class="nav navbar-nav navbarborder">
                     <li class="li-category">
                         <a class="btn  dropdown-toggle btn-costume" id="dropdownMenu1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">Categoria<span class="glyphicon glyphicon-chevron-down downicon"></span></a>
                         <ul class="dropdown-menu" id="mydd">
                             <li><a href="#">Epic</a></li>
                             <li><a href="#">Old</a></li>
                             <li><a href="#">New</a></li>
                         </ul>
                     </li>
                     <li class="li-minyear"><a class="btn  dropdown-toggle btn-costume" id="dropdownMenu2" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">Marca <span class="glyphicon glyphicon-chevron-down downicon"></span></a>
                         <ul class="dropdown-menu" id="mydd2">
                             <li><a href="#">1</a></li>
                             <li><a href="#">2</a></li>
                             <li><a href="#">3</a></li>
                         </ul>
                     </li>
                     <li class="li-maxyear"><a class="btn dropdown-toggle btn-costume" id="dropdownMenu3" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">Modelo <span class="glyphicon glyphicon-chevron-down downicon"></span></a>
                         <ul class="dropdown-menu" id="mydd3">
                             <li><a href="#">1900</a></li>
                             <li><a href="#">2000</a></li>
                             <li><a href="#">2016</a></li>
                         </ul>
                     </li>
                 </ul>
 
			</div>
		</nav>

    
    <!-- PRODUCTOS LISTA-->
    <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
    <br />
    <br />
    <asp:GridView ID="gvProductos" runat="server">
    </asp:GridView>
    <br />
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
                       <td>

                       </td>
                   </tr>
                   <tr>
                       <td>
                           <a href="DetalleProducto.aspx?ProductoID=<%#: Item.ProductoID%>">
                                <span>
                                    <%#: Item.NombreProducto %>
                                </span>
                           </a>
                           <br />
                           <span>
                               <b>Precio: </b><%#:Item.PrecioU%> pesos
                           </span>
                           <br />
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
                           <table id="GroupPlaceHolderContenedor" runat="server" style="width:100%">
                                <tr id="groupPlaceHolder">                                </tr>
                           </table>
                       </td>
                   </tr>
               </tbody>
           </table>
       </LayoutTemplate>
    </asp:ListView>
    



        	
   
</asp:Content>
