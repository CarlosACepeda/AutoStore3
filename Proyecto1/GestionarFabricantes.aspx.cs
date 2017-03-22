using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto1.Logica;

namespace Proyecto1
{
    public partial class GestionarFabricantes : System.Web.UI.Page
    {
        

        FabricanteCarroBLL fabricante = new FabricanteCarroBLL();
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
            ListarF();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            fabricante.AgregarFabricante(
                 TextBox1.Text
                );

        }

        protected void btnVerF_Click(object sender, EventArgs e)
        {
           
        }
        public void ListarF()
        {
            FabricanteCarroBLL fabricante = new FabricanteCarroBLL();
            gvFabricante.DataSource = fabricante.ObtenerFabricante();
            gvFabricante.DataBind();
        }
    }
}