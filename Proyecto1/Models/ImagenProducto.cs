using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Proyecto1.Models
{
    public class ImagenProducto
    {
        [ScaffoldColumn(false)]
        public int IdImagen { get; set; }

        [Required, StringLength(20), Display(Name = "imagen")]
        public string imagen { get; set; }

        public virtual Producto producto { get; set; }



    }
}