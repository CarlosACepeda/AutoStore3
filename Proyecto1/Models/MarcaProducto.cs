using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto1.Models
{
    public class MarcaProducto
    {
        [ScaffoldColumn(false)]

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMarca { get; set; }

        [Required, StringLength(20, ErrorMessage ="El nombre de marca no puede superar los 20 caracteres"), Display(Name = "Marca")]
        public string NombreMarca { get; set; }

        //Zona de Relaciones

        //Relacion con Producto
        public ICollection<Producto> Productos { get; set; }

        //Relacion con Categoria
        public ICollection<Categoria> Categorias { get; set; }



        
    }
}