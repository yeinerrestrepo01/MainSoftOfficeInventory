using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainSoft.TravelBackOffice.Entities.Models
{
    /// <summary>
    /// Modelo de base de datos pata la tabla <table>Autores</table>
    /// </summary>
    /// 
    [Table("Autores",Schema ="dbo")]
    public class Autores
    {
        public int Id { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }

        public virtual List<AutoresLibros> AutoresLibros { get; set; } = new List<AutoresLibros>(); 
    }
}
