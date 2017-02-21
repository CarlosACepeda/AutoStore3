using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto1.Models
{
    public class Producto
    {
        [ScaffoldColumn(false)]

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductoID { get; set; }

        [Required, StringLength(200, ErrorMessage ="El producto debe ser de menos de 200 caracteres"), Display(Name = "Nombre producto")]
        public string NombreProducto { get; set; }


        [Required, StringLength(400, ErrorMessage ="La descripción debe ser de menos de 400 caracteres"), Display(Name = "Descripcion")DataType(DataType.MultilineText)]
        public string Descripcion { get; set; }

       
        [Required]
        public int PrecioU { get; set; }

        [Required]
        public bool Activo { get; set; }

        //Zona de Relaciones

        //Relacion con Usuario

        public Guid UsuarioID { get; set; }

        public virtual Usuario Usuario { get; set; }

        //Relacion con ImagenProducto.

        public ICollection<ImagenProducto> ImagenesProductos { get; set; }
        
        //Relacion con MarcaProducto

        public int MarcaProductoID { get; set; }

        public virtual MarcaProducto Marca { get; set; }



    }
}