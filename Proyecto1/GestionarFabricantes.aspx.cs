﻿using System;
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
        string nombre; 
        FabricanteCarroBLL fabricante = new FabricanteCarroBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            fabricante.AgregarFabricante(
                 TextBox1.Text = nombre
                );

        }

        protected void btnVerF_Click(object sender, EventArgs e)
        {
            gvFabricante.Visible = true;
            FabricanteCarroBLL fabricante = new FabricanteCarroBLL();
            gvFabricante.DataSource = fabricante.ObtenerFabricante();
            gvFabricante.DataBind();
        }
    }
}