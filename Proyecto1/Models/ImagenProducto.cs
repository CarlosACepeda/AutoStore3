using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto1.Models
{
    public class ImagenProducto
    {
        [ScaffoldColumn(false)]

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImagenID { get; set; }

        [Required]
        public byte[] Imagen { get; set; }
        


        //Zona de Relaciones.

        //Relacion con Producto-
        public Guid ProductoID { get; set; }
        public virtual Producto Producto { get; set; }



    }
}