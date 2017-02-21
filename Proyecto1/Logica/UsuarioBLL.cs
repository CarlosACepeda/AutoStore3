using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto1.Models;

namespace Proyecto1.Logica
{
    public class UsuarioBLL
    {
        public bool CambiarEstadoUser(Guid idUsuario)
        {

            //Consulta para traer la fila que se va a actualizar.
            AutoStoreContext contexto = new Models.AutoStoreContext();
            var actualizarEstado = from c in contexto.Usuario
                                   where c.IdUsuario == idUsuario
                                   select c;

            //Ejecutar la consulta y cambiar los valores que se requiera.

            foreach (Usuario usr in actualizarEstado)
            {
                if (usr.Activo==true)
                {
                    usr.Activo = false;
                }
                else 
                {
                    usr.Activo = true;
                }
                
            }

            //Registrar los cambios en la Base de Datos
            try
            {
                contexto.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool EditarUsuario(Usuario usr)
        {
            //Consulta para traer la fila que se va a actualizar.
            AutoStoreContext contexto = new AutoStoreContext();
            var actualizarUsuario = from c in contexto.Usuario
                                    where c.IdUsuario == usr.IdUsuario
                                    select c;

            //Ejecutar la consulta y cambiar los valores que se requiera.

            foreach (Usuario user in actualizarUsuario)
            {
                usr.NombreUsuario = usr.NombreUsuario;
                usr.Contrasena = usr.Contrasena;
                usr.Foto = usr.Foto;
                usr.Activo = true;

            }

            //Registrar los cambios en la Base de Datos
            try
            {
                contexto.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool MostrarInformacion(Guid idUser)
        {

            try
            {
                AutoStoreContext context = new AutoStoreContext();
                var mostrarInfo = from usr in context.Usuario
                                  where usr.IdUsuario == idUser
                                  select usr;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool CrearUsuario(Guid idUser, string nombreUser, string clave, string foto, int rol, bool activo = true)
        {
            try
            {
                Usuario usr = new Usuario
                {

                    IdUsuario = idUser,
                    NombreUsuario = nombreUser,
                    Contrasena = clave,
                    Foto = foto,
                    RolID = rol


                };
                AutoStoreContext contex = new AutoStoreContext();
                contex.Usuario.Add(usr);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public List<Usuario> ListarUsuarios()
        {
                AutoStoreContext context = new AutoStoreContext();
                var mostrarInfo = from usr in context.Usuario
                                  select usr;
                return mostrarInfo.ToList();

       }
       public List<CarritoCompra> ListarHistorialCompras(Guid idUsuario)
        {
            AutoStoreContext context = new AutoStoreContext();
            var mostrarCarrito = from usr in context.CarritoCompras
                                 where usr.UsuarioID == idUsuario
                              select usr;
            return mostrarCarrito.ToList();
        }
        
    }
}