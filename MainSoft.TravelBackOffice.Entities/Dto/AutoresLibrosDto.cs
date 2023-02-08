using MainSoft.TravelBackOffice.Entities.Models;

namespace MainSoft.TravelBackOffice.Entities.Dto
{
    /// <summary>
    /// Objeto de transferencia de datos de AutoresLibros
    /// </summary>
    public class AutoresLibrosDto
    {
        public int Id { get; set; }
        public int AutorId { get; set; }
        public int IsbnLibro { get; set; }

        /// <summary>
        /// Meotodo para realizar el set de datos de la entidad AutoresLibros al
        /// DTO LibrosDto
        /// </summary>
        /// <param name="AutoresLibros">Informacion de autores libros</param>
        /// <returns></returns>
        public static LibrosDto GetLibrosDto(AutoresLibros libro)
        {
            return new LibrosDto()
            {
                EditorialId = libro.Libros.EditorialId,
                Isbn = libro.Libros.Isbn,
                NombreAutor = $"{libro.Autores.Nombres} {libro.Autores.Apellidos}",
                NombreEditorial = $"{libro.Libros.Editoriales.Nombre}",
                Sinopsis = libro.Libros.Sinopsis,
                NPaginas = libro.Libros.NPaginas,
                Titulo = libro.Libros.Titulo,
                Id = libro.Libros.Id,
                SedeEditorial = $"{libro.Libros.Editoriales.Sede}"
            };
        }
    }
}
