<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarPerfil.aspx.cs" Inherits="Proyecto1.EditarPerfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="collapse navbar-collapse" id="upmenu" style="background-color:#e9eef1">
        <ul class="nav navbar-nav" id="navbarontop" style="background-color:#e9eef1">
            <li><a href="Inicio.aspx">INICIO</a> </li>
            <li><a href="Productos.aspx">PRODUCTOS</a></li>
            <li class="dropdown">
                  <a href="QuienesSomos.aspx">QUIENES SOMOS</a>
            </li>
            <li>
                <a href="Contactenos.aspx">CONTACTENOS</a>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </li>

        </ul>
    </div>
    <br />
    <br />
    <br />
    <br />
   
        <div class="collapse navbar-collapse" id="upmenu2" style="background-color: #ffffff">
        <ul class="nav navbar-nav" id="navbarontop2" style="background-color: #ffffff">
            <li>
               <
                  <div > 
                    <label  for="ex1">Usuario</label>  
                      <asp:TextBox ID="txtUsuario" runat="server" Style="width: 90%;" CssClass="form-control"></asp:TextBox>

              
                    <label for="ex2">Nombre</label>
                <asp:TextBox ID="txtNombre" runat="server" style="width:90%;" CssClass="form-control"></asp:TextBox>>
                
              
                    <label for="ex3">Apellido</label>
                <asp:TextBox ID="txtApellido" runat="server" style="width:90%;" CssClass="form-control"></asp:TextBox>
                    

            <label for="ex4">Direccion</label>
                <asp:TextBox ID="TextBox1" runat="server" style="width:90%;" CssClass="form-control"></asp:TextBox>

            <label for="ex5">Telefono</label>
                <asp:TextBox ID="txtTelefono" runat="server" style="width:90%;" CssClass="form-control"></asp:TextBox>

                 <label for="ex6">Correo Electronico</label>
                <asp:TextBox ID="txtCorreo" runat="server" style="width:90%;" CssClass="form-control"></asp:TextBox>

                 <label for="ex7">Contraseña</label>
                <asp:TextBox ID="txtClave" runat="server" style="width:90%;" CssClass="form-control"></asp:TextBox>
                 
                      <br />
                      <br />
                      <asp:GridView ID="gvPerfil" runat="server">
                      </asp:GridView>
                      <br />
                      <br />
                      <br />
                 
                <br />
                      <asp:Button ID="btnVerI" runat="server" Text="Button" OnClick="btnVerI_Click"/>
                      <%--<asp:Button ID="bntVer" runat="server" Text="Button" Class="btn btn-lg btn-primary btn-block btn-signin"  style="width:90%;  border-bottom:1px solid #03214c; background-color:#4d90fe";  type="button" OnClick="EditarPerfil_Click">--%>
                 <%--<button class="btn btn-lg btn-primary btn-block btn-signin"  style="width:90%;  border-bottom:1px solid #03214c; background-color:#4d90fe";  type="button" </button>--%>
                      </div>
                  
            </li>    
        </ul>
                </div>
</asp:Content>
