using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto1.Models
{
    public class FabricanteCarro
    {
        [ScaffoldColumn(false)]

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idFabricanteCarro { get; set; }

        [Required, StringLength(20, ErrorMessage ="El nombre del fabricante debe ser de menos de 20 caracteres"), Display(Name = "Nombre fabricante")]
        public string NombreFabricanteC { get; set; }

        //Zona de Relaciones

        public ICollection<ModeloCarro> ModelosDeCarro { get; set; }
    }
}