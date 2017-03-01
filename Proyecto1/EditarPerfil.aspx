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
                    <label  for="ex1">Usuario</label>  
                <input type="text"  style="width:90%;"id="Usuario" class="form-control">

              </div>
                    <label for="ex2">Nombre</label>
                <input type="text"  style="width:90%;"id="Nombre" class="form-control">
                
              
                    <label for="ex3">Apellido</label>
                <input type="text"  style="width:90%;"id="Apellido" class="form-control">
                    

            <label for="ex4">Direccion</label>
                <input type="text"  style="width:90%;"id="Direccion" class="form-control">

            <label for="ex5">Telefono</label>
                <input type="tel"  style="width:90%;"id="Telefono" class="form-control">

                 <label for="ex6">Correo Electronico</label>
                <input type="email"  style="width:90%;"id="Correo Electronico" class="form-control">

                 <label for="ex7">Contraseña</label>
                <input type="password"  style="width:90%;"id="InputContraseña" class="form-control">
                 
                <br />
                 <button class="btn btn-lg btn-primary btn-block btn-signin"  style="width:90%;  border-bottom:1px solid #03214c; background-color:#4d90fe";  type="button">Editar Perfil</button>

            </li>    
        </ul>
                </div>
</asp:Content>
