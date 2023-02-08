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

        /// <summary>
        /// Metodo para obtener el listado de libros actuales almacenados en la tabla libros y editorial asociada.
        /// </summary>
        /// <returns>listado de libros</returns>
        public List<LibrosDto> ObtenerListadoLibros()
        {
            var librosaut = _autoresLibrosManager.Get(includes: t => t.Include(i => i.Libros).Include(y => y.Autores)).ToList();
            var result = Get(includes: t => t.Include(r => r.Editoriales)).ToList();
            return new List<LibrosDto>();
        }
    }
}
