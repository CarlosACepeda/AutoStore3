using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Proyecto1.Models
{
    public class Puntuacion
    {
        [ScaffoldColumn(false)]

        public int IdPuntuacion { get; set; }

        [Required, StringLength(20), Display(Name = "Puntuacion")]
        public int puntuacion { get; set; }

        public virtual Usuario usuario { get; set; }
             
    }
}