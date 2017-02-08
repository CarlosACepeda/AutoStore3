using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace Proyecto1.Models
{
    public class Puntuacion
    {
        [ScaffoldColumn(false)]

        public int IdPuntuacion { get; set; }

        [Required, StringLength(20), Display(Name = "Puntuacion")]
        public int PuntuacionUsuario { get; set; }

        public Guid IdUsuario { get; set; }


        public virtual Usuario usuario { get; set; }


        /// <summary>
        /// Metodo que regresa la puntuación promedio del Usuario.
        /// </summary>
        /// <param name="IdUsuario">Identificador del usuario para traer su puntuacion</param>
        /// <returns>Regresa la puntuacion del Usuario especificado</returns>
        public double? ObtenerPuntuacion(Guid IdUsuario)
        {
            AutoStoreContext contexto = new AutoStoreContext();

            double? puntuacionPromedio =
                        (from punt in contexto.Puntuacion where Convert.ToString(punt.idUsuario).Contains(IdUsuario.ToString())
                             select punt.puntuacion)
                            .Average();

            return puntuacionPromedio;
        }
             
    }
}