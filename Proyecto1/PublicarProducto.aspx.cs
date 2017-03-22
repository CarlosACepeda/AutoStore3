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
            //Se comprueba que tipo de usuario está logueado en el Sistema.
            if (Session["Admin"] != null)
            {
                //Se le redirige a la página de error porque solo los Usuarios deben ingresar a esta página
                Response.Redirect("Errores/NoPermitido.aspx");
            }
            else if (Session["UserLogin"] != null)
            {

                SiteMaster.usuarioEstaLogueado = 2;
            }
            //ImagenProductoBLL imagen = new ImagenProductoBLL();
            //byte imag= imagen.Mostrarimagen()
            //using (var ms = new System.IO.MemoryStream(byte.Parse(imag.ToString())))
            //{
            //    using (var img = Image.FromStream(ms))
            //    {

            //    }
            //}
        }



        protected void BtnExaminar_Click(object sender, EventArgs e)
        {

        }
        protected void BtnSubirProducto_Click(object sender, EventArgs e)
        {
            ProductoBLL productBLL = new ProductoBLL();
            ImagenProductoBLL imgBLL = new ImagenProductoBLL();
            UsuarioBLL usr = new UsuarioBLL();
            Guid idProducto = Guid.NewGuid();

            productBLL.AgregarProducto(idProducto, TextNombreProducto.Text, TextDescripcion.InnerText, Convert.ToInt32( TxtPrecio.Text),Convert.ToInt32( DDlMarca.SelectedValue), Guid.Parse(usr.TraerIdDeUsuarioLogueado().ToString()));
          
            if (FileUpload1.HasFile)
            {
                using (BinaryReader lector = new BinaryReader(FileUpload1.PostedFile.InputStream))
                {
                    byte[] imagen = lector.ReadBytes(FileUpload1.PostedFile.ContentLength);
                    imgBLL.InsertarImagen(idProducto, imagen);
                   
                }

            }
        }
    }
}




