<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Proyecto1.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="collapse navbar-collapse" id="upmenu">
			<ul class="nav navbar-nav" id="navbarontop">
				<li class="active"><a href="#">INICIO</a> </li>
				<li class="dropdown">
					<a href="#" class="dropdown-toggle"	data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">PRODUCTOS <span class="caret"></span></a>
					<ul class="dropdown-menu dropdowncostume">
						<li><a href="#">Sport</a></li>
						<li><a href="#">Old</a></li>
						<li><a href="#">New</a></li>
					</ul>
				</li>
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

</asp:Content>
