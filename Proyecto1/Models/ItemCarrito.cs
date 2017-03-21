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
        public string ItemCarritoID { get; set; }

        [Required, Display(Name = "Cantidad")]
        public int Cantidad { get; set; }
        

        //Zona de Relaciones

        //Relacion con Carrito Compra.
        public string CarritoCompraID { get; set; }
        public virtual CarritoCompra CarritoCompra { get; set; }

        //Relacion con producto

        public Guid ProductoID { get; set; }
       
        public virtual Producto Producto { get; set; }

        //Relacion con usuario

        public string NombreUsuario { get; set; }

    }
}