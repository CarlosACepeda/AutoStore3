using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto1.Models
{
    public class Producto
    {
        [ScaffoldColumn(false)]

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductoID    { get; set; }

        [Required, StringLength(20), Display(Name = "Nombre producto")]
        public string nombreProducto { get; set; }


        [Required, StringLength(100), Display(Name = "Descripcion")DataType(DataType.MultilineText)]
        public string descripcion { get; set; }


        public int imagenProducto { get; set; }

        [Required, StringLength(20), Display(Name = "Precio unitario")]
        public int precioU { get; set; }

        public int idCategoria { get; set; }
        public int idUsuario { get; set; }
        public int idMarca { get; set; }
        public virtual Categoria categoria { get; set; }

        public virtual Usuario user { get; set; }


        public virtual Marca marca { get; set; }


             


    }
}