using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Proyecto1.Models
{
    public class ModeloCarro
    {
        [ScaffoldColumn(false)]

        public int idModeloCarro { get; set; }

        [Required, StringLength(20), Display(Name = "Nombre modelo")]
        public string nombreModeloC { get; set; }
    }
}