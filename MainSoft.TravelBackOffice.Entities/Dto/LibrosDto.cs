using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainSoft.TravelBackOffice.Entities.Dto
{
    /// <summary>
    /// Objeto de transferencia de datos de Libros
    /// </summary>
    public class LibrosDto
    {
        public int Id { get; set; }
        public int Isbn { get; set; }
        public int EditorialId { get; set; }
        public string? NombreAutor { get; set; }
        public string? NombreEditorial { get; set; }
        public string? Titulo { get; set; }
        public string? Sinopsis { get; set; }
        public int NPaginas { get; set; }
    }
}
