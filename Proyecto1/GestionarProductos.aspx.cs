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
            ProductoBLL producBLL = new ProductoBLL();
            string id = Request.Params["ProductoID"];
            Guid idNum = Guid.Parse(id);

            producBLL.DesactivarProducto(idNum);
        }

        protected void btnVerP_Click(object sender, EventArgs e)
        {
           
        }
    }
}