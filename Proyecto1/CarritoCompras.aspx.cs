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
    public partial class VerOrden : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarCarrito();
        }
        public List<ItemCarrito> LlenarCarrito()
        {
            CarritoComprasBLL carro = new CarritoComprasBLL();
            return carro.ObtenerItemCarrito().ToList();
        }
        public void UpdateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}