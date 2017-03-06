using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto1.Logica;

namespace Proyecto1
{
    public partial class GestionarCategorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVerCateg_Click(object sender, EventArgs e)
        {
            gvCategorias.Visible = true;
            CategoriaBLL categoria = new CategoriaBLL();
            gvCategorias.DataSource = categoria.ObtenerCategoria();
            gvCategorias.DataBind();
        }
    }
}