using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto1.Models;

namespace Proyecto1.Logica
{
    public class FabricanteCarroBLL
    {
        /// <summary>
        /// Metodo que se encargar de listar todas los fabricantes de carros existentes
        /// </summary>
        /// <returns>Retorna la lista de fabricantes de carros</returns>
        public List<FabricanteCarro> ObtenerFabricante()
        {
            AutoStoreContext context = new AutoStoreContext();
            var mostrarFabricante = from Fab in context.FabricanteCarro
                              select Fab;
            return mostrarFabricante.ToList();
        }

        /// <summary>
        /// Metodo para agregar fabricantes de carros
        /// </summary>
        /// <param name="nombreF">Parametro que captura el fabricante de carro</param>
        /// <returns>Retorna un valor booleano segun la ejecucion del metodo</returns>
        public bool AgregarFabricante(string nombreF)
        {
            try
            {
                FabricanteCarro FabicanteC = new FabricanteCarro
                {
                    NombreFabricanteC= nombreF
                };
                AutoStoreContext contexto = new AutoStoreContext();
                contexto.FabricanteCarro.Add(FabicanteC);
                contexto.SaveChanges();
                return true;
            }


            catch (Exception)
            {
                return false;
            }
        }
    }
}