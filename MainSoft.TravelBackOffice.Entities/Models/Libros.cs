using System.ComponentModel.DataAnnotations;

namespace MainSoft.TravelBackOffice.Entities.Models
{
    public class Libros
    {
        public int Id { get; set; }

        [Key]
        public int Isbn { get; set; }
        public int EditorialId { get; set; }
        public string? Titulo { get; set; }
        public string? Sinopsis { get; set; }
        public int NPaginas { get; set; }
    }
}
