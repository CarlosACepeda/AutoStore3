using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto1.Logica;
using Proyecto1.Models;
using System.Diagnostics;

namespace Proyecto1
{
    public partial class AgregarAlCarro : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            // Se comprueba que tipo de usuario está logueado en el Sistema.
            if (Session["Admin"] != null)
            {
                //Se le redirige a la página de error porque solo los Usuarios deben ingresar a esta página
                Response.Redirect("Errores/NoPermitido.aspx");
            }
            else if (Session["UserLogin"] != null)
            {

                SiteMaster.usuarioEstaLogueado = 2;
            }
            string idProduct = Request.QueryString["ProductoID"];

            if (!string.IsNullOrEmpty(idProduct))
            {
                CarritoComprasBLL carrito = new CarritoComprasBLL();

                carrito.AnadirAlCarro(Guid.Parse(idProduct));
            }
            else
            {
                Debug.Fail("Error : No se puede agregar al carro sin una ID");
                throw new Exception("Error no se cargo el ID");
            }
            Response.Redirect("CarritoCompras.aspx");
        }
    }
}