using MainSoft.TravelBackOffice.Application.Base;
using MainSoft.TravelBackOffice.Entities.Dto;
using MainSoft.TravelBackOffice.Entities.Models;
using MainSoft.TravelBackOffice.Entities.Request;

namespace MainSoft.TravelBackOffice.Application.Core
{
    /// <summary>
    /// Interface de defincion de metodos para la gestion de Editoriales
    /// </summary>
    public interface IEditorialesManager : IEntityManager<Editoriales>
    {
        /// <summary>
        /// Metodo para realizar la creacion de los registros de las editoriales
        /// </summary>
        /// <param name="requestEditoriales"></param>
        /// <returns></returns>
        RespuestaGenerica<bool> InsertarEditorial(RequestEditoriales requestEditoriales);
    }
}
