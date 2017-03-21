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
            string idProduct = Request.QueryString["ProductoID"];
            int idP;

            if (!string.IsNullOrEmpty(idProduct)&& int.TryParse(idProduct, out idP))
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