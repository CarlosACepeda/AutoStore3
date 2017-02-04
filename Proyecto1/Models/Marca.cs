using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Proyecto1.Models
{
    public class Marca
    {
        [ScaffoldColumn(false)]

        
        public int IdMarca { get; set; }

        [Required, StringLength(20), Display(Name = "Marca")]
        public string NombreMarca { get; set; }
        
    }
}