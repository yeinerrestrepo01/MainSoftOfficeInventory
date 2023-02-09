using AutoMapper;
using MainSoft.TravelBackOffice.Application.Base;
using MainSoft.TravelBackOffice.Entities.Dto;
using MainSoft.TravelBackOffice.Entities.Models;
using MainSoft.TravelBackOffice.Entities.Request;
using MainSoft.TravelBackOffice.Infraestructure.Base;

namespace MainSoft.TravelBackOffice.Application.Core.Implementation
{
    /// <summary>
    /// Clase manejadora para los proceso relacionados con la gestion de Editoriales
    /// </summary>
    public class EditorialesManager : EntityManager<Editoriales>, IEditorialesManager
    {
        private readonly IMapper _mapper;

        private readonly RespuestaGenerica<bool> _respuestaGenerica;

        /// <summary>
        /// Inializador de clase <class>EditorialesManager</class>
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="repository"></param>
        public EditorialesManager(IUnitOfWork unitOfWork, IRepository<Editoriales> repository, IMapper mapper)
            : base(unitOfWork, repository)
        {
            _mapper = mapper;
            _respuestaGenerica = new RespuestaGenerica<bool>();
        }

        /// <summary>
        /// Metodo para realizar la creacion de los registros de las editoriales
        /// </summary>
        /// <param name="requestEditoriales"></param>
        /// <returns></returns>

        public RespuestaGenerica<bool> InsertarEditorial(RequestEditoriales requestEditoriales)
        {
            var mapEditoriales = _mapper.Map<Editoriales>(requestEditoriales);
            Insert(mapEditoriales);
            Commit();
            return _respuestaGenerica;
        }
    }
}
