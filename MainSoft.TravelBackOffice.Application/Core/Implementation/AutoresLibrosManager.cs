using MainSoft.TravelBackOffice.Application.Base;
using MainSoft.TravelBackOffice.Entities.Dto;
using MainSoft.TravelBackOffice.Entities.Models;
using MainSoft.TravelBackOffice.Infraestructure.Base;
using Microsoft.EntityFrameworkCore;

namespace MainSoft.TravelBackOffice.Application.Core.Implementation
{
    /// <summary>
    /// Clase manejadora para los proceso relacionados con la gestion de Autores libros
    /// </summary>
    public class AutoresLibrosManager : EntityManager<AutoresLibros>, IAutoresLibrosManager
    {
        /// <summary>
        /// Inicializador de la clase <class>AutoresManager</class>
        /// </summary>
        /// <param name="unitOfWork">dependencia de unidad de trabajo Autores libros</param>
        /// <param name="repository">dependencia para repositorio de trabajo para Autores libros</param>
        public AutoresLibrosManager(IUnitOfWork unitOfWork, IRepository<AutoresLibros> repository) : base(unitOfWork, repository)
        {
        }

        /// <summary>
        /// Metodo para consulta la consulta de un libro en especifico por isbn
        /// </summary>
        /// <param name="isbnId">identificador de libro</param>
        /// <returns>LibrosDto</returns>
        public LibrosDto ObtenerLibroIsbnId(int isbnId)
        {
            var libroAutores = GetAll().Where(y=> y.IsbnLibro== isbnId)
                .Include(i=> i.Libros)
                .Include(y => y.Autores)
                .Include(e => e.Libros.Editoriales).
           Select(s => AutoresLibrosDto.GetLibrosDto(s)).FirstOrDefault();
            return libroAutores?? new LibrosDto();
        }

        /// <summary>
        /// Metodo para obtener el listado de libros actuales almacenados en la tabla libros y editorial asociada.
        /// </summary>
        /// <returns>listado de libros</returns>
        public List<LibrosDto> ObtenerListadoLibros()
        {
            var listadosLibrosAutores = Get(includes: t => t.Include(i => i.Libros)
            .Include(y => y.Autores)
            .Include(e => e.Libros.Editoriales)).
            Select(s => AutoresLibrosDto.GetLibrosDto(s)).ToList();
            return listadosLibrosAutores;
        }
    }
}
