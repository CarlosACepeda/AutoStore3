using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto1.Models
{
    public class Categoria

    {
        [ScaffoldColumn(false)]

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCategoria { get; set; }

        [Required, StringLength(50, ErrorMessage = "La categoria debe ser de menos de 50 caracteres"), Display(Name = "Categoria")]
        public string NombreCategoria { get; set; }

        //Zona de Relaciones

        //Relacion con Modelo Carro
        public ICollection<ModeloCarro> ModelosDeCarro { get; set; }

        //Relacion con Marca del Producto
        public ICollection<MarcaProducto> MarcaProducto { get; set; }
    }
}