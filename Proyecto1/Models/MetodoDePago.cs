using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Proyecto1.Models
{
    public class MetodoDePago
    {
        [ScaffoldColumn(false)]

        public int IdMetodoPago { get; set; }

        [Required, StringLength(30) Display(Name = "Metodo de pago")]

        public string Metodo { get; set; }

        [Required, StringLength(30) Display(Name = "descripcion")]
        public string Descripcion { get; set; }

       public virtual CarritoCompra Orden { get; set; }

    }
}