using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Entity;

namespace Proyecto1.Models
{
    public class Rol
    {
        [ScaffoldColumn(false)]
        public int RolId { get; set; }

        [Required, StringLength(100), Display(Name = "Nombre Rol")]

        public string NombreRol { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }


        public bool ObtenerRol()
        {
            
        }
    }

}