using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInventario.AccesoDatos.Repositorio.IRepositorio
{
    public interface IRepositorio<T> where T : class
    {
        Task<T> Obtener(int id);
        Task<IEnumerable<T>> ObtenerTodos(
            Expression<Func<T, bool>> filtro = null, //expresion de filtro
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, //para ordenar
            string incluirPropiedades = null, 
            bool isTracking = true
            );

        Task<T> ObtenerPrimero(
            Expression<Func<T, bool>> filtro = null, //expresion de filtro
            string incluirPropiedades = null,
            bool isTracking = true
            );
        Task Agregar(T entidad);

        void Remover(T entidad);
        void RemverRango(IEnumerable<T> entidad);
    }
}
