using System.ComponentModel.DataAnnotations;
using System.IO.Pipes;

namespace MainSoft.TravelBackOffice.Entities.Models
{
    /// <summary>
    /// Modelo de base de datos pata la tabla <table>Editoriales</table>
    /// </summary>
    public class Editoriales
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Sede { get; set; }

        public virtual List<Libros> Libros { get; set; } = new List<Libros>();

    }
}
