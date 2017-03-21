using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto1.Models;

namespace Proyecto1.Logica
{
    public class ModeloCarroBLL
    {
        /// <summary>
        /// Metodo que se encargar de listar todos los modelos de carros existentes
        /// </summary>
        /// <returns>Retorna la lista de modelos de carros</returns>
        public List<ModeloCarro>ObtenerModeloCarro()
        {
            AutoStoreContext context = new AutoStoreContext();
            var mostrarModelo = from Modelo in context.ModeloCarro
                                    select Modelo;
            return mostrarModelo.ToList();
        }

        /// <summary>
        /// Metodo que se encarga de agregar un modelo de carro 
        /// </summary>
        /// <param name="idFabricante">Parametro que captura el id del fabricante al cual pertenece el modelo del carro</param>
        /// <param name="nombreM">Parametro que captura el nombre del modelo de carro</param>
        /// <param name="Categorias">Parametro que captura una lista para escoger a que categoria pertenece</param>
        /// <returns>Retorna un valor booleano segun la ejecucion del metodo</returns>
        public bool AgregarModeloCarro(string nombreM, int idFabricante)
        {
            try
            {
                ModeloCarro ModeloC = new ModeloCarro
                {
                    NombreModeloC = nombreM,
                    FabricanteCarroID = idFabricante,
                };
                AutoStoreContext contexto = new AutoStoreContext();
                contexto.ModeloCarro.Add(ModeloC);
                return true;
            }


            catch (Exception)
            {
                return false;
            }
        }
    }
}