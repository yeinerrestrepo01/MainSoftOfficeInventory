using MainSoft.TravelBackOffice.Application.Base;
using MainSoft.TravelBackOffice.Entities.Dto;
using MainSoft.TravelBackOffice.Entities.Models;
using MainSoft.TravelBackOffice.Entities.Request;

namespace MainSoft.TravelBackOffice.Application.Core
{
    /// <summary>
    /// Interface de defincion de metodos para la gestion de Autores
    /// </summary>
    public interface IAutoresManager : IEntityManager<Autores>
    {
        /// <summary>
        /// Metodo para realizar la creacion de los registros en la tabla de autores
        /// </summary>
        /// <param name="autoresRequest"></param>
        /// <returns>RespuestaGenerica</returns>
        RespuestaGenerica<bool> InsertarAutor(AutoresRequest autoresRequest);
    }
}
