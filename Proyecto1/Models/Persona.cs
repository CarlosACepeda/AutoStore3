using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto1.Models
{
    public class Persona
    {
        [ScaffoldColumn(false)]

        [Key]
        public Guid PersonaID { get; set; }


        [Required, StringLength(20, ErrorMessage = "Nombre debe ser de 20 o menos caracteres"), Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required, StringLength(20, ErrorMessage = "Apellido debe ser de 20 o menos caracteres"), Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required, StringLength(30, ErrorMessage ="Dirección debe ser de menos de 30 caracteres "), Display(Name = "Direccion")]
        public string Direccion { get; set; }


        [Required, StringLength(40, ErrorMessage = "Telefono debe ser de 40 o menos caracteres"), Display(Name = "Telefono")]
        public int Telefono { get; set; }


        [Required, StringLength(40), Display(Name = "Email")]
        public string Email { get; set; }

        //Zona de Relaciones

        //Ninguna Actualmente.


    }
}