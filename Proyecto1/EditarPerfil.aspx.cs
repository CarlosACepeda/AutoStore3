using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto1.Models;
using Proyecto1.Logica;

namespace Proyecto1
{
    public partial class EditarPerfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SiteMaster.usuarioEstaLogueado = 2;
        }
        //public void btnVerI_Click(object sender, EventArgs e)
        //{
            
        //}

        protected void btnVerI_Click(object sender, EventArgs e)
        {
            AutoStoreContext contex = new AutoStoreContext();
            Proyecto1.Logica.UsuarioBLL user = new UsuarioBLL();

            UsuarioBLL list = new UsuarioBLL();
            gvPerfil.DataSource = list.MostrarInformacion(Guid.Parse("91fb22da-d1fa-40e9-8b2f-00223d40e8e7"));
            gvPerfil.DataBind();

        }
        
    }
}