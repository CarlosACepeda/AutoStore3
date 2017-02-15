using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Proyecto1.Models
{
    public class DetalleOrden
    {
        [ScaffoldColumn(false)]

        public Guid IdDetalleOrden { get; set; }

        [Required,  Display(Name = "Cantidad")]
        public int Cantidad { get; set; }
        //
        public virtual Orden orden { get; set; }
        public virtual Producto producto { get; set; }

        public bool AgregarAlDetalle(DetalleOrden deta)
        {
            AutoStoreContext contexto = new AutoStoreContext();
            contexto.DetalleOrden.Add(deta);
            contexto.SaveChanges();

            return true;
        }
        //public List<DetalleOrden> detalles()
        //{
        //    AutoStoreContext contexto = new AutoStoreContext();

        //    var traerDetalle = from det in contexto.DetalleOrden
        //                             where Convert.ToString(det.IdDetalleOrden).Contains(detalle.ToString())
        //                             select det;

        //    return traerDetalle.ToList();
        //}

    }
}