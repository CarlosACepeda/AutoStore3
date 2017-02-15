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

        public Guid idCategoria { get; set; }

        public double total { get; set; }

        public int idMetodoPago { get; set; }

        public Guid idUsuario { get; set; }
        public int idItem { get; set; }
        
        
        
    }
}