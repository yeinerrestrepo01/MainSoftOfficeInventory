using MainSoft.TravelBackOffice.Application.Base;
using MainSoft.TravelBackOffice.Entities.Dto;
using MainSoft.TravelBackOffice.Entities.Models;

namespace MainSoft.TravelBackOffice.Application.Core
{
    /// <summary>
    /// Interface de defincion de metodos para la gestion de Libros
    /// </summary>
    public interface ILibrosManager : IEntityManager<Libros>
    {
        /// <summary>
        /// Metodo para obtener el listado de libros actuales almacenados en la tabla libros y editorial asociada.
        /// </summary>
        /// <returns>listado de libros</returns>
        public List<LibrosDto> ObtenerListadoLibros();
    }
}
