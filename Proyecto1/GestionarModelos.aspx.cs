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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            gvModelo.Visible = true;
            ModeloCarroBLL modelo = new ModeloCarroBLL();
            gvModelo.DataSource = modelo.ObtenerModeloCarro();
            gvModelo.DataBind();

        }
    }
}