using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto1.Models;

namespace Proyecto1.Logica
{
    public class CarritoComprasBLL
    {

        public const string sessionCarro = "sessionCarro";
        
        public string CarritoId { get; set; }
        AutoStoreContext context = new AutoStoreContext();

        /// <summary>
        /// Metodo en el cual se añadiran los item al carrito
        /// </summary>
        /// <param name="NombreUsuario">Parametro para asignar el carro a un usuario especifico </param>
        /// <param name="idProducto"> Parametro que proporcionara que producto esta en el carro</param>
        public void AnadirAlCarro(int idProducto)
        {
            CarritoId = ObtenerItemId();
            var obtenerItem = context.ItemCarrito.SingleOrDefault(c => c.NombreUsuario == CarritoId && c.ProductoID == idProducto);
            if (obtenerItem == null)
            {
                ItemCarrito Icarrito = new ItemCarrito
                {
                    ItemCarritoID = Guid.NewGuid().ToString(),
                    NombreUsuario = CarritoId,
                    Producto = context.Producto.SingleOrDefault(p => p.ProductoID == idProducto),
                    Cantidad = 1

                }; context.ItemCarrito.Add(Icarrito);
            }
            else
            {
                obtenerItem.Cantidad++;
            }
            context.SaveChanges();
        }
        /// <summary>
        /// Metodo donde se obtiene el id del item
        /// </summary>
        /// <returns></returns>
        public string ObtenerItemId()
        {
            HttpContext.Current.Session[sessionCarro] = HttpContext.Current.Session["UserLogin"];

            if (HttpContext.Current.Session[sessionCarro] == null)
            {
                string nombreUser = null;

                if (!string.IsNullOrWhiteSpace(nombreUser))
                {
                    HttpContext.Current.Session[sessionCarro] = nombreUser;
                }
                else
                {
                    Guid usuarioNL = new Guid();
                    HttpContext.Current.Session[sessionCarro] = usuarioNL.ToString();
                }

            }
            return HttpContext.Current.Session[sessionCarro].ToString();
        }
        /// <summary>
        /// Metodo para obtener los items que pertenecen al carrito
        /// </summary>
        /// <returns></returns>
        public List<ItemCarrito> ObtenerItemCarrito()
        {
            AutoStoreContext contexto = new AutoStoreContext();
            CarritoId = ObtenerItemId();

            var regresarItems = from itm in context.ItemCarrito
                                where itm.NombreUsuario == CarritoId
                                select itm;
            return regresarItems.ToList();


        }
        public void RemoverItem(string RemoverCarrito, int idItem)
        {
            using (var context = new Proyecto1.Models.AutoStoreContext())
            {
                try
                {
                    var Item = (from c in context.ItemCarrito
                                where c.NombreUsuario == RemoverCarrito
                                && c.Producto.ProductoID == idItem
                                select c).FirstOrDefault();
                    if (Item != null)
                    {
                        context.ItemCarrito.Remove(Item);
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("No se puede remover el item del carrito");
                }
            }
        }
        /// <summary>
        /// Metodo para actualizar la informacion del carrito
        /// </summary>
        /// <param name="actualizarCarritoId"> Parametro que trae el id del carrito</param>
        /// <param name="actualizarProductoId">Parametro que especifica que productos existen en el carrito </param>
        /// <param name="cantidad">Parametro que especifica la cantidad proveniente del item del carrito</param>
        public void ActualizarCarro(string actualizarCarritoId, int actualizarProductoId, int cantidad)
        {
            using (var context = new Proyecto1.Models.AutoStoreContext())
            {
                try
                {
                    var Item = (from c in context.ItemCarrito
                                where c.NombreUsuario == actualizarCarritoId && c.Producto.ProductoID == actualizarProductoId
                                select c).FirstOrDefault();
                    if (Item != null)
                    {
                        Item.Cantidad = cantidad;
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("No se puede actualizar el item del carrito");
                }
            }

        }
        /// <summary>
        /// Metodo para vaciar el carrito
        /// </summary>
        public void VaciarCarrito()
        {
            CarritoId = ObtenerItemId();
            var itemCarrito = context.ItemCarrito.Where(c => c.ItemCarritoID == CarritoId);
            foreach (var item in itemCarrito)
            {
                context.ItemCarrito.Remove(item);
            }
            context.SaveChanges();
        }
        /// <summary>
        /// Metodo que lleva la contabilidad de los productos existentes en el carrito
        /// </summary>
        /// <returns>Retorna el valor segun la existencia de productos</returns>
        public int ObtenerContador()
        {
            CarritoId = ObtenerItemId();
            int? contar = (from ItemC in context.ItemCarrito where ItemC.ItemCarritoID == CarritoId select (int?)ItemC.Cantidad).Sum();
            return contar ?? 0;
        }
        //public bool GuardarOrden(Guid idUsuario)
        //{
        //    var gurdarOrden = from c in context.Usuario
        //                            where c.IdUsuario == idUsuario
        //                            select c;

        //    //Ejecutar la consulta y cambiar los valores que se requiera.

        //    foreach (var user in gurdarOrden)
        //    {
        //        user.CarritosDeCompra = 

        //    }
        //}

            /// <summary>
            /// Metodo que permite obtener el total del carrito de compras
            /// </summary>
            /// <returns>Retorna el total de los productos</returns>
        public decimal ObtenerTotal()
        {
            CarritoId = ObtenerItemId();
            decimal? total = decimal.Zero;
            total = (decimal?)(from item in context.ItemCarrito
                               where item.NombreUsuario == CarritoId
                               select (int?)item.Cantidad * item.Producto.PrecioU).Sum();
            return total ?? decimal.Zero;
        }
        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
                context = null;
            }
        }

        public CarritoComprasBLL ObtenerCar (HttpContext contexto)
        {
            CarritoComprasBLL car = new CarritoComprasBLL();
                 car.CarritoId = car.ObtenerItemId();
                return car;
            
        }
        public struct ActualizacionesCarrito
        {
            public int ProductoID;
            public int CantidaddeCompra;
            public bool QuitarItem;
        }

        public void ActualizarCarritoDB(String carroID, ActualizacionesCarrito[] CartItemUpdates)
        {
            AutoStoreContext contexto = new AutoStoreContext();
                try
                {
                    int cuentadeItems = CartItemUpdates.Count();
                    List<ItemCarrito> miCarrito = ObtenerItemCarrito();
                    foreach (var cartItem in miCarrito)
                    {
                        for (int i = 0; i < cuentadeItems; i++)
                        {
                            if (cartItem.Producto.ProductoID == CartItemUpdates[i].ProductoID)
                            {
                                if (CartItemUpdates[i].CantidaddeCompra < 1 || CartItemUpdates[i].QuitarItem == true)
                                {
                                    RemoverItem(carroID, cartItem.ProductoID);
                                }
                                else
                                {
                                    ActualizarCarro(carroID, cartItem.ProductoID, CartItemUpdates[i].CantidaddeCompra);
                                }
                            }
                        }
                    }
                }
                catch (Exception exp)
                {

                    throw new Exception("Error: No se puede actualizar la base de datos del carrio - " + exp.Message.ToString(), exp);

                }
            }
        }

    }
