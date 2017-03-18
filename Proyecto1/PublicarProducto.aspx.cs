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
            if (FileUpload1.HasFile)
            {
                string BD = Server.MapPath("./Imagen/");
                string FileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
                FileUpload1.PostedFile.SaveAs(BD + FileName);

                ImagenProductoBLL ImgProducto = new ImagenProductoBLL();
                ImagenProducto p = new ImagenProducto();
                {
                    ImgProducto.ObtenerImagen(
                       Convert.ToString(FileUpload1)
                        );
                }
            }
        }
    }
}


            
    
