﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto1.Models;
using Proyecto1.Logica;

namespace Proyecto1
{
    public partial class GestionarMarcas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarcgarMarcas();
            SiteMaster.usuarioEstaLogueado = 1;
        }

        protected void btnVerMarcas_Click(object sender, EventArgs e)
        {
           

        }
        public void CarcgarMarcas()
        {
            AutoStoreContext contex = new AutoStoreContext();

            MarcaProductoBLL marca = new MarcaProductoBLL();
            gvMarcas.DataSource = marca.ObtenerMarcaP();
            gvMarcas.DataBind();
        }
    }
}