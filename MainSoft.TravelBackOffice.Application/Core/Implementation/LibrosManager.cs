using AutoMapper;
using MainSoft.TravelBackOffice.Application.Base;
using MainSoft.TravelBackOffice.Entities.Dto;
using MainSoft.TravelBackOffice.Entities.Models;
using MainSoft.TravelBackOffice.Entities.Request;
using MainSoft.TravelBackOffice.Infraestructure.Base;

namespace MainSoft.TravelBackOffice.Application.Core.Implementation
{
    /// <summary>
    /// Clase manejadora para los proceso relacionados con la gestion de Libros
    /// </summary>
    public class LibrosManager : EntityManager<Libros>, ILibrosManager
    {
        private readonly IMapper _mapper;

        private readonly RespuestaGenerica<bool> _respuestaGenerica;
        /// <summary>
        /// Inicializador de la clase <class>LibrosManager</class>
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="repository"></param>
        /// <param name="IMapper"></param>
        public LibrosManager(IUnitOfWork unitOfWork,
            IRepository<Libros> repository, IMapper mapper) : base(unitOfWork, repository)
        {
            _mapper = mapper;
            _respuestaGenerica = new RespuestaGenerica<bool>();
        }

        /// <summary>
        /// Metodo para gestionar la creacion de los registros de libros en la tabla
        /// Libros
        /// </summary>
        /// <param name="librosRequest">informacion de libro a registrar</param>
        /// <returns>Respuesta de transaccion</returns>
        public RespuestaGenerica<bool> InsertarLibro(LibrosRequest librosRequest)
        {
                var mapLibros = _mapper.Map<Libros>(librosRequest);
                Insert(mapLibros);
                Commit();
            return _respuestaGenerica;
        }
    }
}
