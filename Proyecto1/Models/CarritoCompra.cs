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
        [Key]
        public int CarritoCompraID { get; set; }

        [Required, Display(Name = "Fecha Del Carrito")]
        public DateTime FechaOrden { get; set; }

        public double total { get; set; }


        //Zona de Relaciones

        //Relación con Usuario
        public Guid? UsuarioID { get; set; }
        public virtual Usuario Usuario { get; set; }

        //Relacion con Metodo de Pago(Temporal)

        
        public int MetodoPagoID { get; set; }
        public virtual MetodoDePago MetodoDePago { get; set; }

        //Relacion con ItemCarrito

        public ICollection<ItemCarrito> ItemsCarrito { get; set; }
        
        
        
    }
}