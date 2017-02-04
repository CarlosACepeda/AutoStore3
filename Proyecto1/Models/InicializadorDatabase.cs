using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Proyecto1.Models
{
    public class InicializadorDatabase : DropCreateDatabaseIfModelChanges<DBContext>
    {
        protected override void Seed(DBContext context)
        {
            listarCategorias().ForEach(c => context.Categoria.Add(c));
            listarMarca().ForEach(p => context.Marca.Add(p));
            modelo().ForEach(mod => context.Modelo.Add(mod));
            producto().ForEach(product => context.Producto.Add(product));

           
        }

        private static List<Categoria> listarCategorias()
        {
            var categorias = new List<Categoria>
        {
            new Categoria
            {
                IdCategoria = 1,
                NombreCategoria = "Ignicion / Filtros"
            },
            new Categoria
            {
                IdCategoria = 2,
                NombreCategoria = "Correas / Mangueras / Enfriado"
            },
             new Categoria
            {
                IdCategoria = 3,
                NombreCategoria = "Eléctrico"
            },
              new Categoria
            {
                IdCategoria = 4,
                NombreCategoria = "Frenos / Cojinetes"
            },
               new Categoria
            {
                IdCategoria = 5,
                NombreCategoria = "Combustible / Emisiones"
            },
                new Categoria
            {
                IdCategoria = 6,
                NombreCategoria = "Aire Acondicionado / Calefaccion"
            },
                 new Categoria
            {
                IdCategoria = 7,
                NombreCategoria = "Partes del Motor"
            },
                  new Categoria
            {
                IdCategoria = 8,
                NombreCategoria = "Transmision"
            },
                   new Categoria
            {
                IdCategoria = 9,
                NombreCategoria = "Dirección / Suspensión"
            },
                    new Categoria
            {
                IdCategoria = 10,
                NombreCategoria = "Emisiones / Embrague"
            },
                    new Categoria
            {
                IdCategoria = 11,
                NombreCategoria = "Limpiaparabrisas / Luces / Fusibles"
            },
                   new Categoria
            {
                IdCategoria = 12,
                NombreCategoria = "Carrocería / Cables / Varios"
            },
                   new Categoria
            {
                IdCategoria = 13,
                NombreCategoria = "Quimicos / Ceras / Lubricantes"
            },
                  new Categoria
            {
                IdCategoria = 14,
                NombreCategoria = "Llantas / Accesorios"
            }
        };
            return categorias;
        }
        private static List<Marca> listarMarca()
        {
            var marca = new List<Marca>
        {
            new Marca
            {
                IdMarca = 1,
                NombreMarca ="Alfa Romeo"
            },
            new Marca
            {
                IdMarca = 2,
                NombreMarca ="Chevrolet"
            },
            new Marca
            {
                IdMarca = 3,
                NombreMarca ="Nissan"
            },
            new Marca
            {
                IdMarca = 4,
                NombreMarca ="Renault"
            },
            new Marca
            {
                IdMarca = 5,
                NombreMarca ="Toyota"
            },
            new Marca
            {
                IdMarca = 6,
                NombreMarca ="Mazda"
            },
            new Marca
            {
                IdMarca = 7,
                NombreMarca ="Jeep"
            },
            new Marca
            {
                IdMarca = 8,
                NombreMarca ="Mitsubishi"
            },
            new Marca
            {
                IdMarca = 9,
                NombreMarca ="Hyundai"
            },
            new Marca
            {
                IdMarca = 10,
                NombreMarca ="Mercedez-Benzx"
            }
        };
            return marca;
        }
        private static List<Modelo> modelo()
        {
            var modelo = new List<Modelo>
            {
             new Modelo
             {
                 Idmodelo=1,
                 modelo ="Alfa Romeo 4C",
                 IdMarca= 1
             },

             new Modelo
             {
                 Idmodelo=2,
                 modelo ="Alfa Romeo 4R Zagato",
                 IdMarca= 1
             },
             new Modelo
             {
                 Idmodelo=3,
                 modelo ="Chevrolet Avalanche",
                 IdMarca= 2
             },
             new Modelo
             {
                 Idmodelo=4,
                 modelo ="Chevrolet Aveo",
                 IdMarca= 2
             },
             new Modelo
             {
                 Idmodelo=5,
                 modelo ="Nissan 280Z",
                 IdMarca= 3
             },
             new Modelo
             {
                 Idmodelo=6,
                 modelo ="Nissan March",
                 IdMarca= 3
             },
             new Modelo
             {
                 Idmodelo=7,
                 modelo ="Renault LeCar",
                 IdMarca= 4
             },
             new Modelo
             {
                 Idmodelo=8,
                 modelo ="Renault R16",
                 IdMarca= 4
             },
             new Modelo
             {
                 Idmodelo=9,
                 modelo ="Toyota FJ Cruiser",
                 IdMarca= 5
             },
             new Modelo
             {
                 Idmodelo=10,
                 modelo ="Toyota Prius C",
                 IdMarca= 5
             },
             new Modelo
             {
                 Idmodelo=11,
                 modelo ="Mazda MX-6",
                 IdMarca= 6
             },

             new Modelo
             {
                 Idmodelo=12,
                 modelo ="Mazda Navajo",
                 IdMarca= 6
             },
             new Modelo
             {
                 Idmodelo=13,
                 modelo ="Jeep J-100",
                 IdMarca= 7
             },
             new Modelo
             {
                 Idmodelo=14,
                 modelo ="Jeep Jeepster",
                 IdMarca= 7
             },
             new Modelo
             {
                 Idmodelo=15,
                 modelo ="Mitsubishi i-MiEV",
                 IdMarca= 8
             },

             new Modelo
             {
                 Idmodelo=16,
                 modelo ="Mitsubishi Tredia",
                 IdMarca= 8
             }
            };
            return modelo;
        }
        private static List<Producto> producto()
        {
            var producto = new List<Producto>()
            {
                new Producto
                {
                    idProducto= 1,
                    nombreProducto ="Bujias",
                    descripcion="480  ",
                    precioU = 30000,
                    idCategoria= 1,
                    idUsuario= 1 ,
                    idMarca = 1,
                },
                  new Producto
                {
                    idProducto= 2,
                    nombreProducto ="llantas",
                    descripcion="Bridgestone  ",
                    precioU = 50000,
                    idCategoria= 2,
                    idUsuario= 2 ,
                    idMarca = 2,
                },
                    new Producto
                {
                    idProducto= 3,
                    nombreProducto ="espejos",
                    descripcion="   ",
                    precioU = 20555,
                    idCategoria= 3,
                    idUsuario= 3,
                    idMarca = 3,
                },
                      new Producto
                {
                    idProducto= 4,
                    nombreProducto ="aire acondicionado",
                    descripcion="   ",
                    precioU = 231564,
                    idCategoria= 4,
                    idUsuario= 4 ,
                    idMarca = 4,
                },
                        new Producto
                {
                    idProducto= 5,
                    nombreProducto ="motor",
                    descripcion="480  ",
                    precioU = 244556,
                    idCategoria= 5,
                    idUsuario= 5,
                    idMarca = 5,
                }
            };
            return producto;
            }
        }
    }









     