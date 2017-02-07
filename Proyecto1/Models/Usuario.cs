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


        //Métodos de la clase Usuario

        public bool CambiarEstadoUsuario(bool activo, Guid idUsuario)
        {
            AutoStoreContext contexto = new AutoStoreContext();

            var cambiarEstadoUsr =
               from usrEstado in contexto.Usuario
               where usrEstado.IdUsuario.Equals(idUsuario)
               select usrEstado;

           
            foreach (Usuario usr in cambiarEstadoUsr)
            {
                usr.Activo = false;
            }

            return true;
        }
        public bool InsertarUsuario(Usuario usr)
        {
            AutoStoreContext contexto = new AutoStoreContext();

            contexto.Usuario.Add(usr);

            contexto.SaveChanges();

            return true;
        }
        public bool ModificarUsuarioyPass(Guid idUsuario, string nombreUsr, string pass)
        {
            AutoStoreContext contexto = new AutoStoreContext();

            var modificarUsr =
               from usr in contexto.Usuario
               where usr.IdUsuario.Equals(idUsuario)
               select usr;


            foreach (Usuario usr in modificarUsr)
            {
                usr.NombreUsuario = nombreUsr;
                usr.Contrasena = pass;

            }
            return true;
        }
        public Usuario ObtenerUsuario(Guid idUsuario)
        {
            AutoStoreContext contexto = new AutoStoreContext();

            var seleccionarUsuario = from usr in contexto.Usuario
                                     where Convert.ToString(usr.IdUsuario).Contains(idUsuario.ToString())
                                     select usr;
            return seleccionarUsuario;
            
        }


    }
}