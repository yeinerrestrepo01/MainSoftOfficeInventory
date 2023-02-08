using System.ComponentModel.DataAnnotations;

namespace MainSoft.TravelBackOffice.Entities.Models
{
    /// <summary>
    /// Modelo de base de datos pata la tabla <table>Autores</table>
    /// </summary>
    public class Autores
    {
        [Key]
        public int Id { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }

        public virtual List<AutoresLibros> AutoresLibros { get; set; } = new List<AutoresLibros>();
    }
}
