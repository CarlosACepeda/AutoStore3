using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Proyecto1.Models
{
    public class DetalleOrden
    {
        [ScaffoldColumn(false)]

        public int IdDetalleOrden { get; set; }

        [Required,  Display(Name = "Cantidad")]
        public int Cantidad { get; set; }

        [Required, Display(Name = "Precio Unitario")]
        public int PrecioUnitario { get; set; }

        public virtual Orden orden { get; set; }
        public virtual Producto producto { get; set; }


    }
}