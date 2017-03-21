using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto1
{
    public partial class DescripcionProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["IdProducto"].ToString();
            Label2.Text = Session["NombreP"].ToString();
            Label3.Text = Session["Descripcion"].ToString();
            Label4.Text = Session["PrecioU"].ToString();
            Label5.Text = Session["UsuarioId"].ToString();
            Label6.Text = Session["MarcaP"].ToString();

        }
    }
}