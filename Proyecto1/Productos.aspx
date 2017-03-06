﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Proyecto1.Productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- INICIO Y BUSCADOR DE PRODUCTOS-->
        <ul class="nav navbar-nav" style="margin-left: auto" id="navbarontop">
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
            <form class="navbar-form navbar-left searchformmargin" role="search">
                <div class="form-group">
                    <input type="text" class="form-control searchform" size="25" maxlength="45" placeholder="Buscar Producto...">
                    <button class="searchbutton"><span class="glyphicon glyphicon-search "></span></button> 

                </div>
            </form>
             
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
    <div class="allcontain">
        <div class="feturedsection">
            <h1 class="text-center"><span class="bdots">&bullet;</span>P R O D U C T O S   &bullet;</h1>
        </div>
        <div class="grid">
            <div class="row">
                <div class="col-xs-12 col-sm-6 col-md-4 col-lg-3">
                    <div class="txthover">
                        <img src="image/car1.jpg" alt="car1">
                        <div class="txtcontent">
                            <div class="stars">
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                            </div>
                            <div class="simpletxt">
                                <h3 class="name">BUJIAS</h3>
                                <p>DESCRIPCION BUJIAS </p>
                                <h4 class="price">1000&euro;</h4>
                                <button>Agregar al Carrito</button><br>
                                <div class="wishtxt">
                                </div>
                            </div>
                            <div class="stars2">
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-xs-12 col-sm-6 col-md-4 col-lg-3 ">
                    <div class="txthover">
                        <img src="image/car2.jpg" alt="car2">
                        <div class="txtcontent">
                            <div class="stars">
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                            </div>
                            <div class="simpletxt">
                                <h3 class="name">Renault</h3>
                                <p>
                                    "Lorem ipsum dolor sit amet, consectetur,<br>
                                    sed do eiusmod tempor incididunt"
                                </p>
                                <h4 class="price">900 &euro;</h4>
                                <button>READ MORE</button><br>
                                <div class="wishtxt">
                                    <p class="paragraph1">Add to Wishlist <span class="glyphicon glyphicon-heart"></span></p>
                                    <p class="paragraph2">
                                        Compare <span class="icon">
                                            <img src="image/compicon.png" alt="compicon"></span>
                                    </p>
                                </div>
                            </div>
                            <div class="stars2">
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-xs-12 col-sm-6 col-md-4 col-lg-3">
                    <div class="txthover">
                        <img src="image/car3.jpg" alt="car3">
                        <div class="txtcontent">
                            <div class="stars">
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                            </div>
                            <div class="simpletxt">
                                <h3 class="name">Ford Mustang</h3>
                                <p>
                                    "Lorem ipsum dolor sit amet, consectetur,<br>
                                    sed do eiusmod tempor incididunt"
                                </p>
                                <h4 class="price">3000 &euro;</h4>
                                <button>READ MORE</button><br>
                                <div class="wishtxt">
                                    <p class="paragraph1">Add to Wishlist <span class="glyphicon glyphicon-heart"></span></p>
                                    <p class="paragraph2">
                                        Compare <span class="icon">
                                            <img src="image/compicon.png" alt="compicon"></span>
                                    </p>
                                </div>
                            </div>
                            <div class="stars2">
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-xs-12 col-sm-6 col-md-4 col-lg-3">
                    <div class="txthover">
                        <img src="image/car4.jpg" alt="car4">
                        <div class="txtcontent">
                            <div class="stars">
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                            </div>
                            <div class="simpletxt">
                                <h3 class="name">Rover</h3>
                                <p>
                                    "Lorem ipsum dolor sit amet, consectetur,<br>
                                    sed do eiusmod tempor incididunt"
                                </p>
                                <h4 class="price">1000 &euro;</h4>
                                <button>READ MORE</button><br>
                                <div class="wishtxt">
                                    <p class="paragraph1">Add to Wishlist <span class="glyphicon glyphicon-heart"></span></p>
                                    <p class="paragraph2">
                                        Compare <span class="icon">
                                            <img src="image/compicon.png" alt="compicon"></span>
                                    </p>
                                </div>
                            </div>
                            <div class="stars2">
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-xs-12 col-sm-6 col-md-4 col-lg-3">
                    <div class="txthover">
                        <img src="image/car5.jpg" alt="car5">
                        <div class="txtcontent">
                            <div class="stars">
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                            </div>
                            <div class="simpletxt">
                                <h3 class="name">Porche</h3>
                                <p>
                                    "Lorem ipsum dolor sit amet, consectetur,<br>
                                    sed do eiusmod tempor incididunt"
                                </p>
                                <h4 class="price">1200 &euro;</h4>
                                <button>READ MORE</button><br>
                                <div class="wishtxt">
                                    <p class="paragraph1">Add to Wishlist <span class="glyphicon glyphicon-heart"></span></p>
                                    <p class="paragraph2">
                                        Compare <span class="icon">
                                            <img src="image/compicon.png" alt="compicon"></span>
                                    </p>
                                </div>
                            </div>
                            <div class="stars2">
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-xs-12 col-sm-6 col-md-4 col-lg-3">
                    <div class="txthover">
                        <img src="image/car6.jpg" alt="car6">
                        <div class="txtcontent">
                            <div class="stars">
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                            </div>
                            <div class="simpletxt">
                                <h3 class="name">Porche 911</h3>
                                <p>
                                    "Lorem ipsum dolor sit amet, consectetur,<br>
                                    sed do eiusmod tempor incididunt"
                                </p>
                                <h4 class="price">4000 &euro;</h4>
                                <button>READ MORE</button><br>
                                <div class="wishtxt">
                                    <p class="paragraph1">Add to Wishlist <span class="glyphicon glyphicon-heart"></span></p>
                                    <p class="paragraph2">
                                        Compare <span class="icon">
                                            <img src="image/compicon.png" alt="compicon"></span>
                                    </p>
                                </div>
                            </div>
                            <div class="stars2">
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-xs-12 col-sm-6 col-md-4 col-lg-3">
                    <div class="txthover">
                        <img src="image/car7.jpg" alt="car7">
                        <div class="txtcontent">
                            <div class="stars">
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                            </div>
                            <div class="simpletxt">
                                <h3 class="name">Chevrolet SS</h3>
                                <p>
                                    "Lorem ipsum dolor sit amet, consectetur,<br>
                                    sed do eiusmod tempor incididunt"
                                </p>
                                <h4 class="price">3000 &euro;</h4>
                                <button>READ MORE</button><br>
                                <div class="wishtxt">
                                    <p class="paragraph1">Add to Wishlist <span class="glyphicon glyphicon-heart"></span></p>
                                    <p class="paragraph2">
                                        Compare <span class="icon">
                                            <img src="image/compicon.png" alt="compicon"></span>
                                    </p>
                                </div>
                            </div>
                            <div class="stars2">
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-xs-12 col-sm-6 col-md-4 col-lg-3">
                    <div class="txthover">
                        <img src="image/car8.jpg" alt="car8">
                        <div class="txtcontent">
                            <div class="stars">
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                            </div>
                            <div class="simpletxt">
                                <h3 class="name">Meclaren</h3>
                                <p>
                                    "Lorem ipsum dolor sit amet, consectetur,<br>
                                    sed do eiusmod tempor incididunt"
                                </p>
                                <h4 class="price">2500 &euro;</h4>
                                <button>READ MORE</button><br>
                                <div class="wishtxt">
                                    <p class="paragraph1">Add to Wishlist <span class="glyphicon glyphicon-heart"></span></p>
                                    <p class="paragraph2">
                                        Compare <span class="icon">
                                            <img src="image/compicon.png" alt="compicon"></span>
                                    </p>
                                </div>
                            </div>
                            <div class="stars2">
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                                <div class="glyphicon glyphicon-star"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
        	
   
</asp:Content>