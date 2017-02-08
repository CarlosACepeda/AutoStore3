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
        public int RolId { get; set; }

        [Required, StringLength(100), Display(Name = "Nombre Rol")]

        public string NombreRol { get; set; }

        public Guid IdUsuario { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }


        /// <summary>
        /// Metodo que obtiene el rol para el Usuario especificado
        /// </summary>
        /// <param name="idUsuario">Identificador del usuario para saber su rol</param>
        /// <returns></returns>
        public string ObtenerRol(Guid idUsuario)
        {
            AutoStoreContext contexto = new AutoStoreContext();

            var seleccionarRol = from rol in contexto.Rol
                               where Convert.ToString(rol.IdUsuario).Contains(idUsuario.ToString())
                               select rol.NombreRol;

            return seleccionarRol.ToString();
        }


    }

}