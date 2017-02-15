using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Proyecto1.Models
{
    public class Categoria

    {
        [ScaffoldColumn(false)]

        public int IdCategoria { get; set; }

        [Required, StringLength(20), Display(Name = "Categoria")]
        public string NombreCategoria { get; set; }

        public void elegircategoria()
        {

        }
    }
    
}