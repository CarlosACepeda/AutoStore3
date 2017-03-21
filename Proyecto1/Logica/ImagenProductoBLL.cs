using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto1.Models;

namespace Proyecto1.Logica
{
    public class ImagenProductoBLL
    {
        /// <summary>
        /// Metodo para guardar la ruta de la imagen del producto
        /// </summary>
        /// <param name="imagen">Para que captura la ruta de la imagen</param>
        /// <returns></returns>                      
        public bool ObtenerImagen(Guid productoID, byte[] imagen)
        {
            AutoStoreContext contexto = new AutoStoreContext();
            ImagenProducto img = new ImagenProducto
            {
                ProductoID = productoID,
                Imagen = imagen
            };
            contexto.ImagenProducto.Add(img);
            contexto.SaveChanges();
            return true;
        }
        public void Mostrarimagen()
        {
            AutoStoreContext contexto = new AutoStoreContext();
            var imag = from img in contexto.ImagenProducto
                       where img.Imagen == img.Imagen
                       select img;

        }
    }
}
        