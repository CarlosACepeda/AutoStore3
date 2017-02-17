using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto1.Models
{
    public class ModeloCarro
    {
        [ScaffoldColumn(false)]

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ModeloCarroID { get; set; }

        [Required, StringLength(20, ErrorMessage ="El modelo del Carro debe ser menos de 20 caracteres"), Display(Name = "Modelo del Carro")]
        public string NombreModeloC { get; set; }

        //Zona de Relaciones

        //Relación con categorias
        public ICollection<Categoria> Categorias { get; set; }

        //Relación con Fabricante de Carros.

        public int FabricanteCarroID { get; set; }
        public virtual FabricanteCarro FabricanteCarro { get; set; }

    }
}