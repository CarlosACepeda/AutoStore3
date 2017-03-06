using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto1.Logica;

namespace Proyecto1
{
    public partial class GestionarUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                
        }

        protected void btnVerUser_Click(object sender, EventArgs e)
        {
            gvUser.Visible = true;
            UsuarioBLL user = new UsuarioBLL();
            gvUser.DataSource = user.ListarUsuarios();
            gvUser.DataBind();
            //gvUser.Rows[0].Cells[4].Enabled = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UsuarioBLL user = new UsuarioBLL();
            user.CambiarEstadoUser(Guid.Parse(TextBox1.Text));
        }

        protected void gvUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}