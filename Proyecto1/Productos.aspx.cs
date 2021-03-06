﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto1.Logica;
using Proyecto1.Models;
using System.Data.Linq.SqlClient;

namespace Proyecto1
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Se comprueba que tipo de usuario está logueado en el Sistema.
            if (Session["Admin"] != null)
            {
                //Se le redirige a la página de error porque solo los Usuarios deben ingresar a esta página
                Response.Redirect("Errores/NoPermitido.aspx");
            }
            else if (Session["UserLogin"] != null)
            {

                SiteMaster.usuarioEstaLogueado = 2;
            }
        }
        public List<Producto> ObtenerProductos()
        {
            ProductoBLL producto = new ProductoBLL();
            return producto.ObtenerProducto();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                using (AutoStoreContext contexto = new AutoStoreContext())
                {
                    string valor = txtBuscar.Text;
                    Producto prod = new Producto();

                    var consulta = from c in contexto.Producto
                                   where c.NombreProducto.Contains(txtBuscar.Text)
                                   select c;

                    gvProductos.DataSource = consulta.ToList();
                    gvProductos.DataBind();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    

        protected void gvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        protected void btnVer_Click(object sender, EventArgs e)
        {            
            Session["IdProducto"] = gvProductos.Rows[0].Cells[1].Text;
            Session["NombreP"] = gvProductos.Rows[0].Cells[2].Text;
            Session["Descripcion"] = gvProductos.Rows[0].Cells[3].Text;
            Session["PrecioU"] = gvProductos.Rows[0].Cells[4].Text;
            Session["UsuarioId"] = gvProductos.Rows[0].Cells[6].Text;
            Session["MarcaP"] = gvProductos.Rows[0].Cells[7].Text;
            Response.Redirect("DescripcionProducto.aspx");

        }

        //protected void Button4_Click(object sender, EventArgs e)
        //{
        //    TextBox1.Text = gvProductos.Rows[1].Cells[1].Text;
        //}
    }
}