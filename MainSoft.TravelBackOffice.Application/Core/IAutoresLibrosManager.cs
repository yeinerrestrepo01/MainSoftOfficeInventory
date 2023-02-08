using MainSoft.TravelBackOffice.Application.Base;
using MainSoft.TravelBackOffice.Entities.Dto;
using MainSoft.TravelBackOffice.Entities.Models;

namespace MainSoft.TravelBackOffice.Application.Core
{
    /// <summary>
    /// Interface de defincion de metodos para la gestion de Autores
    /// </summary>
    public interface IAutoresLibrosManager : IEntityManager<AutoresLibros>
    {
        /// <summary>
        /// Metodo para obtener el listado de libros actuales almacenados en la tabla libros y editorial asociada.
        /// </summary>
        /// <returns>listado de libros</returns>
        public List<LibrosDto> ObtenerListadoLibros();

        /// <summary>
        /// Metodo para consulta la consulta de un libro en especifico por isbn
        /// </summary>
        /// <param name="isbnId">identificador de libro</param>
        /// <returns>LibrosDto</returns>
        public LibrosDto ObtenerLibroIsbnId(int isbnId);
    }
}
