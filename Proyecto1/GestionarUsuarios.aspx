<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GestionarUsuarios.aspx.cs" Inherits="Proyecto1.GestionarUsuarios" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <form id="form1" runat="server">
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
            <asp:Button ID="btnVerUser" runat="server" Text="Ver Usuarios" OnClick="btnVerUser_Click"/>

            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
&nbsp;<div class="form-group">
                <asp:GridView ID="gvUser" runat="server">
                </asp:GridView>

                <br />
                <asp:TextBox ID="TextBox1" runat="server" Width="231px"></asp:TextBox>

      </div>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cambiar Estado" />
            <br />


            </form>
</asp:Content>
