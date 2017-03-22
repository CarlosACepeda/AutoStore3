using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto1
{
    public partial class CheckoutStart : System.Web.UI.Page
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
        }
    }
}