using MainSoft.TravelBackOffice.Application.Base;
using MainSoft.TravelBackOffice.Entities.Models;
using MainSoft.TravelBackOffice.Infraestructure.Base;

namespace MainSoft.TravelBackOffice.Application.Core.Implementation
{
    /// <summary>
    /// Clase manejadora para los proceso relacionados con la gestion de Autores
    /// </summary>
    public class AutoresManager : EntityManager<Autores>, IAutoresManager
    {
        /// <summary>
        /// Inicializador de la clase <class>AutoresManager</class>
        /// </summary>
        /// <param name="unitOfWork">dependencia de unidad de trabajo Autores</param>
        /// <param name="repository">dependencia para repositorio de trabajo para Autores</param>
        public AutoresManager(IUnitOfWork unitOfWork, IRepository<Autores> repository)
            : base(unitOfWork, repository)
        {
        }
    }
}
