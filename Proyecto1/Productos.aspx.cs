using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto1.Logica;
using Proyecto1.Models;

namespace Proyecto1
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SiteMaster.usuarioEstaLogueado = 2;
        }
        public List<Models.Producto> ObtenerProductos()
        {
            ProductoBLL producto = new ProductoBLL();
            return producto.ObtenerProducto();
        }
        public void LlenarGrilla()
        {
            ProductoBLL product = new ProductoBLL();
            gvProductos.DataSource = product.ObtenerProducto();
            gvProductos.DataMember = txtBuscar.Text;
            gvProductos.DataBind();

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            LlenarGrilla();
        }

        protected void gvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            Session["IdProducto"] = gvProductos.Columns[1];
            Session["NombreP"] = gvProductos.Columns[2];
            Session["Descripcion"] = gvProductos.Columns[3];
            Session["PrecioU"] = gvProductos.Columns[4];
            Session["UsuarioId"] = gvProductos.Columns[6];
            Session["MarcaP"] = gvProductos.Columns[7];
            Response.Redirect("DescripcionProducto.aspx");
        }
    }
}