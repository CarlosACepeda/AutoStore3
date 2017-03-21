using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Proyecto1.Models
{
    public class AutoStoreContext : DbContext
    {
        public AutoStoreContext()
            : base ("AutoStoreContext")
        {
            Database.SetInitializer(new InicializadorDatabase());
        }


        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Puntuacion> Puntuacion { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<ModeloCarro> ModeloCarro { get; set; }
        //Metodo de Pago(Temporal)
        public DbSet<MetodoDePago> MetodoDePago { get; set; }
        public DbSet<MarcaProducto> MarcaProducto { get; set; }

        public DbSet<ItemCarrito> ItemCarrito { get; set; }
        public DbSet<ImagenProducto> ImagenProducto { get; set; }
        public DbSet<FabricanteCarro> FabricanteCarro { get; set; }
        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<CarritoCompra> CarritoCompras { get; set; }




    }
}