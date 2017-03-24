using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto1.Logica;

namespace Proyecto1
{
    public partial class GestionarModelos : System.Web.UI.Page
    {
        ModeloCarroBLL modelo = new ModeloCarroBLL();
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
                Response.Redirect("Errores/NoPermitido.aspx");
            }
            CargarModelos();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CategoriaBLL cat = new CategoriaBLL();
            ModeloCarroBLL modelo = new ModeloCarroBLL();
            FabricanteCarroBLL fabC = new FabricanteCarroBLL();
            cat.ObtenerCategoria();
            modelo.AgregarModeloCarro(
                TextBox1.Text,
                int.Parse(DropDownList1.SelectedValue)
            );
        }

        public void CargarModelos()
        {
            ModeloCarroBLL modelo = new ModeloCarroBLL();
            gvModelo.DataSource = modelo.ObtenerModeloCarro();
            gvModelo.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}