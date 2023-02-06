using MainSoft.TravelBackOffice.Infraestructure.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace MainSoft.TravelBackOffice.Application.Base
{
    public abstract class EntityManager<T> : IDisposable, IEntityManager<T> where T : class
    {
        protected IUnitOfWork _unitOfWork;

        protected IRepository<T> _repository;

        protected EntityManager(IUnitOfWork unitOfWork, IRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        /// <summary>
        /// Meotodo para realizar la confirmacion de la transaccion de la base de datos realiza
        /// </summary>
        public virtual void Commit()
        {
            _unitOfWork.Commit();
        }

        /// <summary>
        /// Meotodo para realizar la confirmacion de la transaccion de la base de datos realiza
        /// de manera asincrona
        /// </summary>
        public async virtual Task CommitAsync()
        {
            await _unitOfWork.CommitAsync();
        }
        /// <summary>
        /// Metodo encargado de realizar el proceso de delete
        /// de item de la tabla configurada en el repositorio generico
        /// </summary>
        /// <param name="entity">Entidad a Eliminar</param>
        public virtual void Delete(T entity)
        {
            Check(entity);
            _repository.Delete(entity);
        }
        /// <summary>
        /// Metodo encargado de realizar el proceso de delete
        /// de multiplex registros de la tabla configurada en el repositorio generico
        /// </summary>
        /// <param name="entity">Entidad a Eliminar</param>
        public virtual void DeleteRange(IEnumerable<T> entities)
        {
            Check(entities);
            _repository.DeleteRange(entities);
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _repository.GetAll().Where(predicate);
        }

        public virtual IQueryable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public async virtual Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /// <summary>
        /// Metodo encargado de realizar el proceso de creacion
        /// de registros de la tabla configurada en el repositorio generico
        /// </summary>
        /// <param name="entity">Entidad a insertar</param>
        public virtual void Insert(T entity)
        {
            Check(entity);

            _repository.Insert(entity);
        }

        /// <summary>
        /// Metodo encargado de realizar el proceso de insercion de 
        /// multiplex registros de la tabla configurada en el repositorio generico
        /// </summary>
        /// <param name="entity">lustado de registros a insertar</param>
        public virtual void InsertRange(IEnumerable<T> entities)
        {
            Check(entities);

            _repository.InsertRange(entities);
        }

        public virtual void Update(T entity)
        {
            Check(entity);
            _repository.Update(entity);
        }

        private void Check(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }
        private void Check(IEnumerable<T> entities)
        {
            foreach (T oneEntity in entities)
            {
                if (oneEntity == null)
                {
                    throw new ArgumentNullException("entities");
                }
            }
        }
        public void SetProp(T item, string propName, Object newValue)
        {
            _repository.SetProp(item, propName, newValue);
        }
        public void SetPropBulk(IEnumerable<T> items, string propName, Object newValue)
        {
            _repository.SetPropBulk(items, propName, newValue);
        }

        public IEnumerable<T> GetFromSqlQuery(string nativeSqlQuery)
        {
            return _repository.Context.Set<T>().FromSqlRaw(nativeSqlQuery).AsNoTracking();
        }

        public async Task<int> GetSeqSqlQuery(string SQLQuery)
        {
            var conn = _repository.Context.Database.GetDbConnection();
            using (var command = conn.CreateCommand())
            {
                command.CommandText = SQLQuery;
                await conn.OpenAsync();
                return (int)await command.ExecuteScalarAsync();
            }
        }

        public void UpdateEntityFromDb(T Entity)
        {
            _repository.Context.Entry(Entity).Reload();
        }

        public void RemoveEntityFromContext(T Entity)
        {
            _repository.Context.Entry(Entity).State = EntityState.Detached;
        }



        bool disposed = false;

        /// <summary>
        /// Disposes the current object
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes all external resources.
        /// </summary>
        /// <param name="disposing">The dispose indicator.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing && _unitOfWork != null)
            {
                _unitOfWork.Dispose();
                _unitOfWork = null;
            }
            disposed = true;
        }

        public virtual IQueryable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            IQueryable<T> query = _repository.GetAll();

            if (filter != null)
                query = query.Where(filter);

            if (includes != null)
                query = includes(query);

            if (orderBy != null)
                query = orderBy(query);

            return query;
        }
    }
}
