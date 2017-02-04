using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Proyecto1.Models
{
    public class Modelo
    {
        [ScaffoldColumn(false)]

        public int Idmodelo { get; set; }
      
        [Required, StringLength(20), Display(Name = "Modelo")]
        public string modelo { get; set; }

        public int IdMarca { get; set; }

        public virtual Marca marca { get; set; }

    }
}