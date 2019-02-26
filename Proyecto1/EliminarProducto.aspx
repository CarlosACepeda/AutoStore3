<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarProducto.aspx.cs" Inherits="Proyecto1.EliminarProducto" %>
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
            <br />
            <br />

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductoID" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="ProductoID" HeaderText="ProductoID" ReadOnly="True" SortExpression="ProductoID" />
            <asp:BoundField DataField="NombreProducto" HeaderText="NombreProducto" SortExpression="NombreProducto" />
            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
            <asp:BoundField DataField="PrecioU" HeaderText="PrecioU" SortExpression="PrecioU" />
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="Eliminar"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
   
    
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:AutoStoreContext %>" DeleteCommand="DELETE FROM [Productoes] WHERE [ProductoID] = @original_ProductoID AND [NombreProducto] = @original_NombreProducto AND [Descripcion] = @original_Descripcion AND [PrecioU] = @original_PrecioU" InsertCommand="INSERT INTO [Productoes] ([ProductoID], [NombreProducto], [Descripcion], [PrecioU]) VALUES (@ProductoID, @NombreProducto, @Descripcion, @PrecioU)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [ProductoID], [NombreProducto], [Descripcion], [PrecioU] FROM [Productoes]" UpdateCommand="UPDATE [Productoes] SET [NombreProducto] = @NombreProducto, [Descripcion] = @Descripcion, [PrecioU] = @PrecioU WHERE [ProductoID] = @original_ProductoID AND [NombreProducto] = @original_NombreProducto AND [Descripcion] = @original_Descripcion AND [PrecioU] = @original_PrecioU">
        <DeleteParameters>
            <asp:Parameter Name="original_ProductoID" Type="Object" />
            <asp:Parameter Name="original_NombreProducto" Type="String" />
            <asp:Parameter Name="original_Descripcion" Type="String" />
            <asp:Parameter Name="original_PrecioU" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="ProductoID" Type="Object" />
            <asp:Parameter Name="NombreProducto" Type="String" />
            <asp:Parameter Name="Descripcion" Type="String" />
            <asp:Parameter Name="PrecioU" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="NombreProducto" Type="String" />
            <asp:Parameter Name="Descripcion" Type="String" />
            <asp:Parameter Name="PrecioU" Type="Int32" />
            <asp:Parameter Name="original_ProductoID" Type="Object" />
            <asp:Parameter Name="original_NombreProducto" Type="String" />
            <asp:Parameter Name="original_Descripcion" Type="String" />
            <asp:Parameter Name="original_PrecioU" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
   
    
    
</asp:Content>
