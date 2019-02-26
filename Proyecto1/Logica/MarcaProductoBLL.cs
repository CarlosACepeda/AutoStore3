using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto1.Models;

namespace Proyecto1.Logica
{
    public class MarcaProductoBLL
    {

        /// <summary>
        /// Metodo que se encarga de agregar una marca de producto 
        /// </summary>
        /// <param name="nombreM">Parametro para capturar el nombre de la marca del producto</param>
        /// <param name="categorias">Parametro para capturar la categoria a la cual pertenecera el producto el producto</param>
        /// <param name="productos">Parametro para capturar una coleccion de los producto pertenecientes a la marca</param>
        /// <returns>Retorna un valor booleano segun la ejecucion del metodo</returns>
        public bool AgregarMarcaP(string nombreM, List<Categoria>categorias,List<ModeloCarro> modelosDeCarro)
        {
            try
            {
                MarcaProducto marcaP = new MarcaProducto
                {
                    NombreMarca= nombreM,
                    ModelosDeCarro= modelosDeCarro,
                    Categorias= categorias                    
                };
                AutoStoreContext contexto = new AutoStoreContext();
                contexto.MarcaProducto.Add(marcaP);
                return true;
            }


            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Metodo que se encargar de listar todas las marcas de productos existentes
        /// </summary>
        /// <returns>Retorna la lista de marcas de productos</returns>
        public List<MarcaProducto> ObtenerMarcaP()
        {
            AutoStoreContext context = new AutoStoreContext();
            var mostrarMarcaP = from marcaP in context.MarcaProducto
                                   select marcaP;
            return mostrarMarcaP.ToList();
        }

    }
}