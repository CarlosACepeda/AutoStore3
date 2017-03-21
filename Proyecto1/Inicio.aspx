<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Proyecto1.Inicio" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" style="background-color:white;">
  
                        
    <div class="collapse navbar-collapse" id="upmenu" style="background-color:#FFFFFF">
        <ul class="nav navbar-nav" id="navbarontop" style="background-color:#FFFFFF">
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

    <!--SLIDERS-->
    <div class="allcontain">
        <div id="carousel-up" class="carousel slide" data-ride="carousel">
            <div class="carousel-inner " role="listbox">
                <div class="item active">
                    <img src="image/oldcar.jpg" alt="oldcar">
                    <div class="carousel-caption">
                    </div>
                </div>
                <div class="item">
                    <img src="image/porche.jpg" alt="porche">
                    <div class="carousel-caption">
                    </div>
                </div>
                <div class="item">
                    <img src="image/benz.jpg" alt="benz">
                    <div class="carousel-caption">
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
