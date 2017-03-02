using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Proyecto1.Models
{
    public class InicializadorDatabase : DropCreateDatabaseIfModelChanges<AutoStoreContext>
    {
        protected override void Seed(AutoStoreContext context)
        {
            listarCategorias().ForEach(c => context.Categoria.Add(c));
            listarFabricantes().ForEach(f => context.FabricanteCarro.Add(f));
            listarModelosDeCarro().ForEach(m => context.ModeloCarro.Add(m));
            listarProductos().ForEach(product => context.Producto.Add(product));


        }

        //Datos quemados de Modelos de Carro.
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

        //Datos quemados de Modelos de Carro.
        private static List<FabricanteCarro> listarFabricantes()
        {
            var FabricantesDeCarros = new List<FabricanteCarro>
        {
            new FabricanteCarro
            {

                NombreFabricanteC ="Alfa Romeo"
            },
            new FabricanteCarro
            {

                NombreFabricanteC ="Chevrolet"
            },
            new FabricanteCarro
            {

                NombreFabricanteC ="Nissan"
            },
            new FabricanteCarro
            {

                NombreFabricanteC ="Renault"
            },
            new FabricanteCarro
            {

                NombreFabricanteC ="Toyota"
            },
            new FabricanteCarro
            {

                NombreFabricanteC ="Mazda"
            },
            new FabricanteCarro
            {

                NombreFabricanteC ="Jeep"
            },
            new FabricanteCarro
            {

                NombreFabricanteC ="Mitsubishi"
            },
            new FabricanteCarro
            {

                NombreFabricanteC ="Hyundai"
            },
            new FabricanteCarro
            {

                NombreFabricanteC ="Mercedez-Benz"
            }
        };
            return FabricantesDeCarros;
        }
        private static List<ModeloCarro> listarModelosDeCarro()
        {
            var modelosDeCarro = new List<ModeloCarro>
            {
             new ModeloCarro
             {
                 NombreModeloC ="Alfa Romeo 4C",
                 FabricanteCarroID= 1
             },

             new ModeloCarro
             {
                 NombreModeloC ="Alfa Romeo 4R Zagato",
                 FabricanteCarroID= 1
             },
             new ModeloCarro
             {
                 NombreModeloC ="Chevrolet Avalanche",
                 FabricanteCarroID= 2
             },
             new ModeloCarro
             {
                 NombreModeloC ="Chevrolet Aveo",
                 FabricanteCarroID= 2
             },
             new ModeloCarro
             {

                 NombreModeloC ="Nissan 280Z",
                 FabricanteCarroID= 3
             },
             new ModeloCarro
             {
                 NombreModeloC ="Nissan March",
                 FabricanteCarroID= 3
             },
             new ModeloCarro
             {

                 NombreModeloC ="Renault LeCar",
                 FabricanteCarroID= 4
             },
             new ModeloCarro
             {

                 NombreModeloC ="Renault R16",
                 FabricanteCarroID= 4
             },
             new ModeloCarro
             {
                 NombreModeloC ="Toyota FJ Cruiser",
                 FabricanteCarroID= 5
             },
             new ModeloCarro
             {

                 NombreModeloC ="Toyota Prius C",
                 FabricanteCarroID= 5
             },
             new ModeloCarro
             {

                 NombreModeloC ="Mazda MX-6",
                 FabricanteCarroID= 6
             },

             new ModeloCarro
             {

                 NombreModeloC ="Mazda Navajo",
                 FabricanteCarroID= 6
             },
             new ModeloCarro
             {
                 NombreModeloC ="Jeep J-100",
                 FabricanteCarroID= 7
             },
             new ModeloCarro
             {

                 NombreModeloC ="Jeep Jeepster",
                 FabricanteCarroID= 7
             },
             new ModeloCarro
             {
                 NombreModeloC ="Mitsubishi i-MiEV",
                 FabricanteCarroID= 8
             },

             new ModeloCarro
             {

                 NombreModeloC ="Mitsubishi Tredia",
                 FabricanteCarroID= 8
             }
            };
            return modelosDeCarro;
        }
        private static List<Producto> listarProductos()
        {
            var listadoDeProductos = new List<Producto>()
            {
                new Producto
                {

                    NombreProducto ="Bujias",
                    Descripcion="Bujias para... ",
                    PrecioU = 30000,
                    Activo= true,
                    UsuarioID= Guid.NewGuid(),
                    MarcaProductoID= 1
                    
                },
                  new Producto
                {
                    NombreProducto ="Limpiaparabrisas",
                    Descripcion="Limpiaparabrisas para... ",
                    PrecioU = 50000,
                    Activo= true,
                    UsuarioID= Guid.NewGuid(),
                    MarcaProductoID = 2,
                },
                    new Producto
                {
                    NombreProducto ="Radioador",
                    Descripcion="Radiador para... ",
                    PrecioU = 60000,
                    Activo= true,
                    UsuarioID= Guid.NewGuid(),
                    MarcaProductoID = 3,
                },
                      new Producto
                {
                    NombreProducto ="Retrovisor",
                    Descripcion="Retrovisor para... ",
                    PrecioU = 5000,
                    Activo= true,
                    UsuarioID= Guid.NewGuid(),
                    MarcaProductoID = 2,
                },
                
            };
            return listadoDeProductos;
            }
        }
    }









     