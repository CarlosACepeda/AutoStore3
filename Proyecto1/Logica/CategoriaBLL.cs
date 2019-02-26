using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto1.Models;

namespace Proyecto1.Logica
{
    public class CategoriaBLL
    {
        /// <summary>
        /// Metodo que se encargar de listar todas las categorias existentes
        /// </summary>
        /// <returns>Retorna la lista de categorias</returns>
        public List<Categoria> ObtenerCategoria()
        {
            AutoStoreContext context = new AutoStoreContext();
            var mostrarCategoria = from categoria in context.Categoria
                                   select categoria;
            return mostrarCategoria.ToList();
        }
        /// <summary>
        /// Metodo para agregar categorias
        /// </summary>
        /// <param name="nombreC">Parametro que captura el nombre de la categoria</param>
        /// <param name="Modelos">Parametro para guardar el modelo al cual pertenece</param>
        /// <param name="MarcasP">Parametro para guardar las marcas de productos</param>
        /// <returns>Retorna un valor booleano segun la ejecucion del metodo</returns>
        public bool AgregarCategoria(string nombreC, List<MarcaProducto> MarcasP)
        {
            try
            {
                Categoria categoria = new Categoria
                {
                    NombreCategoria = nombreC,
                    MarcaProducto = MarcasP
                };
                AutoStoreContext contexto = new AutoStoreContext();
                contexto.Categoria.Add(categoria);
                return true;
            }


            catch (Exception)
            {
                return false;
            }
        }
    }
}