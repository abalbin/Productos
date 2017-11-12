using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Productos.Web.Models
{
    public class Producto : EntidadBase
    {                
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public IList<ProductoCategoria> Categorias { get; set; }
    }
}
