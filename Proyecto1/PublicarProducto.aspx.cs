using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto1;
using Proyecto1.Models;
using Proyecto1.Logica;




namespace Proyecto1
{
    public partial class PublicarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void BtnExaminar_Click(object sender, EventArgs e)
        {

        }
        protected void BtnSubirProducto_Click(object sender, EventArgs e)
        {
            ProductoBLL productBLL = new ProductoBLL();
            ImagenProductoBLL imgBLL = new ImagenProductoBLL();
            UsuarioBLL usr = new UsuarioBLL();


            productBLL.AgregarProducto(TextNombreProducto.Text, TextDescripcion.InnerText, Convert.ToInt32( TxtPrecio.Text),Convert.ToInt32( DDlMarca.SelectedValue),usr.TraerIdDeUsuarioLogueado());

            if (FileUpload1.HasFile)
            {
                using (BinaryReader lector = new BinaryReader(FileUpload1.PostedFile.InputStream))
                {
                    byte[] imagen = lector.ReadBytes(FileUpload1.PostedFile.ContentLength);
                    imgBLL.ObtenerImagen(imagen);
                }

            }
        }
    }
}




