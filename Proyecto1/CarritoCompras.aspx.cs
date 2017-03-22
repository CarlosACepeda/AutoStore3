using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto1.Logica;
using Proyecto1.Models;
using System.Collections.Specialized;

namespace Proyecto1
{
    public partial class VerOrden : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Se comprueba que tipo de usuario está logueado en el Sistema.
            if (Session["Admin"] != null)
            {
                //Se le redirige a la página de error porque solo los Usuarios deben ingresar a esta página
                Response.Redirect("Errores/NoPermitido.aspx.aspx");
            }
            else if (Session["UserLogin"] != null)
            {

                SiteMaster.usuarioEstaLogueado = 2;
            }
            CarritoComprasBLL carrito = new CarritoComprasBLL();

            LlenarCarrito();


            decimal totalCarrito = 0;
            totalCarrito = carrito.ObtenerTotal();
            if (totalCarrito > 0)
            {
                LblTotal.Text = totalCarrito.ToString();
            }
            else
            {
                LabelTotalTexto.Text = "";
                LblTotal.Text = "";
                CarritoComprasTitulo.InnerText = "El carrito está vacio";
                UpdateBtn.Visible = false;
            }
        }
        public List<ItemCarrito> LlenarCarrito()
        {
            CarritoComprasBLL carro = new CarritoComprasBLL();
            return carro.ObtenerItemCarrito().ToList();
        }
        public void UpdateBtn_Click(object sender, EventArgs e)
        {
            ActualizarCarrito();
        }

        public List<ItemCarrito> ActualizarCarrito()
        {
            CarritoComprasBLL carrito = new CarritoComprasBLL();
            string idCarro = carrito.ObtenerItemId();
            CarritoComprasBLL.ActualizacionesCarrito[] actualizarCarro = new CarritoComprasBLL.ActualizacionesCarrito[gvCarrito.Rows.Count];
            for (int i = 0; i < gvCarrito.Rows.Count; i++)
            {
                IOrderedDictionary valoresDeFila = new OrderedDictionary();
                valoresDeFila = ObtenerValores(gvCarrito.Rows[i]);
                actualizarCarro[i].ProductoID = Guid.Parse(valoresDeFila["ProductoID"].ToString());

                CheckBox cbQuitar = new CheckBox();
                cbQuitar = (CheckBox)gvCarrito.Rows[i].FindControl("Remover");
                actualizarCarro[i].QuitarItem = cbQuitar.Checked;

                TextBox txtCantidad = new TextBox();
                txtCantidad = (TextBox)gvCarrito.Rows[i].FindControl("txtCantidad");
                actualizarCarro[i].CantidaddeCompra = Convert.ToInt16(txtCantidad.Text.ToString());

            }
            carrito.ActualizarCarritoDB(idCarro, actualizarCarro);
            gvCarrito.DataBind();
            LblTotal.Text = carrito.ObtenerTotal().ToString();
            return carrito.ObtenerItemCarrito();

        }
        public static IOrderedDictionary ObtenerValores(GridViewRow row)
        {
            IOrderedDictionary valores = new OrderedDictionary();
            foreach (DataControlFieldCell celda in row.Cells)
            {
                celda.ContainingField.ExtractValuesFromCell(valores, celda, row.RowState, true);
            }
            return valores;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            UsuarioBLL persona = new UsuarioBLL();
            persona.TraerIdDeUsuarioLogueado();
        }
    }
}