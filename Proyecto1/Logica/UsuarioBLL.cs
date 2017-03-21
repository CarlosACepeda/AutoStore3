using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto1.Models;
using System.Data.Entity.SqlServer;

namespace Proyecto1.Logica
{
    public class UsuarioBLL
    {


        /// <summary>
        /// Metodo para cambiar el estado del usuario 
        /// </summary>
        /// <param name="idUsuario">Parametro que se trae para saber a que usuario se desea cambiar el estado</param>
        /// <returns>Retorna un valor booleano segun la ejecucion del metodo</returns>
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
                if (usr.Activo == true)
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


        /// <summary>
        /// Metodo para editar el usuario 
        /// </summary>
        /// <param name="usr">Se crea una variable que traera todos los campos del usuario para editarlos
        /// 
        /// </param>
        /// <returns></returns>
        public bool EditarUsuario(Usuario usr)
        {
            //Consulta para traer la fila que se va a actualizar.
            AutoStoreContext contexto = new AutoStoreContext();
            var actualizarUsuario = from c in contexto.Usuario
                                    where c.IdUsuario == usr.IdUsuario
                                    select c;

            //Ejecutar la consulta y cambiar los valores que se requiera.

            foreach (var user in actualizarUsuario)
            {
                user.NombreUsuario = usr.NombreUsuario;
                user.Contrasena = usr.Contrasena;
                user.Foto = usr.Foto;
                user.Activo = true;

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

        /// <summary>
        /// Metodo para mostrar la informacion del usuario
        /// </summary>
        /// <param name="idUser">Parametro que permite saber de que usuario se desea obtener la informacion</param>
        /// <returns>Retorna un valor booleano segun la ejecucion del metodo</returns>
        public List<Usuario> MostrarInformacion()
        {
            Guid? iduser = TraerIdDeUsuarioLogueado();

            AutoStoreContext context = new AutoStoreContext();
            var mostrarInfo = from usr in context.Usuario
                              where usr.IdUsuario == iduser
                              select usr;

            return mostrarInfo.ToList();
        }

        /// <summary>
        /// Metodo para crear un usuario
        /// </summary>
        /// <param name="idUser">Parametro que permite capturar el id del usuario</param>
        /// <param name="nombreUser">Parametro que permite capturar el nombre del usuario</param>
        /// <param name="clave">Parametro que captura la clave del usuario</param>
        /// <param name="foto">Parametro que captura la foto que desea el usuario</param>
        /// <param name="rol">Parametro que captura el rol que tendra el usuario</param>
        /// <param name="activo">Parametro que captura el estado que tiene el usuario</param>
        /// <returns>Retorna un valor booleano segun la ejecucion del metodo</returns>
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
                    Activo = activo,
                    RolID = rol



                };
                AutoStoreContext contex = new AutoStoreContext();
                contex.Usuario.Add(usr);
                contex.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// Metodo que lista los usuarios existentes, este metodo estara disponible solamente para el administrador 
        /// </summary>
        /// <returns>Retorna un valor booleano segun la ejecucion del metodo</returns>
        public List<Usuario> ListarUsuarios()
        {
            AutoStoreContext context = new AutoStoreContext();
            var mostrarInfo = from usr in context.Usuario
                              select usr;
            return mostrarInfo.ToList();

        }

        /// <summary>
        /// Metodo para Autenticar el usuario que se va a loguear en el sistema
        /// </summary>
        /// <param name="nombre">Nombre de Usuario</param>
        /// <param name="clave">contraseña del Usuario</param>
        /// <returns></returns>
        public int Autenticar(string nombre, string clave)
        {

            try
            {
                using (AutoStoreContext context = new AutoStoreContext())
                {
                    var mostrarInfo = from usr in context.Usuario
                                      where usr.NombreUsuario == nombre && usr.Contrasena == clave
                                      select usr;
                    //Buscar el Rol del Usuario que se loguea.
                    var rolId = from usr in context.Usuario
                                where usr.NombreUsuario == nombre
                                select usr.RolID;


                    //Este if confirma si hay un usuario en la Base de Datos.
                    if (mostrarInfo.Count() == 0)
                    {
                        return 0; //0 vale a 'No hay usuarios'
                    }

                    //Si se encuentra un usuario, compara el id de ese usuario.
                    else if (rolId.Equals(1))
                    {
                        ///Si el Rol es 1 entonces es Administrador.
                        return 1;
                    }
                    else
                    {
                        //Si el rol es 2 entonces es Usuario
                        return 2;
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Guid? TraerIdDeUsuarioLogueado()
        {

            string sesionActual = HttpContext.Current.Session["UserLogin"].ToString();
            AutoStoreContext context = new AutoStoreContext();
            Guid? idUser = (from usuario in context.Usuario
                            where usuario.NombreUsuario == sesionActual
                            select usuario.IdUsuario).FirstOrDefault();

            return idUser;
        }
    }

}