using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Proyecto1.Models
{
    public class Usuario
    {
        [ScaffoldColumn(false)]
        public int IdUsuario { get; set; }

        [Required, StringLength(20), Display(Name ="Nombre del Usuario")]
        public string NombreUsuario { get; set; }

        [Required, StringLength(50), Display(Name = "Clave")]
        public string Contrasena { get; set; }

        public ICollection<Puntuacion> Puntuaciones { get; set; }

        public string Foto { get; set; }
        
        [Required, StringLength(1)]
        public bool Activo { get; set; }

        [Required, Display(Name ="Nombre de Rol")]
        public virtual Rol Rol { get; set; }


    }
}