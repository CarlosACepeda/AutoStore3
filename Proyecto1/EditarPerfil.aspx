<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarPerfil.aspx.cs" Inherits="Proyecto1.EditarPerfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="collapse navbar-collapse" id="upmenu" style="background-color: #e9eef1">
        <ul class="nav navbar-nav" id="navbarontop" style="background-color: #e9eef1">
            <li><a href="Inicio.aspx">INICIO</a> </li>
            <li><a href="Productos.aspx">PRODUCTOS</a></li>
            <li class="dropdown">
                <a href="QuienesSomos.aspx">QUIENES SOMOS</a>
            </li>
            <li>
                <a href="Contactenos.aspx">CONTACTENOS</a>

                <br />
                
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
                  <div > 
                      <div cssclass="left" id="PerfilTitulo" runat="server" class="ContentHead">
                          <h1>Editar mi Perfil</h1>
                      </div>
                </div>
                        <label for="ex0">Foto de Perfil</label>
                            <asp:Image ID="imagenPerfil" runat="server" />
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                    <label  for="ex1">Usuario</label>  
                      <asp:TextBox ID="txtUsuario" runat="server" Style="width: 90%;" CssClass="form-control"></asp:TextBox>

              
                    <label for="ex2">Nombre</label>
                <asp:TextBox ID="txtNombre" runat="server" style="width:90%;" CssClass="form-control"></asp:TextBox>
                
              
                    <label for="ex3">Apellido</label>
                <asp:TextBox ID="txtApellido" runat="server" style="width:90%;" CssClass="form-control"></asp:TextBox>
                    

            <label for="ex4">Direccion</label>
                <asp:TextBox ID="txtDireccion" runat="server" style="width:90%;" CssClass="form-control"></asp:TextBox>

            <label for="ex5">Telefono</label>
                <asp:TextBox ID="txtTelefono" runat="server" style="width:90%;" CssClass="form-control"></asp:TextBox>

                 <label for="ex6">Correo Electronico</label>
                <asp:TextBox ID="txtCorreo" runat="server" style="width:90%;" CssClass="form-control"></asp:TextBox>

                 <label for="ex7">Contraseña</label>
                <asp:TextBox ID="txtClave" runat="server" style="width:90%;" CssClass="form-control"></asp:TextBox>
                 
                 
                <br />
                      <asp:Button ID="Actualizar" runat="server" Text="Button" OnClick="btnActualizar_Click"/>
                      </div>
                  
          
</asp:Content>
