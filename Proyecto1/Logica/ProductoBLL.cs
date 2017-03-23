using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto1.Models;
using System.IO;
using System.Drawing;

namespace Proyecto1.Logica
{
    public class ProductoBLL
    {
        /// <summary>
        /// Metodo para agregar un producto
        /// </summary>
        /// <param name="nombreP">Parametro que captura el nombre del producto</param>
        /// <param name="descripcion">Parametro que captura la descripcion del producto</param>
        /// <param name="precioU">Parametro que captura el precio unitario del producto</param>
        /// <param name="marcaProducto">Parametro que captura la marca de producto a la cual pertence el producto</param>
        /// <param name="idUsuario">Parametro que captura el id del usuario que ha subido el producto</param>
        /// <param name="idCategoria">Parametro que captura el id de la categoria a la que pertenece el producto</param>
        /// <param name="activo">Parametro que captura el estado del producto</param>
        /// <returns>Retorna un valor booleano segun la ejecucion del metodo</returns>
        public bool AgregarProducto(Guid idProducto, string nombreP, string descripcion, int precioU, int marcaProducto, Guid idUsuario, bool activo = true)
        {

            try
            {
                Producto producto = new Producto
                {
                    ProductoID= idProducto,
                    NombreProducto = nombreP,
                    Descripcion = descripcion,
                    PrecioU = precioU,
                    MarcaProductoID = marcaProducto,
                    UsuarioID = idUsuario,
                };
                AutoStoreContext contexto = new AutoStoreContext();
                contexto.Producto.Add(producto);
                contexto.SaveChanges();
                return true;
            }


            catch (Exception)
            {
                return false;
            }



        }

        /// <summary>
        /// Metodo que se encarga de modificar un producto
        /// </summary>
        /// <param name="p">Parametro que captura todos los datos de la clase producto para poder modificarlos</param>
        /// <returns>Retorna un valor booleano segun la ejecucion del metodo</returns>
        public bool ModificarProducto(Producto p)
        {
            AutoStoreContext contexto = new AutoStoreContext();
            var ModificarProducto = from c in contexto.Producto
                                    where c.ProductoID == p.ProductoID
                                    select c;

            //Ejecutar la consulta y cambiar los valores que se requiera.

            foreach (var prod in ModificarProducto)
            {
                prod.NombreProducto = p.NombreProducto;
                prod.Descripcion = p.Descripcion;
                prod.ImagenesProductos = p.ImagenesProductos;
                prod.PrecioU = p.PrecioU;
                prod.MarcaProductoID = p.MarcaProductoID;
                prod.UsuarioID = p.UsuarioID;
            }

            try
            {
                contexto.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;    
        }
        /// <summary>
        /// Metodo que se encarga de desactivar un producto
        /// </summary>
        /// <param name="idProducto">Parametro que permite traer el id del producto que se desea desactivar</param>
        /// <returns>Retorna un valor booleano segun la ejecucion del metodo</returns>
        public bool DesactivarProducto(Guid idProducto)
        {
            //Consulta para traer el producto que se desea desactivar
            AutoStoreContext contexto = new Models.AutoStoreContext();
            var desactivarProducto = from c in contexto.Producto
                                     where c.ProductoID == idProducto
                                     select c;

            //Ejecutar la consulta y cambiar los valores que se requiera.

            foreach (Producto prod in desactivarProducto)
            {
                if (prod.Activo == true)
                {
                    prod.Activo = false;
                }
                else
                {
                    prod.Activo = true;
                }
            }
            try
            {
                contexto.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }
        public Producto ObtenerProducto()
        {
            AutoStoreContext context = new AutoStoreContext();
            var mostrarProducto = from Fab in context.Producto
                                    select Fab;
            return mostrarProducto.FirstOrDefault();
        }
        
    }
}