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
            //Se comprueba que tipo de usuario está logueado en el Sistema.
            if (Session["Admin"] != null)
            {
                SiteMaster.usuarioEstaLogueado = 1;
            }
            else if (Session["UserLogin"] != null)
            {
                //Se le redirige a la página de error porque solo los admins deben ingresar a esta página
                Response.Redirect("Errores/NoPermitido.aspx.aspx");
            }
            LlenarCategoria();
        }

        protected void btnVerCateg_Click(object sender, EventArgs e)
        {
            
        }
        public void LlenarCategoria()
        {
            CategoriaBLL categoria = new CategoriaBLL();
            gvCategorias.DataSource = categoria.ObtenerCategoria();
            gvCategorias.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            CategoriaBLL categoria = new CategoriaBLL();
            //categoria.AgregarCategoria(TextBox1.Text, )
        }
    }
}