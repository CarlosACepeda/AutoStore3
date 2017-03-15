using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto1.Logica;


namespace Proyecto1
{
    public partial class EliminarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoBLL producBLL = new ProductoBLL();
            string id = Request.Params["ProductoID"];
            int idNum = Convert.ToInt32(id);

            producBLL.DesactivarProducto(idNum);


        }

    }
}