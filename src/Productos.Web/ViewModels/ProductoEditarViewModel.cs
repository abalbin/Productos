using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Productos.Web.ViewModels
{
    public class ProductoEditarViewModel
    {
        public int Id { get; set; }
        [Display(Name ="hola")]
        public string Nombre { get; set; }
    }
}
