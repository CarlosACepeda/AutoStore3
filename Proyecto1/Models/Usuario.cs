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
        [Key]
        public Guid IdUsuario { get; set; }

        [Required, StringLength(20, ErrorMessage ="El nombre de usuario debe ser menos de 20 caracteres"), Display(Name ="Nombre del Usuario")]
        public string NombreUsuario { get; set; }

        [Required, StringLength(50, ErrorMessage ="La contraseña debe ser menos de 50 caracteres"), Display(Name = "Clave")]
        public string Contrasena { get; set; }

        [Required(ErrorMessage ="Este campo es requerido"), StringLength(400), Display(Name = "Foto")]
        public string Foto { get; set; }

        [Required]
        public bool Activo { get; set; }

        
        //Zona de Relaciones entre entidades.

        //Relacion con Rol
        [Required]
        public int RolID { get; set; }

        public virtual Rol Rol { get; set; }

        //Relacion con Puntuacion
        public ICollection<Puntuacion> Puntuaciones { get; set; }


        //Relacion con Persona

        public virtual Persona Persona { get; set; }

        //Relacion con Carro Compras.

        public ICollection<CarritoCompra> CarritosDeCompra { get; set; }
        
        //Relacion con Producto

        public ICollection<Producto> Productos { get; set; }

        
    }
}