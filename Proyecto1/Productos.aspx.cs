using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto1.Logica;
using Proyecto1.Models;

namespace Proyecto1
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SiteMaster.usuarioEstaLogueado = 2;
        }
        public List<Models.Producto> ObtenerProductos()
        {
            ProductoBLL producto = new ProductoBLL();
            return producto.ObtenerProducto();
        }
    }
}