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

        public Guid IdDetalleOrden { get; set; }

        [Required, Display(Name = "Cantidad")]
        public int Cantidad { get; set; }
        //
        public virtual CarritoCompra orden { get; set; }
        public virtual Producto producto { get; set; }

    }
}