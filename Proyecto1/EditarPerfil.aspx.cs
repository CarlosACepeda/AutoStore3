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
            CargarInfoDeUsuario();
        }
        protected void CargarInfoDeUsuario()
        {
            PersonaBLL persona = new PersonaBLL();
            txtNombre.Text = persona.TraerPersona().Select(n => n.PersonaID).ToList().ToString();
        }

        
    }
}