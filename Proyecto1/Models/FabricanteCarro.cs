using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Proyecto1.Models
{
    public class FabricanteCarro
    {
        [ScaffoldColumn(false)]

        public int idFabricanteCarro { get; set; }

        [Required, StringLength(20), Display(Name = "Nombre fabricante")]
        public string nombreFabricanteC { get; set; }
    }
}