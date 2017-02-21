using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto1.Models
{
    public class Puntuacion
    {
        [ScaffoldColumn(false)]

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PuntuacionID { get; set; }

        [Required]
        public int PuntuacionUsuario { get; set; }


        //Zona de Relaciones
        public Guid? IdUsuario { get; set; }

        public virtual Usuario usuario { get; set; }

             
    }
}