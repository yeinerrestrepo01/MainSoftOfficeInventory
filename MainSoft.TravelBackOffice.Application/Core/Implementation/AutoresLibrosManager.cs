using MainSoft.TravelBackOffice.Application.Base;
using MainSoft.TravelBackOffice.Entities.Models;
using MainSoft.TravelBackOffice.Infraestructure.Base;

namespace MainSoft.TravelBackOffice.Application.Core.Implementation
{
    /// <summary>
    /// Clase manejadora para los proceso relacionados con la gestion de Autores libros
    /// </summary>
    public class AutoresLibrosManager : EntityManager<AutoresLibros>, IAutoresLibrosManager
    {
        /// <summary>
        /// Inicializador de la clase <class>AutoresManager</class>
        /// </summary>
        /// <param name="unitOfWork">dependencia de unidad de trabajo Autores libros</param>
        /// <param name="repository">dependencia para repositorio de trabajo para Autores libros</param>
        public AutoresLibrosManager(IUnitOfWork unitOfWork, IRepository<AutoresLibros> repository) : base(unitOfWork, repository)
        {
        }
    }
}
