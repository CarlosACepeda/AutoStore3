using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto1.Logica;

namespace Proyecto1
{
    public partial class GestionarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVerP_Click(object sender, EventArgs e)
        {
            gvProductos.Visible = true;
            ProductoBLL producto = new ProductoBLL();
            gvProductos.DataSource = producto.ObtenerProducto();
            gvProductos.DataBind();
        }
    }
}