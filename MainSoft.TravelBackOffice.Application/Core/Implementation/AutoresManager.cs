using AutoMapper;
using MainSoft.TravelBackOffice.Application.Base;
using MainSoft.TravelBackOffice.Entities.Dto;
using MainSoft.TravelBackOffice.Entities.Models;
using MainSoft.TravelBackOffice.Entities.Request;
using MainSoft.TravelBackOffice.Infraestructure.Base;

namespace MainSoft.TravelBackOffice.Application.Core.Implementation
{
    /// <summary>
    /// Clase manejadora para los proceso relacionados con la gestion de Autores
    /// </summary>
    public class AutoresManager : EntityManager<Autores>, IAutoresManager
    {
        private readonly IMapper _mapper;

        private readonly RespuestaGenerica<bool> _respuestaGenerica;

        /// <summary>
        /// Inicializador de la clase <class>AutoresManager</class>
        /// </summary>
        /// <param name="unitOfWork">dependencia de unidad de trabajo Autores</param>
        /// <param name="repository">dependencia para repositorio de trabajo para Autores</param>
        /// <param name="mapper"></param>
        public AutoresManager(IUnitOfWork unitOfWork, IRepository<Autores> repository, IMapper mapper)
            : base(unitOfWork, repository)
        {
            _mapper = mapper;
            _respuestaGenerica = new RespuestaGenerica<bool>();
        }

        /// <summary>
        /// Metodo para realizar la creacion de los registros en la tabla de autores
        /// </summary>
        /// <param name="autoresRequest"></param>
        /// <returns>RespuestaGenerica</returns>
        public RespuestaGenerica<bool> InsertarAutor(AutoresRequest autoresRequest)
        {
            var mapAutores = _mapper.Map<Autores>(autoresRequest);
            Insert(mapAutores);
            Commit();
            return _respuestaGenerica;
        }
    }
}
