using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio.IRepositorio
{
    //Se crea una Entidad Generica la cual recibira un objeto y ese obeto sera una clase
    public interface IRepositorio<T> where T : class
    {
        Task<T> Obtener(int id);

        //Al ser una lista tendra que ser del tipo IEnumerable
        Task<IEnumerable<T>> ObtenerTodos(
            Expression<Func<T,bool>> filtro = null,
            Func<IQueryable<T>,IOrderedQueryable<T>> orderBy = null,
            string incluirPropiedades = null, 
            bool isTracking = true
            );
        Task<T> ObtenerPrimero(
            Expression<Func<T, bool>> filtro = null,
            string incluirPropiedades = null,
            bool isTracking = true
            );
        Task Agregar(T entidad);
        //Los metodos de Remover no pueden ser asyncronos
        void Remover(T entidad);
        void RemoverRango(IEnumerable<T> entidad);
    }
}
