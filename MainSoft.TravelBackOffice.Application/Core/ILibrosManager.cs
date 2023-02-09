using MainSoft.TravelBackOffice.Application.Base;
using MainSoft.TravelBackOffice.Entities.Dto;
using MainSoft.TravelBackOffice.Entities.Models;
using MainSoft.TravelBackOffice.Entities.Request;

namespace MainSoft.TravelBackOffice.Application.Core
{
    /// <summary>
    /// Interface de defincion de metodos para la gestion de Libros
    /// </summary>
    public interface ILibrosManager : IEntityManager<Libros>
    {
        /// <summary>
        /// Metodo para gestionar la creacion de los registros de libros en la tabla
        /// Libros
        /// </summary>
        /// <param name="librosRequest">informacion de libro a registrar</param>
        /// <returns>Respuesta de transaccion</returns>
        RespuestaGenerica<bool> InsertarLibro(LibrosRequest librosRequest);
    }
}
