using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Productos.Web.Models
{
    public class ProductoCategoria : EntidadBase
    {
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public int ProductoId { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
