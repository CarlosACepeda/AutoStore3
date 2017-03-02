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
        public bool ObtenerImagen(string imagen)
        {
            try
            {
                ImagenProducto Imgproducto = new ImagenProducto
                {
                    Imagen=imagen
                };
                AutoStoreContext contexto = new AutoStoreContext();
                contexto.ImagenProducto.Add(Imgproducto);
                return true;
            }


            catch (Exception)
            {
                return false;
            }
        }
    }
}