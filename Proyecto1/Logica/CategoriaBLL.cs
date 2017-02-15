using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1.Logica
{
    public class CategoriaBLL
    {
        public List<Models.Categoria> ObtenerCategoria(int idCategoria)
        {
            Models.AutoStoreContext contexto = new Models.AutoStoreContext();

            var recuperarCategoria = from rc in contexto.Categoria
                                     where (rc.IdCategoria).Equals(idCategoria)
                                     select rc;
            return recuperarCategoria.ToList();
        }
    }
}