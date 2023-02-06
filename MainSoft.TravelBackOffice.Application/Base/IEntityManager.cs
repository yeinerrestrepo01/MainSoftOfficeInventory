using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace MainSoft.TravelBackOffice.Application.Base
{
    public interface IEntityManager<T> where T : class
    {
        /// <summary>
        /// Meotodo para realizar la confirmacion de la transaccion de la base de datos realiza
        /// </summary>
        void Commit();

        /// <summary>
        /// Meotodo para realizar la confirmacion de la transaccion de la base de datos realiza
        /// de manera asincrona
        /// </summary>
        Task CommitAsync();

        /// <summary>
        /// Metodo encargado de realizar el proceso de delete
        /// de item de la tabla configurada en el repositorio generico
        /// </summary>
        /// <param name="entity">Entidad a Eliminar</param>
        void Delete(T entity);

        /// <summary>
        /// Metodo encargado de realizar el proceso de delete
        /// de multiplex registros de la tabla configurada en el repositorio generico
        /// </summary>
        /// <param name="entity">Entidad a Eliminar</param>
        void DeleteRange(IEnumerable<T> entities);

        IQueryable<T> GetAll();

        T GetById(int id);

        Task<T> GetByIdAsync(int id);

        void Insert(T entity);

        void InsertRange(IEnumerable<T> entities);

        void SetProp(T item, string propName, Object newValue);

        void SetPropBulk(IEnumerable<T> items, string propName, Object newValue);

        void Update(T entity);

        IEnumerable<T> GetFromSqlQuery(string nativeSqlQuery);

        Task<int> GetSeqSqlQuery(string SQLQuery);

        void UpdateEntityFromDb(T Entity);

        void RemoveEntityFromContext(T Entity);

        IQueryable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);

    }
}
