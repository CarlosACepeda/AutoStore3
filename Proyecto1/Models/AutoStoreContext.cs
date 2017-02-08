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
            : base ("AutoStore")
        {
            Database.SetInitializer(new InicializadorDatabase());
        }

        public DbSet<Rol> Rol { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Orden> Orden { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Modelo> Modelo { get; set; }
        public DbSet<DetalleOrden> DetalleOrden { get; set; }
        public DbSet<MetodoDePago> MetodoDePago { get; set; }
        public DbSet<Puntuacion> Puntuacion { get; set; }
        public DbSet<ImagenProducto> ImagenProducto { get; set; }


    }
}