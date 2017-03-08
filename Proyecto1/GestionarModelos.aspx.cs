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
            CargarModelos();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FabricanteCarroBLL lista = new FabricanteCarroBLL();

            lista.ObtenerFabricante();


            //modelo.AgregarModeloCarro(
            //    TextBox1.Text,
            //    TextBox2.Text,

            //);
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