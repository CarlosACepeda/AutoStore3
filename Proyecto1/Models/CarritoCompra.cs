using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Proyecto1.Models
{
    public class CarritoCompra
    {
        [ScaffoldColumn(false)]

        public int IdOrden { get; set; }

        [Required, Display(Name = "Fecha orden")]
        public DateTime FechaOrden { get; set; }


        [Required, StringLength(50), Display(Name = "Direccion")]
        public string Direccion { get; set; }

        [Required, StringLength(20), Display(Name = "Ciudad")]
        public string Ciudad { get; set; }


        [Required, StringLength(20), Display(Name = "Estado de la orden")]
        public string EstadoOrden { get; set; }

        [Required, StringLength(20), Display(Name = "Pais")]
        public string Pais { get; set; }

        [Required, StringLength(20), Display(Name = "Telefono")]
        public int Telefono { get; set; }

        [Required, StringLength(20), Display(Name = "Email")]
        public string Email { get; set; }

        [Required, StringLength(20), Display(Name = "Total")]
        public int Total { get; set; }

        public virtual MetodoDePago MetodoPago { get; set; }

        public virtual Usuario user { get; set; }
        ItemCarrito detalle = new Models.ItemCarrito();

        public ICollection<ItemCarrito> DetalleOrden { get; set; }

        public bool RecuperarDetalle(CarritoCompra ord)
        {
            AutoStoreContext contexto = new AutoStoreContext();
            contexto.Orden.Add(ord);

            return true;

        }
        //public bool CalcularTotal()
        //{

        //}
        }
        
    }
}