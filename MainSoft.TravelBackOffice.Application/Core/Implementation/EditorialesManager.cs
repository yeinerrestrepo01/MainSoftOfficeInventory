using MainSoft.TravelBackOffice.Application.Base;
using MainSoft.TravelBackOffice.Entities.Models;
using MainSoft.TravelBackOffice.Infraestructure.Base;

namespace MainSoft.TravelBackOffice.Application.Core.Implementation
{
    /// <summary>
    /// Clase manejadora para los proceso relacionados con la gestion de Editoriales
    /// </summary>
    public class EditorialesManager : EntityManager<Editoriales>, IEditorialesManager
    {
        /// <summary>
        /// Inializador de clase <class>EditorialesManager</class>
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="repository"></param>
        public EditorialesManager(IUnitOfWork unitOfWork, IRepository<Editoriales> repository) : base(unitOfWork, repository)
        {
        }
    }
}
