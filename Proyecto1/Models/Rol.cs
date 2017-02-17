using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Proyecto1.Models
{
    public class Rol
    {
        [ScaffoldColumn(false)]

        [Key]
        public int RolID { get; set; }

        [Required, StringLength(100), Display(Name = "Nombre Rol")]

        public string NombreRol { get; set; }

        //Zona de Relaciones

        //Relacion con Usuario
        public virtual ICollection<Usuario> Usuario { get; set; }

   
    }

}