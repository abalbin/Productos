using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Productos.Web.Models;

namespace Productos.Web.Data
{
    public interface IRepositorio<T> where T : EntidadBase
    {
        IEnumerable<T> ObtenerTodos();
        T Obtener(int? id);
        void Insertar(T entidad);
        void Actualizar(T entidad);
        void Eliminar(T entidad);
        IQueryable<T> Query();
    }
}
