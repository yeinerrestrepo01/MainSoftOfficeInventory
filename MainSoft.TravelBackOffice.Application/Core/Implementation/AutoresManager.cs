using MainSoft.TravelBackOffice.Application.Base;
using MainSoft.TravelBackOffice.Entities.Models;
using MainSoft.TravelBackOffice.Infraestructure.Base;

namespace MainSoft.TravelBackOffice.Application.Core.Implementation
{
    public class AutoresManager : EntityManager<Autores>, IAutoresManager
    {
        public AutoresManager(IUnitOfWork unitOfWork, IRepository<Autores> repository)
            : base(unitOfWork, repository)
        {
        }
    }
}
