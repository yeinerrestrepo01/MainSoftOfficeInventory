using System.ComponentModel.DataAnnotations.Schema;

namespace MainSoft.TravelBackOffice.Entities.Models
{
    /// <summary>
    /// Modelo de base de datos pata la tabla <table>AutoresLibros</table>
    /// </summary>
    public class AutoresLibros
    {
        public int Id { get; set; }

        [ForeignKey("AutorId")]
        public int AutorId { get; set; }

        [ForeignKey("IsbnLibro")]
        public int IsbnLibro { get; set; }
        public virtual Autores Autores { get; set; }
        public virtual Libros Libros { get; set; }
    }
}
