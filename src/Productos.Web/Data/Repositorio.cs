using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productos.Web.Models;

namespace Productos.Web.Data
{
    public class Repositorio<T> : IRepositorio<T> where T : EntidadBase
    {
        private readonly ApplicationDbContext _contexto;
        private DbSet<T> _tabla;

        public Repositorio(ApplicationDbContext contexto)
        {
            _contexto = contexto;
            _tabla = contexto.Set<T>();
        }
        public void Actualizar(T entidad)
        {
            _tabla.Update(entidad);
            _contexto.SaveChanges();
        }

        public void Eliminar(T entidad)
        {
            _tabla.Remove(entidad);
            _contexto.SaveChanges();
        }

        public void Insertar(T entidad)
        {
            _tabla.Add(entidad);
            _contexto.SaveChanges();
        }

        public T Obtener(int? id)
        {
            return _tabla.SingleOrDefault(e => e.Id == id);
        }

        public IEnumerable<T> ObtenerTodos()
        {
            return _tabla.AsEnumerable();
        }

        public IQueryable<T> Query()
        {
            return _tabla;
        }
    }
}
