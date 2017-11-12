using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Productos.Web.Models
{
    public class Categoria : EntidadBase
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
