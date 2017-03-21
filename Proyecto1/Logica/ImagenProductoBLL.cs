using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto1.Models;
using System.Drawing;

namespace Proyecto1.Logica
{
    public class ImagenProductoBLL
    {
        /// <summary>
        /// Metodo para guardar la ruta de la imagen del producto
        /// </summary>
        /// <param name="imagen">Para que captura la ruta de la imagen</param>
        /// <returns></returns>                      
        public bool InsertarImagen(Guid productoID, byte[] imagen)
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
        public byte MostrarImagen(Guid productoID)
        {
            AutoStoreContext contexto = new AutoStoreContext();
            UsuarioBLL user = new UsuarioBLL();
            var imag = from img in contexto.ImagenProducto
                       where img.ProductoID == productoID
                       select img.Imagen.SingleOrDefault();

            return byte.Parse(imag.ToString());

            }
        }
    }
        