using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Proyecto1.Models
{
    public class Persona
    {
        [ScaffoldColumn(false)]

        public int IdPersona { get; set; }

        [Required, StringLength(20), Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required, StringLength(20), Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required, StringLength(30), Display(Name = "Direccion")]
        public string Direccion { get; set; }


        [Required, Display(Name = "Telefono")]
        public int Telefono { get; set; }


        [Required, StringLength(40), Display(Name = "Email")]
        public string Email { get; set; }

        public Guid IdUsuario { get; set; }

        public virtual Usuario Usuario { get; set; }


        //Metodos de la clase Persona

        public bool ActualizarInfoPersona(Persona pers)
        {
            AutoStoreContext contexto = new AutoStoreContext();
            contexto.Persona.Add(pers);
            contexto.SaveChanges();
            return true;
        }



    }
}