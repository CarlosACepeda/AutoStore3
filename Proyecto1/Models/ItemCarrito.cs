using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Proyecto1.Models
{
    public class ItemCarrito
    {
        [ScaffoldColumn(false)]

        [Key]
        public int ItemCarritoID { get; set; }

        [Required, Display(Name = "Cantidad")]
        public int Cantidad { get; set; }
        

        //Zona de Relaciones

        //Relacion con Carrito Compra.
        public int CarritoCompraID { get; set; }
        public virtual CarritoCompra CarritoCompra { get; set; }

    }
}