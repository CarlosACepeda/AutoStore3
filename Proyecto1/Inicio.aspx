<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Proyecto1.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <div class="collapse navbar-collapse" id="upmenu">
			<ul class="nav navbar-nav" id="navbarontop">
				<li><a href="#">INICIO</a> </li>
				<li><a href="#">PRODUCTOS</a></li>
				<li class="dropdown">
						<a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">QUIENES SOMOS <span class="caret"></span></a>
						<ul class="dropdown-menu dropdowncostume">
							<li><a href="#">MISIÓN</a></li>
							<li><a href="#">VISIÓN</a></li>							
						</ul>
				</li>
				<li>
					<a href="contact.html">CONTACTENOS</a>
 
				</li>
				
			</ul>
		</div>
    
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
