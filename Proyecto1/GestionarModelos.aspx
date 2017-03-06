<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GestionarModelos.aspx.cs" Inherits="Proyecto1.GestionarModelos" %>
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
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>

        <asp:Button ID="btnVer" runat="server" Text="Ver Modelos" OnClick="btnVer_Click"/>
        
        <asp:GridView ID="gvModelo" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Visible="False">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        </form>
</asp:Content>
