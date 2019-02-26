using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto1.Models;

namespace Proyecto1.Logica
{
    public class PersonaBLL
    {
        /// <summary>
        /// Metodo que permite editar y modificar el perfil de la persona
        /// </summary>
        /// <param name="persona">La variable de clase persona permite editar todos los campos de esta clase</param>
        /// <returns></returns>
        public bool EditarPerfil(Persona persona)
        {
            AutoStoreContext contexto = new AutoStoreContext();
            var actualizarPersona = from c in contexto.Persona
                                    where c.PersonaID==persona.PersonaID
                                    select c; 

            //Ejecutar la consulta y cambiar los valores que se requiera.

            foreach (var user in actualizarPersona)
            {
                user.Nombre = persona.Nombre;
                user.Apellido = persona.Apellido;
                user.Direccion = persona.Direccion;
                user.Telefono = persona.Telefono;
                user.Email = persona.Email;

            }
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
        /// Metodo donde una persona puede registrarse
        /// </summary>
        /// <param name="idPersona">Parametro que permite a la persona digitar su id</param>
        /// <param name="nombre">Parametro que permite ingresar el nombre de la persona</param>
        /// <param name="apellido">Parametro que permite ingresar el apellido de la persona</param>
        /// <param name="direccion">Parametro que permite ingresar la direccion de la persona</param>
        /// <param name="telefono">Parametro que permite ingresar el telefono de la persona</param>
        /// <param name="email">Parametro que permite ingresar el email de la persona</param>
        /// <returns>Retorna un valor booleano segun la ejecucion del metodo</returns>
        public bool CrearPersona(Guid idPersona, string nombre, string apellido, string direccion, Int64 telefono, string email)
        {
            try
            {
                Persona persona = new Persona 
                {
                    PersonaID= idPersona,
                    Nombre=nombre,
                    Apellido= apellido,
                    Direccion= direccion,
                    Telefono=telefono,
                    Email=email            


                };
                AutoStoreContext contex = new AutoStoreContext();
                contex.Persona.Add(persona);
                contex.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        
    }
} 
 