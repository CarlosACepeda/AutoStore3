using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto1;
using Proyecto1.Models;
using Proyecto1.Logica;
using System.IO;




namespace Proyecto1
{
    public partial class PublicarProducto : System.Web.UI.Page
    {
        Guid idProducto = Guid.NewGuid();
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
                
            }

        }



        protected void BtnExaminar_Click(object sender, EventArgs e)
        {

        }
        protected void BtnSubirProducto_Click(object sender, EventArgs e)
        {
            ProductoBLL productBLL = new ProductoBLL();
            ImagenProductoBLL imgBLL = new ImagenProductoBLL();
            UsuarioBLL usr = new UsuarioBLL();
            

            productBLL.AgregarProducto(idProducto, TextNombreProducto.Text, TextDescripcion.InnerText, Convert.ToInt32( TxtPrecio.Text),Convert.ToInt32( DDlMarca.SelectedValue), Guid.Parse(usr.TraerIdDeUsuarioLogueado().ToString()));
            
            if (FileUpload1.HasFile)
            {
                using (BinaryReader lector = new BinaryReader(FileUpload1.PostedFile.InputStream))
                {
                    byte[] imagen = lector.ReadBytes(FileUpload1.PostedFile.ContentLength);
                    imgBLL.InsertarImagen(idProducto, imagen);
                    Limpiar();
                    LblMensaje.Text = "<h1>Producto publicado con exito</h1>"; 
                }

            }
        }

        public void Limpiar()
        {
            TextNombreProducto.Text = "";
            TextDescripcion.InnerText = "";
            TxtPrecio.Text = "";
        }
        public System.Drawing.Image TraerImagenProducto()
        {
            ImagenProductoBLL imag = new ImagenProductoBLL();

            MemoryStream memoryStream = new MemoryStream(imag.MostrarImagen(idProducto));
            System.Drawing.Image regresarImagen = System.Drawing.Image.FromStream(memoryStream);
            return regresarImagen;
           
        }
    }
}




