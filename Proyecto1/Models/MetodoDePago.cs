using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto1.Models
{
    public class MetodoDePago
    {
        [ScaffoldColumn(false)]

        [Key]
        public int MetodoDePagoID { get; set; }

        [Required, StringLength(30) Display(Name = "Metodo de pago")]

        public string Metodo { get; set; }

        [Required, StringLength(30) Display(Name = "descripcion")]
        public string Descripcion { get; set; }


        //Zona de Relaciones
       // [ForeignKey("CarritoCompra")]
       // public int CarritoDeCompraID { get; set; }
       //public virtual CarritoCompra CarritoDeCompra { get; set; }

    }
}