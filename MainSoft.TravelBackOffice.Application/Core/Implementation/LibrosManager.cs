using MainSoft.TravelBackOffice.Application.Base;
using MainSoft.TravelBackOffice.Entities.Models;
using MainSoft.TravelBackOffice.Infraestructure.Base;

namespace MainSoft.TravelBackOffice.Application.Core.Implementation
{
    /// <summary>
    /// Clase manejadora para los proceso relacionados con la gestion de Libros
    /// </summary>
    public class LibrosManager : EntityManager<Libros>, ILibrosManager
    {
        /// <summary>
        /// Inicializador de la clase <class>LibrosManager</class>
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="repository"></param>
        public LibrosManager(IUnitOfWork unitOfWork, IRepository<Libros> repository) : base(unitOfWork, repository)
        {
        }
    }
}
