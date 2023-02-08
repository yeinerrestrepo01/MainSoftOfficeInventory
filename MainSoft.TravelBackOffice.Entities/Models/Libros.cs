using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainSoft.TravelBackOffice.Entities.Models
{
    /// <summary>
    /// Modelo de base de datos pata la tabla <table>Libros</table>
    /// </summary>
    public class Libros
    {
        public int Id { get; set; }
        [Key]
        public int Isbn { get; set; }

        [ForeignKey("EditorialId")]
        public int EditorialId { get; set; }
        public string? Titulo { get; set; }
        public string? Sinopsis { get; set; }
        public int NPaginas { get; set; }
        public virtual Editoriales Editoriales { get; set; }
        public virtual List<AutoresLibros> AutoresLibros { get; set; } = new List<AutoresLibros>();
    }
}
