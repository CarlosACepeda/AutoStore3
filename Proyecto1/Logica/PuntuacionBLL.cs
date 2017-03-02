using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto1.Models;

namespace Proyecto1.Logica
{
    public class PuntuacionBLL
    {

        /// <summary>
        /// Metodo que permite calcular la puntuacion de los usuarios
        /// </summary>
        /// <param name="idUsuario">Parametro que permite traer el id del usuario al que se calificara</param>
        /// <returns>Retorna un valor double que almacenara el promedio segun sus puntuaciones</returns>
        public double CalcularPuntuacion(Guid idUsuario)
        {
            //Recuperar los campos.
            try
            {
                AutoStoreContext contexto = new AutoStoreContext();

                var calcularPuntuacion = from c in contexto.Puntuacion
                           where c.IdUsuario == idUsuario
                           select c.PuntuacionUsuario;

               //Calcular Promedio de puntuaciones del Usuario especificado
              return calcularPuntuacion.ToList().Average();

              
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}