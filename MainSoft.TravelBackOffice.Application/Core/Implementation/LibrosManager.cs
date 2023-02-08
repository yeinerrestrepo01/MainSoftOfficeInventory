using AutoMapper;
using MainSoft.TravelBackOffice.Application.Base;
using MainSoft.TravelBackOffice.Entities.Dto;
using MainSoft.TravelBackOffice.Entities.Models;
using MainSoft.TravelBackOffice.Infraestructure.Base;
using Microsoft.EntityFrameworkCore;

namespace MainSoft.TravelBackOffice.Application.Core.Implementation
{
    /// <summary>
    /// Clase manejadora para los proceso relacionados con la gestion de Libros
    /// </summary>
    public class LibrosManager : EntityManager<Libros>, ILibrosManager
    {
        private readonly IMapper _mapper;

        private readonly IAutoresLibrosManager _autoresLibrosManager;
        /// <summary>
        /// Inicializador de la clase <class>LibrosManager</class>
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="repository"></param>
        /// <param name="IMapper"></param>
        public LibrosManager(IUnitOfWork unitOfWork, 
            IRepository<Libros> repository, IMapper mapper, IAutoresLibrosManager autoresLibrosManager) : base(unitOfWork, repository)
        {
            _mapper = mapper;
            _autoresLibrosManager = autoresLibrosManager;   
        }

    }
}
