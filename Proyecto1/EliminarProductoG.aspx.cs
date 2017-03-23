using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto1.Logica;

namespace Proyecto1
{
    public partial class EliminarProductoG : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ProductoBLL producBLL = new ProductoBLL();
            Guid id = Guid.Parse(Request.Params["ProductoID"].ToString());
            producBLL.DesactivarProducto(id);
            Response.Redirect("GestionarProductos.aspx");
        }
    }
}